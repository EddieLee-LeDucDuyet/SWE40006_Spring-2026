using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeployTask1   // <- keep this the same as your project namespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Student Information - SWE40006";

            string info =
                "Name: Le Duc Duyet\r\n" +
                "StudentID: 105243570\r\n" +
                "Email: leducduyet11@gmail.com\r\n" +
                "Class: SWE40006 Software Deployment and Evolution\r\n" +
                "Semester: Spring 2026";

            Label lbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Location = new Point(20, 20),
                Text = info
            };

            this.Controls.Add(lbl);
        }
    }
}
