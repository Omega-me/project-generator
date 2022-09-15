using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using CliWrap;
using CliWrap.Buffered;

namespace Project_generator
{
    public partial class projectGenerator : Form
    {
        Loading loadingForm = new Loading();
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
        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
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
        private async void generateReactProjectBtn_Click(object sender, EventArgs e)
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
            if (baseArchitectureRadio.Checked)
            {
                if (Directory.Exists($@"{pathField.Text}\{nameField.Text}"))
                {
                    MessageBox.Show($@"This directory {pathField.Text}\{nameField.Text} exists, please use different name for your project or delete the directory first", "Directory conflict");
                    return;
                }
                loadingForm.Show();
                var result = await Cli.Wrap("npx")
                    .WithArguments(new[] { "create-react-app", nameField.Text, "--template", "omegame" })
                    .WithWorkingDirectory(pathField.Text)
                    .ExecuteBufferedAsync();
                await Cli.Wrap("powershell").WithArguments("code .").WithWorkingDirectory($@"{pathField.Text}\{nameField.Text}").ExecuteAsync();
                terminalField.Text = result.StandardOutput;
                showLogsRadio.Checked = true;
                loadingForm.Hide();
                return;
            }
            if (reactMicroFrontendArchitectureRadio.Checked)
            {
                if (Directory.Exists($@"{pathField.Text}\{nameField.Text}"))
                {
                    MessageBox.Show($@"This directory {pathField.Text}\{nameField.Text} exists, please use different name for your project or delete the directory first", "Directory conflict");
                    return;
                }
                loadingForm.Show();
                var result = await Cli.Wrap("npx")
                .WithArguments(new[] { "create-react-app", nameField.Text, "--template", "omegamemicro" })
                .WithWorkingDirectory(pathField.Text)
                .ExecuteBufferedAsync();
                await Cli.Wrap("powershell").WithArguments("code .").WithWorkingDirectory($@"{pathField.Text}\{nameField.Text}").ExecuteAsync();
                terminalField.Text = result.StandardOutput;
                showLogsRadio.Checked = true;
                loadingForm.Hide();
                return;
            }
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
            List<string> commands = new List<string>
            {
                $"cd {nextPathField.Text}",
                $"{nextNameField.Text}",
                $"cd {nextNameField.Text}",
                "code .",
            };
            if (nextBaseArchitectureRadio.Checked)
            {
                Generate("NEXT",nextPathField.Text,nextNameField.Text, commands);
                return;
            }
            if (nextMicroFrontendArchitectureRadio.Checked)
            {
                Generate("NEXTMICRO", nextPathField.Text, nextNameField.Text,commands);
                return;
            }
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
            List<string> commands = new List<string>
            {
                $"cd {nodejsPathField.Text}",
                $"{nodejsNameField.Text}",
                $"cd {nodejsNameField.Text}",
                "code .",
            };
            if (nodejsTypescriptCheck.Checked && nodejsSqlRadio.Checked)
            {
                Generate("NODETSQL",nodejsPathField.Text,nodejsNameField.Text, commands);
                return;
            }
            if (nodejsTypescriptCheck.Checked && nodejsNoSqlRadio.Checked)
            {
                Generate("NODETNOSQL", nodejsPathField.Text, nodejsNameField.Text, commands);
                return;
            }
            if (!nodejsTypescriptCheck.Checked && nodejsSqlRadio.Checked)
            {
                Generate("NODESQL", nodejsPathField.Text, nodejsNameField.Text, commands);
                return;
            }
            if (!nodejsTypescriptCheck.Checked && nodejsNoSqlRadio.Checked)
            {
                Generate("NODENOSQL", nodejsPathField.Text, nodejsNameField.Text, commands);
                return;
            }
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
            useAuthDotnetCheckbox.Checked = true;
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
            List<string> commands = new List<string>
            {
                $"cd {dotnetPathField.Text}",
                $"{dotnetNameField.Text}",
                $"cd {dotnetNameField.Text}",
                "code .",
            };
            if (cqerRepoRadio.Checked)
            {
                Generate("DOTNETREPO",dotnetPathField.Text,dotnetNameField.Text, commands);
                return;
            }
            if (cqrsMediatrRadio.Checked)
            {
                Generate("DOTNETMEDIATOR", dotnetPathField.Text, dotnetNameField.Text, commands);
                return;
            }
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
            FileGenerator fileGeneratorForm = new FileGenerator();
            fileGeneratorForm.Show();
        }
        private void Generate(string projectType,string path,string name, List<string> commands)
        {
            string pathString;
            string folderDir = $@"{path}";
            string fileName = name;
            pathString = Path.Combine(folderDir, fileName);
            pathString = Path.ChangeExtension(pathString, "bat");

            if (!File.Exists(pathString))
            {
                using (FileStream fs = File.Create(pathString))
                {
                    terminalField.Text = pathString;
                }
            }
            else
            {
                File.Delete(@"" + pathString);
                using (FileStream fs = File.Create(pathString))
                {
                    terminalField.Text = pathString;
                }
            }
            using (StreamWriter writer = new StreamWriter(pathString))
            {
                switch (projectType)
                {
                    case "REACT":
                        writer.WriteLine($"cd {path} \n " +
                            $"npx create-react-app {name} --template omegame");
                        break;
                    case "REACTMICRO":
                        writer.WriteLine($"cd {path} \n "
                        + "REACTMICRO");
                        break;
                    case "NEXT":
                        writer.WriteLine($"cd {path} \n "
                        + "NEXT");
                        break;
                    case "NEXTMICRO":
                        writer.WriteLine($"cd {path} \n "
                        + "NEXTMICRO");
                        break;
                    case "NODETSQL":
                        writer.WriteLine($"cd {path} \n "
                        + "NODETSQL");
                        break;
                    case "NODETNOSQL":
                        writer.WriteLine($"cd {path} \n "
                        + "NODETNOSQL");
                        break;
                    case "NODESQL":
                        writer.WriteLine($"cd {path} \n "
                        + "NODESQL");
                        break;
                    case "NODENOSQL":
                        writer.WriteLine($"cd {path} \n "
                        + "NODENOSQL");
                        break;
                    case "DOTNETREPO":
                        writer.WriteLine($"cd {path} \n "
                        + "DOTNETREPO");
                        break;
                    case "DOTNETMEDIATOR":
                        writer.WriteLine($"cd {path} \n "
                        + "DOTNETMEDIATOR");
                        break;
                }

            }
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            foreach (var command in commands)
            {
                cmd.StandardInput.WriteLine(command);
            }

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            terminalField.Text = cmd.StandardOutput.ReadToEnd();
            showLogsRadio.Checked = true;
            if (File.Exists(pathString))
            {
                File.Delete(@"" + pathString);
            }
        }
        #endregion
    }
}