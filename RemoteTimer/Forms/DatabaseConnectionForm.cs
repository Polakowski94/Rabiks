using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteTimer.Forms
{
    public partial class DatabaseConnectionForm: Form
    {
        private string Path;

        public DatabaseConnectionForm()
        {
            InitializeComponent();
        }

        private void OnSearchButtonClick(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "MDF Databases (*.mdf)";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = openFileDialog.FileName;
                    PathTextBox.Text = Path;
                }
            }

            //TODO: Move it to backend
        }

        private void OnConnectButtonClick(object sender, System.EventArgs e)
        {

        }
    }
}
