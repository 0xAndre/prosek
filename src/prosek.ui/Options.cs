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

        /// <summary>
        /// Get a X-Header from file.
        /// </summary>
        private void Options_Load(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText(_X_HEADER_FILENAME)) ;

            string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

            if (!string.IsNullOrEmpty(xAbuseHeader))
            {
                textBoxAbuseHeader.Text = xAbuseHeader;
            }
        }

        /// <summary>
        /// Save a custom X-Header to file.
        /// </summary>
        private void buttonOptionsSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(_X_HEADER_FILENAME, textBoxAbuseHeader.Text);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to write the x-abuser-header");
            }

        }
    }
}
