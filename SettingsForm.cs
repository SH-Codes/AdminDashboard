using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void darkModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (darkModeRadioButton.Checked)
            {
                var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.MainPanel.BackColor = Color.FromArgb(30, 30, 30);
                    mainForm.ContainerPanel.BackColor = Color.FromArgb(36, 36, 37);
                }

            }
        }

        private void lightModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lightModeRadioButton.Checked)
            {
                var mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.MainPanel.BackColor = SystemColors.Highlight;
                    mainForm.ContainerPanel.BackColor = Color.WhiteSmoke;
                }

            }
        }
    }
}
