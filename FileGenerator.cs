using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scriban;

namespace Project_generator
{
    public partial class FileGenerator : Form
    {
        private string folderName;
        private string folderPath;
        private string templatePath;
        private string dotnetRepoClassType;
        private string dotnetRepoInherits;
        private string dotnetRepoNamespace;
        private string dotnetRepoClassName;
        private string dotnetRepoTemplateText;
        private string dotnetRepoEntityname;

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
            // Get the templates path
            templatePath = @"" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Templates";
        }

        #region .NET
        private void dotnetRepoSolutionSetPathBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = selectSlnPathDialog.ShowDialog();
            if (dialogResult==DialogResult.OK && !string.IsNullOrEmpty(selectSlnPathDialog.FileName))
            {
                dotnetRepoSolutionPathField.Text=selectSlnPathDialog.FileName;
                folderName = new DirectoryInfo(Path.GetDirectoryName(selectSlnPathDialog.FileName)).Name;
                folderPath = new DirectoryInfo(Path.GetDirectoryName(selectSlnPathDialog.FileName)).FullName;
            }
        }
        private void dotnetRepoResetBtn_Click(object sender, EventArgs e)
        {
            dotnetRepoSolutionPathField.Text = null;
            repoDomainNameField.Text = null;
            dotnetResponseCheckbox.Checked = false;
            dotnetRepoShowInstructionCheckbox.Checked = true;
            folderPath = null;
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

            List<FileNames> files = new List<FileNames>
            {
                new FileNames{
                    Name = repoDomainNameField.Text,
                    Path = $"{folderPath}\\{folderName}.Domain\\Entitites",
                },
                new FileNames{
                    Name = $"I{repoDomainNameField.Text}Query",
                    Path = $"{folderPath}\\{folderName}.Application\\Contracts\\RepositoryManager\\Query",
                },
                new FileNames{
                    Name = $"I{repoDomainNameField.Text}Command",
                    Path = $"{folderPath}\\{folderName}.Application\\Contracts\\RepositoryManager\\Command",
                },
                new FileNames{
                    Name = $"{repoDomainNameField.Text}Query",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\RepositoryManager\\Query",
                },
                new FileNames{
                    Name = $"{repoDomainNameField.Text}Command",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\RepositoryManager\\Command",
                },
                new FileNames{
                    Name = $"{repoDomainNameField.Text}Configuration",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\DatabaseManager\\Configurations\\Entities",
                },
                new FileNames{
                    Name = $"{repoDomainNameField.Text}Manager",
                    Path = $"{folderPath}\\{folderName}.Presantation\\Managers",
                },
                new FileNames{
                    Name = $"{repoDomainNameField.Text}Controller",
                    Path = $"{folderPath}\\{folderName}.Presantation\\Controllers",
                },
            };
            if (dotnetResponseCheckbox.Checked)
            {
                files.Add(
                    new FileNames
                    {
                        Name = $"{repoDomainNameField.Text}ModelStateFilter",
                        Path = $"{folderPath}\\{folderName}.Application\\Exceptions\\ValidationResponseFilters",
                    }
                );
                files.Add(
                    new FileNames
                    {
                        Name = $"I{repoDomainNameField.Text}Response",
                        Path = $"{folderPath}\\{folderName}.Application\\Contracts\\Response",
                    }
                );
                files.Add(
                     new FileNames
                     {
                         Name = $"{repoDomainNameField.Text}Response",
                         Path = $"{folderPath}\\{folderName}.Application\\Configurations\\Response",
                     }
                );
            }


            foreach (FileNames file in files)
            {
                var templateText = ConfigureRepoGeneratedFiles(file);
                var template = Template.Parse(templateText);
                var result = template.Render(new {
                    classtype = dotnetRepoClassType,
                    namespacetext = $"{folderName}.{dotnetRepoNamespace}",
                    inherits = dotnetRepoInherits,
                    classname = dotnetRepoClassName,
                    entity= dotnetRepoEntityname,
                    response= dotnetResponseCheckbox.Checked
                });

                string pathString;
                string folderDir = @"" + file.Path;
                string fileName = file.Name;
                pathString = Path.Combine(folderDir, fileName);
                pathString = Path.ChangeExtension(pathString, "cs");

                if (!File.Exists(pathString))
                {

                    using (FileStream fs = File.Create(pathString))
                    {
                        logsField.Text = logsField.Text + pathString + "                     ";
                    }
                    WriteToFiles(pathString, result.ToString());
                }
                else
                {
                    File.Delete(@"" + pathString);
                    using (FileStream fs = File.Create(pathString))
                    {
                        logsField.Text = logsField.Text + pathString + "                    ";
                    }
                    WriteToFiles(pathString, result.ToString());

                }
            }
            if (dotnetRepoShowInstructionCheckbox.Checked = true)
            {
                MessageBox.Show("Please follow the instruction","Instructions");
            }
        }
        private void WriteToFiles(string path,string content)
        {
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(content);
            }
        }
        private string ConfigureRepoGeneratedFiles(FileNames file)
        {
            if (file.Name == $"I{repoDomainNameField.Text}Query")
            {
                dotnetRepoNamespace = "Application.Contracts.RepositoryManager.Query";
                dotnetRepoClassType = "interface";
                dotnetRepoClassName = $"I{repoDomainNameField.Text}Query";
                dotnetRepoInherits = $": IBaseQuery<{repoDomainNameField.Text}>";
                dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");

                return dotnetRepoTemplateText;
            }
            if (file.Name == $"I{repoDomainNameField.Text}Command")
            {
                dotnetRepoNamespace = "Application.Contracts.RepositoryManager.Command";
                dotnetRepoClassType = "interface";
                dotnetRepoClassName = $"I{repoDomainNameField.Text}Command";
                dotnetRepoInherits = $": IBaseCommand<{repoDomainNameField.Text}>";
                dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                return dotnetRepoTemplateText;
            }
            if (file.Name == repoDomainNameField.Text)
            {
                dotnetRepoNamespace = "Domain.Entitites";
                dotnetRepoClassType = "class";
                dotnetRepoClassName=repoDomainNameField.Text;
                dotnetRepoInherits = null;
                dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                return dotnetRepoTemplateText;
            }
            if (file.Name == $"{repoDomainNameField.Text}Command")
            {
                dotnetRepoNamespace = "Infrastructure.RepositoryManager.Command";
                dotnetRepoClassType = "class";
                dotnetRepoClassName = $"{repoDomainNameField.Text}Command";
                dotnetRepoInherits = $": BaseCommand<{repoDomainNameField.Text}>, I{repoDomainNameField.Text}Command";
                dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                return dotnetRepoTemplateText;
            }
            if (file.Name == $"{repoDomainNameField.Text}Query")
            {
                dotnetRepoNamespace = "Infrastructure.RepositoryManager.Query";
                dotnetRepoClassType = "class";
                dotnetRepoClassName = $"{repoDomainNameField.Text}Query";
                dotnetRepoInherits = $": BaseQuery<{repoDomainNameField.Text}>, I{repoDomainNameField.Text}Query";
                dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                return dotnetRepoTemplateText;
            }
            if (file.Name == $"{repoDomainNameField.Text}Configuration")
            {
                dotnetRepoNamespace = "Infrastructure.DatabaseManager.Configurations.Entities";
                dotnetRepoClassType = "class";
                dotnetRepoClassName = $"{repoDomainNameField.Text}Configuration";
                dotnetRepoInherits = $": IEntityTypeConfiguration<{repoDomainNameField.Text}>";
                dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                return dotnetRepoTemplateText;
            }
            if (file.Name == $"{repoDomainNameField.Text}Manager")
            {
                dotnetRepoNamespace = "Presantation.Managers";
                dotnetRepoClassType = " static class";
                dotnetRepoClassName = $"{repoDomainNameField.Text}Manager";
                dotnetRepoInherits = null;
                dotnetRepoEntityname = repoDomainNameField.Text;
                if (dotnetResponseCheckbox.Checked)
                {
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/ManagerWRTemplate.txt");
                }
                if (!dotnetResponseCheckbox.Checked)
                {
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/ManagerTemplate.txt");

                }
                return dotnetRepoTemplateText;
            }
            if (file.Name == $"{repoDomainNameField.Text}Controller")
            {
                dotnetRepoNamespace = "Presantation.Controllers";
                dotnetRepoClassType = "class";
                dotnetRepoClassName = $"{repoDomainNameField.Text}Controller";
                dotnetRepoInherits = $": BaseController<{repoDomainNameField.Text}>";
                dotnetRepoEntityname=repoDomainNameField.Text;
                if (dotnetResponseCheckbox.Checked)
                {
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/ControllerWRTemplate.txt");
                }
                if (!dotnetResponseCheckbox.Checked)
                {
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/ControllerTemplate.txt");
                }
                return dotnetRepoTemplateText;
            }

            if (dotnetResponseCheckbox.Checked)
            {
                if(file.Name == $"I{repoDomainNameField.Text}Response")
                {
                    dotnetRepoNamespace = "Application.Contracts.Response";
                    dotnetRepoClassType = "interface";
                    dotnetRepoClassName = $"I{repoDomainNameField.Text}Response";
                    dotnetRepoInherits = $": IBaseResponse<object,object>";
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                    return dotnetRepoTemplateText;
                }
                if (file.Name == $"{repoDomainNameField.Text}ModelStateFilter")
                {
                    dotnetRepoNamespace = "Application.Exceptions.ValidationResponseFilters";
                    dotnetRepoClassType = "class";
                    dotnetRepoClassName = $"{repoDomainNameField.Text}ModelStateFilter";
                    dotnetRepoInherits = null;
                    dotnetRepoEntityname = repoDomainNameField.Text;
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/ModelStateTemplate.txt");
                    return dotnetRepoTemplateText;
                }
                if (file.Name == $"{repoDomainNameField.Text}Response")
                {
                    dotnetRepoNamespace = "Application.Configurations.Response";
                    dotnetRepoClassType = "class";
                    dotnetRepoClassName = $"{repoDomainNameField.Text}Response";
                    dotnetRepoInherits = $": BaseResponse<object, object>, I{repoDomainNameField.Text}Response";
                    dotnetRepoTemplateText = File.ReadAllText($"{templatePath}/DotNetRepo/BaseTemplate.txt");
                    return dotnetRepoTemplateText;
                }
            }
            return null;
        }
        #endregion
    }
}
