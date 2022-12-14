using Project_generator.Utils;
using Scriban;

namespace Project_generator
{
    public partial class FileGenerator : Form
    {
        private string folderName;
        private string folderPath;
        private string templatePath;

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
            // development path
            templatePath = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\Templates";
            //production path
            //templatePath= Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Templates";
            // migration tool
            //dotnet - ef migrations add initial_migration - p Hotel_listing.Persistence - s Hotel_listing.API
        }

        #region .NET
        #region REPO
        private void dotnetRepoSolutionSetPathBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = selectSlnPathDialog.ShowDialog();
            if (dialogResult == DialogResult.OK && !string.IsNullOrEmpty(selectSlnPathDialog.FileName))
            {
                dotnetRepoSolutionPathField.Text = selectSlnPathDialog.FileName;
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
        private async void dotnetGenerateRepoBtn_Click(object sender, EventArgs e)
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

            string entityPath;
            string entityDir = $@"{folderPath}\{folderName}.Domain\Entitites";
            string entityFilename = repoDomainNameField.Text;
            entityPath = Path.Combine(entityDir, entityFilename);
            entityPath = Path.ChangeExtension(entityPath, "cs");
            if (!File.Exists(entityPath))
            {
                logsField.Text = entityPath;
                FileStream fs = File.Create(entityPath);
                fs.Close();
            }

            List<FileNames> files = DotnetRepo.RepoTemplateConfig(
                folderPath,
                folderName,
                repoDomainNameField.Text,
                dotnetResponseCheckbox.Checked);



            foreach (FileNames file in files)
            {
                string templateText = "";
                if (file.Name == $"{repoDomainNameField.Text}Controller")
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/Controller.txt");
                }
                else if (file.Name == $"{repoDomainNameField.Text}Manager")
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/Manager.txt");
                }
                else if (file.Name == $"{repoDomainNameField.Text}ModelStateFilter")
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/ModelState.txt");
                }
                else if (file.Name == "IQuery" || file.Name == "ICommands" || file.Name == "Query" || file.Name == "Commands")
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/cqrs.txt");
                }
                else if (file.Name == "DatabaseContext")
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/DbContext.txt");
                }
                else if (file.Name == "MapperConfig")
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/Mapper.txt");
                }
                else
                {
                    templateText = File.ReadAllText($"{templatePath}/DotNetRepo/Template.txt");
                }

                var template = Template.Parse(templateText);
                var result = template.Render(new
                {
                    name = file.Name,
                    usings = file.Usings,
                    namespacetext = file.Namespace,
                    isstatic = file.IsStatic,
                    type = file.Type,
                    inherits = file.Inherits,
                    constructor = file.Constructor,
                    entity = repoDomainNameField.Text,
                    entitylowercase = repoDomainNameField.Text.ToLower(),
                    customresponse = dotnetResponseCheckbox.Checked,
                    folder = folderName
                });

                string pathString;
                string folderDir = $@"{file.Path}";
                string fileName = file.Name;
                pathString = Path.Combine(folderDir, fileName);
                pathString = Path.ChangeExtension(pathString, "cs");

                if (!File.Exists(pathString))
                {

                    using (FileStream fs = File.Create(pathString))
                    {
                        logsField.Text = logsField.Text + pathString + "                     ";
                        fs.Close();
                    }
                    DotnetRepo.WriteToFiles(pathString, result.ToString());
                }
                else
                {
                    File.Delete($@"{pathString}");
                    using (FileStream fs = File.Create(pathString))
                    {
                        logsField.Text = logsField.Text + pathString + "                    ";
                        fs.Close();
                    }
                    DotnetRepo.WriteToFiles(pathString, result.ToString());
                }
            }
            if (dotnetRepoShowInstructionCheckbox.Checked = true)
            {
                MessageBox.Show("Please follow the instruction", "Instructions");
            }
        }
        private void RepoRemoveLastBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dotnetRepoSolutionPathField.Text))
            {
                MessageBox.Show("Please specify the project solution path", "Inavlid solution path");
                return;
            }
            if (string.IsNullOrEmpty(repoDomainNameField.Text))
            {
                MessageBox.Show("Please specify Entity name you want to remove", "Inavlid entity name");
                return;
            }

            string entityPath;
            string entityDir = $@"{folderPath}\\{folderName}.Domain\\Entitites";
            string entityFilename = repoDomainNameField.Text;
            entityPath = Path.Combine(entityDir, entityFilename);
            entityPath = Path.ChangeExtension(entityPath, "cs");
            if (!File.Exists(entityPath))
            {
                MessageBox.Show("No entity exists with the specified name", "Inavlid entity name");
                return;
            }
            else
            {
                File.Delete($@"{entityPath}");
            }

            List<FileNames> files = DotnetRepo.RepoTemplateConfig(folderPath,
                                                                  folderName,
                                                                  repoDomainNameField.Text,
                                                                  dotnetResponseCheckbox.Checked);

            foreach (FileNames file in files)
            {
                string pathString;
                string folderDir = $@"{file.Path}";
                string fileName = file.Name;
                pathString = Path.Combine(folderDir, fileName);
                pathString = Path.ChangeExtension(pathString, "cs");
                File.Delete($@"{pathString}");
            }

            List<FileNames> fileNames = DotnetRepo.RepoTemplateConfigRegenerate(
                folderPath,
                folderName);

            if (!File.Exists(entityPath))
            {
                foreach (FileNames file in fileNames)
                {
                    string templateText = "";
                    if (file.Name == "IQuery" || file.Name == "ICommands" || file.Name == "Query" || file.Name == "Commands")
                    {
                        templateText = File.ReadAllText($"{templatePath}/DotNetRepo/cqrs.txt");
                    }
                    else if (file.Name == "DatabaseContext")
                    {
                        templateText = File.ReadAllText($"{templatePath}/DotNetRepo/DbContext.txt");
                    }
                    else if (file.Name == "MapperConfig")
                    {
                        templateText = File.ReadAllText($"{templatePath}/DotNetRepo/Mapper.txt");
                    }
                    else
                    {
                        string path;
                        string folDir = $@"{file.Path}";
                        string name = file.Name;
                        path = Path.Combine(folDir, name);
                        path = Path.ChangeExtension(path, "cs");
                        File.Delete($@"{path}");
                    }

                    var template = Template.Parse(templateText);
                    var result = template.Render(new
                    {
                        name = file.Name,
                        usings = file.Usings,
                        namespacetext = file.Namespace,
                        isstatic = file.IsStatic,
                        type = file.Type,
                        inherits = file.Inherits,
                        constructor = file.Constructor,
                        entity = repoDomainNameField.Text,
                        entitylowercase = repoDomainNameField.Text.ToLower(),
                        customresponse = dotnetResponseCheckbox.Checked,
                        folder = folderName
                    });

                    string pathString;
                    string folderDir = $@"{file.Path}";
                    string fileName = file.Name;
                    pathString = Path.Combine(folderDir, fileName);
                    pathString = Path.ChangeExtension(pathString, "cs");

                    if (!File.Exists(pathString))
                    {

                        using (FileStream fs = File.Create(pathString))
                        {
                            logsField.Text = logsField.Text + pathString + "                     ";
                            fs.Close();
                        }
                        DotnetRepo.WriteToFiles(pathString, result.ToString());
                    }
                    else
                    {
                        File.Delete($@"{pathString}");
                        using (FileStream fs = File.Create(pathString))
                        {
                            logsField.Text = logsField.Text + pathString + "                    ";
                            fs.Close();
                        }
                        DotnetRepo.WriteToFiles(pathString, result.ToString());
                    }
                }
            }

            if (dotnetRepoShowInstructionCheckbox.Checked = true)
            {
                MessageBox.Show("Please follow the instruction", "Instructions");
            }
        }
        #endregion

        #endregion
    }
}
