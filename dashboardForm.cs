using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace AdminDashboard
{
    public partial class DashboardForm : Form
    {
        private int cornerRadius = 30; // Adjust this for roundness
        public DashboardForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(this.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, this.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalFundsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalMemberPanel_Paint(object sender, PaintEventArgs e)
        {
            if (totalMemberPanel.BackgroundImage != null)
            {
                Image img = totalMemberPanel.BackgroundImage;
                int x = totalMemberPanel.Width - img.Width;
                int y = (totalMemberPanel.Height - img.Height) / 2;

                e.Graphics.DrawImage(img, x, y);
            }
        }
    }
}
