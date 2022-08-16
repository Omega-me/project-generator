using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_generator
{
    public partial class FileGenerator : Form
    {
        private string folderName;
        public FileGenerator()
        {
            InitializeComponent();
        }

        private void FileGenerator_Load(object sender, EventArgs e)
        {
            // Add filter to file dialog for selecting solution file only
            selectSlnPathDialog.Filter = "Solutionn Files (*.sln)|*.sln;";
            selectSlnPathDialog.FilterIndex = 1;
            selectSlnPathDialog.Multiselect = false;
        }

        #region .NET
        private void dotnetRepoSolutionSetPathBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = selectSlnPathDialog.ShowDialog();
            if (dialogResult==DialogResult.OK && !string.IsNullOrEmpty(selectSlnPathDialog.FileName))
            {
                dotnetRepoSolutionPathField.Text=selectSlnPathDialog.FileName;
                folderName=new DirectoryInfo(Path.GetDirectoryName(selectSlnPathDialog.FileName)).FullName;
                dotnetRepoSolutionPathField.Enabled = true;

            }
        }
        private void dotnetRepoResetBtn_Click(object sender, EventArgs e)
        {
            dotnetRepoSolutionPathField.Text = null;
            repoDomainNameField.Text = null;
            dotnetResponseCheckbox.Checked = false;
            dotnetRepoShowInstructionCheckbox.Checked = true;
            folderName = null;
        }
        private void dotnetGenerateRepoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dotnetRepoSolutionPathField.Text))
            {
                MessageBox.Show("Please specify the project solution path", "Inavlid solution path");
                return;
            }
            if (string.IsNullOrEmpty(repoDomainNameField.Text))
            {
                MessageBox.Show("Please specify Entity name", "Inavlid entity name");
                return;
            }
        }


        #endregion

       
    }
}
