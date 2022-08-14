using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Project_generator
{
    public partial class projectGenerator : Form
    {
        public projectGenerator()   
        {
            InitializeComponent();
        }
        private void projectGenerator_Load(object sender, EventArgs e)
        {
            reactGeneratorGroup.Show();
            nextGeneratorGroup.Show();
            nodejsGeneratorGroup.Show();
            dotnetGeneratorGroup.Show();
            terminalField.Hide();
            clearLogsBtn.Hide();
        }

        #region React
        private void setPathBtn_Click(object sender, EventArgs e)
        { 
            DialogResult dialogResult = folderBrowserPath.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserPath.SelectedPath))
            {
                pathField.Text = folderBrowserPath.SelectedPath;
                pathField.Enabled = true;
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            pathField.Text = null;
            pathField.Enabled = false;
            nameField.Text = null;
            baseArchitectureRadio.Checked = false;
            reactMicroFrontendArchitectureRadio.Checked = false;
        }
        private void generateReactProjectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pathField.Text))
            {
                MessageBox.Show("Please specify a path","Inavlid path");
                return;
            }
            if (string.IsNullOrWhiteSpace(nameField.Text))
            {
                MessageBox.Show("Please specify a project name","Invalid project name");
                return;
            }
            if (baseArchitectureRadio.Checked==false && reactMicroFrontendArchitectureRadio.Checked == false)
            {
                MessageBox.Show("Please choose a project architecture", "Invalid project type");
                return;
            }
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"cd {pathField.Text}");
            showLogsRadio.Checked = true;
            cmd.StandardInput.WriteLine($"npx create-react-app {nameField.Text} --template omegame");
            if (nameField.Text != ".")
            {
                cmd.StandardInput.WriteLine($"cd {nameField.Text}");
            }
            cmd.StandardInput.WriteLine($"code .");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            terminalField.Text= cmd.StandardOutput.ReadToEnd();
            resetBtn_Click(sender,e);
        }
        #endregion

        #region Next
        private void nextSetPathBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserPath.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserPath.SelectedPath))
            {
                nextPathField.Text = folderBrowserPath.SelectedPath;
                nextPathField.Enabled = true;
            }
        }
        private void nextResetBtn_Click(object sender, EventArgs e)
        {
            nextPathField.Text = null;
            nextPathField.Enabled = false;
            nextNameField.Text = null;
            nextBaseArchitectureRadio.Checked = false;
            nextMicroFrontendArchitectureRadio.Checked = false;
        }
        private void nextGenerateProjectBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nextPathField.Text))
            {
                MessageBox.Show("Please specify a path", "Inavlid path");
                return;
            }
            if (string.IsNullOrWhiteSpace(nextNameField.Text))
            {
                MessageBox.Show("Please specify a project name", "Invalid project name");
                return;
            }
            if (nextBaseArchitectureRadio.Checked == false && nextMicroFrontendArchitectureRadio.Checked == false)
            {
                MessageBox.Show("Please choose a project architecture", "Invalid project type");
                return;
            }
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"cd {nextPathField.Text}");
            //cmd.StandardInput.WriteLine($"npx create-react-app {nextNameField.Text} --template omegame");
            if(nextPathField.Text != ".")
            //{
                //cmd.StandardInput.WriteLine($"cd {nextNameField.Text}");
            //}
            cmd.StandardInput.WriteLine($"code .");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            terminalField.Text = cmd.StandardOutput.ReadToEnd();
            showLogsRadio.Checked = true;
        }

        #endregion

        #region Nodejs
        private void nodejsSetPathBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserPath.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserPath.SelectedPath))
            {
                nodejsPathField.Text = folderBrowserPath.SelectedPath;
                nodejsPathField.Enabled = true;
            }
        }

        private void nodejsResetBtn_Click(object sender, EventArgs e)
        {
            nodejsPathField.Text = null;
            nodejsPathField.Enabled = false;
            nodejsNameField.Text = null;
            nodejsSqlRadio.Checked = false;
            nodejsNoSqlRadio.Checked = false;
            nodejsTypescriptCheck.Checked = true;
        }

        private void nodejsgenerateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nodejsPathField.Text))
            {
                MessageBox.Show("Please specify a path", "Inavlid path");
                return;
            }
            if (string.IsNullOrWhiteSpace(nodejsNameField.Text))
            {
                MessageBox.Show("Please specify a project name", "Invalid project name");
                return;
            }
            if (nodejsSqlRadio.Checked == false && nodejsNoSqlRadio.Checked == false)
            {
                MessageBox.Show("Please choose a project Database type", "Invalid project database type");
                return;
            }
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"cd {nodejsPathField.Text}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            terminalField.Text = cmd.StandardOutput.ReadToEnd();
            showLogsRadio.Checked = true;
        }
        #endregion

        #region .Net
        private void dotnetSetPathBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserPath.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserPath.SelectedPath))
            {
                dotnetPathField.Text = folderBrowserPath.SelectedPath;
                dotnetPathField.Enabled = true;
            }
        }

        private void dotnetResetBtn_Click(object sender, EventArgs e)
        {
            dotnetPathField.Text = null;
            dotnetPathField.Enabled = false;
            dotnetNameField.Text = null;
            cqerRepoRadio.Checked = false;
            cqrsMediatrRadio.Checked = false;
        }

        private void dotnetGenerateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dotnetPathField.Text))
            {
                MessageBox.Show("Please specify a path", "Inavlid path");
                return;
            }
            if (string.IsNullOrWhiteSpace(dotnetNameField.Text))
            {
                MessageBox.Show("Please specify a project name", "Invalid project name");
                return;
            }
            if (cqerRepoRadio.Checked == false && cqrsMediatrRadio.Checked == false)
            {
                MessageBox.Show("Please choose a project architecture", "Invalid project type");
                return;
            }
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine($"cd {dotnetPathField.Text}");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            terminalField.Text = cmd.StandardOutput.ReadToEnd();
            showLogsRadio.Checked = true;
        }
        #endregion

        #region Container
        private void generatorRadio_CheckedChanged(object sender, EventArgs e)
        {
            reactGeneratorGroup.Show();
            nextGeneratorGroup.Show();
            nodejsGeneratorGroup.Show();
            dotnetGeneratorGroup.Show();
            terminalField.Hide();
            clearLogsBtn.Hide();
        }
        private void showLogsRadio_CheckedChanged(object sender, EventArgs e)
        {
            terminalField.Show();
            clearLogsBtn.Show();
            reactGeneratorGroup.Hide();
            nextGeneratorGroup.Hide();
            nodejsGeneratorGroup.Hide();
            dotnetGeneratorGroup.Hide();
        }

        private void clearLogsBtn_Click(object sender, EventArgs e)
        {
            terminalField.Text = null;
        }
        private void fileGenerator_Click(object sender, EventArgs e)
        {
           var fileGenerator =new FileGenerator();
            fileGenerator.Show();
        }
        #endregion
    }
}