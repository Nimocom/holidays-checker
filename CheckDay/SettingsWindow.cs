using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckDay
{

    public partial class SettingsWindow : Form
    {
        public string apiURI;
        public static SettingsWindow Instance { get; set; } 

        public SettingsWindow()
        {
            InitializeComponent();

            if(Instance != null)
                Instance.Close();

            Instance = this;

            apiURI = textBoxAPI.Text;
            labelNote.Text = MainForm.Note;

        }
    }
}
