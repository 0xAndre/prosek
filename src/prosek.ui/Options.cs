using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosek.ui
{
    public partial class Options : Form
    {
        private string _X_HEADER_FILENAME = "xabuseheader.txt";

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(_X_HEADER_FILENAME));

            string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

            if(!string.IsNullOrEmpty(xAbuseHeader))
            {
                textBoxAbuseHeader.Text = xAbuseHeader;
            }
        }

        private void buttonOptionsSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxAbuseHeader.Text))
            {
                File.WriteAllText(_X_HEADER_FILENAME, textBoxAbuseHeader.Text);
            }

            this.Close();
        }
    }
}
