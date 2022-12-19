namespace CheckDay
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_StartTime = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_EndTime = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelCredits = new System.Windows.Forms.Label();
            this.checkBoxListDays = new System.Windows.Forms.CheckedListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelWorkingDays = new System.Windows.Forms.Label();
            this.textBoxList = new System.Windows.Forms.RichTextBox();
            this.checkBoxShowAll = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_StartTime.Location = new System.Drawing.Point(27, 39);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(49, 15);
            this.label_StartTime.TabIndex = 0;
            this.label_StartTime.Text = "Начало";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(99, 33);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 23);
            this.startTimePicker.TabIndex = 1;
            // 
            // label_EndTime
            // 
            this.label_EndTime.AutoSize = true;
            this.label_EndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_EndTime.Location = new System.Drawing.Point(27, 77);
            this.label_EndTime.Name = "label_EndTime";
            this.label_EndTime.Size = new System.Drawing.Size(44, 15);
            this.label_EndTime.TabIndex = 2;
            this.label_EndTime.Text = "Конец";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(99, 71);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(200, 23);
            this.endTimePicker.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(313, 288);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Инициалиция...";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Location = new System.Drawing.Point(357, 462);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(55, 15);
            this.labelCredits.TabIndex = 6;
            this.labelCredits.Text = "by NiMO";
            // 
            // checkBoxListDays
            // 
            this.checkBoxListDays.CheckOnClick = true;
            this.checkBoxListDays.FormattingEnabled = true;
            this.checkBoxListDays.Location = new System.Drawing.Point(313, 33);
            this.checkBoxListDays.Name = "checkBoxListDays";
            this.checkBoxListDays.Size = new System.Drawing.Size(120, 112);
            this.checkBoxListDays.TabIndex = 7;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(27, 462);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(70, 15);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Всего дней:";
            // 
            // labelWorkingDays
            // 
            this.labelWorkingDays.AutoSize = true;
            this.labelWorkingDays.Location = new System.Drawing.Point(313, 14);
            this.labelWorkingDays.Name = "labelWorkingDays";
            this.labelWorkingDays.Size = new System.Drawing.Size(77, 15);
            this.labelWorkingDays.TabIndex = 9;
            this.labelWorkingDays.Text = "Рабочие дни";
            // 
            // textBoxList
            // 
            this.textBoxList.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxList.Location = new System.Drawing.Point(27, 137);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ReadOnly = true;
            this.textBoxList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxList.Size = new System.Drawing.Size(272, 322);
            this.textBoxList.TabIndex = 10;
            this.textBoxList.Text = "";
            // 
            // checkBoxShowAll
            // 
            this.checkBoxShowAll.AutoSize = true;
            this.checkBoxShowAll.Location = new System.Drawing.Point(313, 263);
            this.checkBoxShowAll.Name = "checkBoxShowAll";
            this.checkBoxShowAll.Size = new System.Drawing.Size(112, 19);
            this.checkBoxShowAll.TabIndex = 11;
            this.checkBoxShowAll.Text = "Показывать все";
            this.checkBoxShowAll.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MM/dd/yyyy",
            "MM/dd/yy",
            "MM.dd.yyyy",
            "MM.dd.yy",
            "dd/MM/yy",
            "dd.MM.yy",
            "dd/MM/yyyy",
            "dd.MM.yyyy",
            "yyyy/MM/dd",
            "MMMM dd",
            "dddd, dd MMMM yyyy",
            "dd MMMM yyyy"});
            this.comboBox1.Location = new System.Drawing.Point(159, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "MM/dd/yyyy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Enabled = false;
            this.buttonSaveToFile.Location = new System.Drawing.Point(313, 327);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(120, 23);
            this.buttonSaveToFile.TabIndex = 15;
            this.buttonSaveToFile.Text = "Сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 95);
            this.label1.TabIndex = 16;
            this.label1.Text = "Программа рассчитывает даты с УЧЁТОМ выходных! Т.е. нерабочие дни исключаются.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Формат даты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(456, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxShowAll);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.labelWorkingDays);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.checkBoxListDays);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.label_EndTime);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label_StartTime);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор рабочих дней";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_StartTime;
        private DateTimePicker startTimePicker;
        private Label label_EndTime;
        private DateTimePicker endTimePicker;
        private Button buttonCalculate;
        private Label labelCredits;
        private CheckedListBox checkBoxListDays;
        private Label labelTotal;
        private Label labelWorkingDays;
        private RichTextBox textBoxList;
        private CheckBox checkBoxShowAll;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button buttonSaveToFile;
        private Label label1;
        private Label label2;
    }
}