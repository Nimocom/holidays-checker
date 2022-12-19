using System.Text.Json;
using System.Globalization;
using System.Media;

namespace CheckDay
{
    public partial class MainForm : Form
    {
        public static string Note;

        CalendarData? calendatData;
        List<DateTime> exceptedDates;

        string workingDaysList;

        public MainForm()
        {
            InitializeComponent();
            buttonCalculate.Enabled = false;

            InitializeData();
            GetWeekDaysByCulture(CultureInfo.CurrentCulture);
        }

        async void InitializeData()
        {
            HttpResponseMessage response = null;

            try
            {
                HttpClient webClient = new HttpClient();

                new SettingsWindow();

                response = await webClient.GetAsync(SettingsWindow.Instance.apiURI);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Не удалось отправить запрос!", "Ошибка сети");
            }

            var jsonData = await response.Content.ReadAsStringAsync();

            if (!String.IsNullOrEmpty(jsonData))
                calendatData = JsonSerializer.Deserialize<CalendarData>(jsonData);

            Note = calendatData.Status;

            await Task.Run(() => ParseData());

            buttonCalculate.Text = "Рассчитать!";
            buttonCalculate.Enabled = true;
        }

        void GetWeekDaysByCulture(CultureInfo cultureInfo)
        {
            checkBoxListDays.Items.Add(cultureInfo.DateTimeFormat.GetDayName(DayOfWeek.Monday));
            checkBoxListDays.Items.Add(cultureInfo.DateTimeFormat.GetDayName(DayOfWeek.Tuesday));
            checkBoxListDays.Items.Add(cultureInfo.DateTimeFormat.GetDayName(DayOfWeek.Wednesday));
            checkBoxListDays.Items.Add(cultureInfo.DateTimeFormat.GetDayName(DayOfWeek.Thursday));
            checkBoxListDays.Items.Add(cultureInfo.DateTimeFormat.GetDayName(DayOfWeek.Friday));
            checkBoxListDays.Items.Add(cultureInfo.DateTimeFormat.GetDayName(DayOfWeek.Saturday));

        }

        void ParseData()
        {
            // string format = "yyyy-MM-dd";

            exceptedDates = new List<DateTime>();

            for (int i = 0; i < calendatData.holidays.Count; i++)
                exceptedDates.Add(DateTime.Parse(calendatData.holidays[i]));
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            textBoxList.ResetText();
            workingDaysList = "";

            if (checkBoxListDays.CheckedItems.Count == 0)
                MessageBox.Show("Выберите Ваши рабочие дни!", "Ошибка!");

            buttonCalculate.Enabled = false;

            int counter = 0;

            foreach (var item in EachDay(startTimePicker.Value, endTimePicker.Value))
            {
                if (IsDaySelected(item))
                {
                    if (IsWorkingDay(item))
                    {
                        string finalString = item.ToString(comboBox1.Text) + Environment.NewLine;
                        textBoxList.AppendText(finalString);
                        workingDaysList += finalString;
                        counter++;
                    }
                    else if (checkBoxShowAll.Checked)
                    {
                        textBoxList.AppendText(item.ToString(comboBox1.Text) + Environment.NewLine);
                        textBoxList.Select(textBoxList.GetFirstCharIndexFromLine(textBoxList.Lines.Length - 2), textBoxList.Lines[textBoxList.Lines.Length - 2].Length);
                        textBoxList.SelectionColor = Color.Gray;
                    }
                }
            }

            labelTotal.Text = "Всего дней: " + counter.ToString();
            buttonCalculate.Enabled = true;

            if (counter > 0)
                buttonSaveToFile.Enabled = true;
            else
                buttonSaveToFile.Enabled = false;
        }


        bool IsDaySelected(DateTime dateTime)
        {
            string dayName = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            return checkBoxListDays.CheckedItems.Contains(dayName);
        }

        bool IsWorkingDay(DateTime dateTime)
        {
            return !exceptedDates.Contains(dateTime);
        }

        IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CalendarData
        {
            public List<string> holidays { get; set; }
            public string Status { get; set; }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            new SettingsWindow().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new SettingsWindow().Show();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (workingDaysList.Length > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, workingDaysList);
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Файл успешно сохранен!","Успех!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не удалось сохранить в файл!", "Ошибка сохранения!");
                    }
                }

            }
        }
    }
}