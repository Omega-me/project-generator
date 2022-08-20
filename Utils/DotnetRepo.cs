using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_generator.Utils
{
    internal static class DotnetRepo
    {
        public static List<FileNames> RepoTemplateConfig(string folderPath,string folderName,string repoDomainNameField,bool dotnetResponseCheckbox)
        {
            List<FileNames> files = new List<FileNames>
            {
                new FileNames{
                    Name = repoDomainNameField,
                    Path = $"{folderPath}\\{folderName}.Domain\\Entitites",
                    Type = "class",
                    Usings=new List<string>(),
                    Inherits=null,
                    Namespace=$"{folderName}.Domain.Entitites;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"I{repoDomainNameField}Query",
                    Path = $"{folderPath}\\{folderName}.Application\\Contracts\\RepositoryManager\\Query",
                    Usings=new List<string>{
                        $"using {folderName}.Domain.Entitites;",
                    },
                    Type = "interface",
                    Inherits=$": IBaseQuery<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"I{repoDomainNameField}Command",
                    Path = $"{folderPath}\\{folderName}.Application\\Contracts\\RepositoryManager\\Command",
                    Usings=new List<string>{
                        $"using {folderName}.Domain.Entitites;",
                    },
                    Type = "interface",
                    Inherits=$": IBaseCommand<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Query",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\RepositoryManager\\Query",
                    Usings=new List<string>{
                        $"using {folderName}.Application.Contracts.RepositoryManager.Query;",
                        $"using {folderName}.Domain.Entitites;",
                        $"using {folderName}.Infrastructure.DatabaseManager.Context;"
                    },
                    Type = "class",
                    Inherits=$": BaseQuery<{repoDomainNameField}>, I{repoDomainNameField}Query",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Query;",
                    Constructor=$"public {repoDomainNameField}Query(DatabaseContext context) : base(context)" +
                                 "{ }"
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Command",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\RepositoryManager\\Command",
                    Usings=new List<string>{
                        $"using {folderName}.Application.Contracts.RepositoryManager.Command;",
                        $"using {folderName}.Domain.Entitites;",
                        $"using {folderName}.Infrastructure.DatabaseManager.Context;"
                    },
                    Type = "class",
                    Inherits=$": BaseCommand<{repoDomainNameField}>, I{repoDomainNameField}Command",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Command;",
                    Constructor=$"public {repoDomainNameField}Command(DatabaseContext context) : base(context)" +
                                 "{ }"
                },
                new FileNames{
                    Name = "IQuery",
                    Path = $"{folderPath}\\{folderName}.Application\\Contracts\\RepositoryManager\\Query",
                    Type = "interface",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits=null,
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = "ICommands",
                    Path = $"{folderPath}\\{folderName}.Application\\Contracts\\RepositoryManager\\Command",
                    Type = "interface",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits=null,
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = "Query",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\RepositoryManager\\Query",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="IQuery",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = "Commands",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\RepositoryManager\\Command",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="ICommands",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = "DatabaseContext",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\DatabaseManager\\Context",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="DbContext",
                    Namespace=$"{folderName}.Infrastructure.DatabaseManager.Context;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Configuration",
                    Path = $"{folderPath}\\{folderName}.Infrastructure\\DatabaseManager\\Configurations\\Entities",
                    Usings=new List<string>{
                        $"using {folderName}.Domain.Entitites;",
                        "using Microsoft.EntityFrameworkCore;",
                        "using Microsoft.EntityFrameworkCore.Metadata.Builders;"
                    },
                    Type = "class",
                    Inherits=$": IEntityTypeConfiguration<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Infrastructure.DatabaseManager.Configurations.Entities;",
                    Constructor=$"public void Configure(EntityTypeBuilder<{repoDomainNameField}> builder)" + "{}"
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Manager",
                    Path = $"{folderPath}\\{folderName}.Presantation\\Managers",
                    Type = "class",
                    Usings=new List<string>{
                        "using AutoMapper;",
                        $"using {folderName}.Application.Configurations.Response;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Command;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Query;",
                        $"using {folderName}.Domain.Entitites;",
                        "using Microsoft.AspNetCore.JsonPatch;",
                    },
                    IsStatic=true,
                    Inherits=null,
                    Namespace=$"{folderName}.Presantation.Managers;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Controller",
                    Path = $"{folderPath}\\{folderName}.Presantation\\Controllers",
                    Type = "class",
                    Usings=new List<string>{
                        "using AutoMapper;",
                        "using Microsoft.AspNetCore.JsonPatch;",
                        "using Microsoft.AspNetCore.Mvc;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Command;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Query;",
                        $"using {folderName}.Application.DTO.Country;",
                        $"using {folderName}.Application.Exceptions.ValidationResponseFilters;",
                        $"using {folderName}.Domain.Entitites;",
                        $"using {folderName}.Presantation.Managers;",
                        "using Microsoft.AspNetCore.JsonPatch;",
                    },
                    Inherits=$": BaseController<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Presantation.Controllers;",
                    Constructor=null
                },
            };
            if (dotnetResponseCheckbox)
            {
                files.Add(
                    new FileNames
                    {
                        Name = $"{repoDomainNameField}ModelStateFilter",
                        Path = $"{folderPath}\\{folderName}.Application\\Exceptions\\ValidationResponseFilters",
                        Type = "class",
                        Usings = new List<string> {
                            $"using {folderName}.Application.Configurations.Response;",
                            "using Microsoft.AspNetCore.Http;",
                            "using Microsoft.AspNetCore.Mvc;",
                            "using Microsoft.AspNetCore.Mvc.Filters;"
                        },
                        Inherits = ": ResultFilterAttribute",
                        Namespace = $"{folderName}.Application.Exceptions.ValidationResponseFilters;",
                        Constructor = null
                    }
                );
                files.Add(
                    new FileNames
                    {
                        Name = $"I{repoDomainNameField}Response",
                        Path = $"{folderPath}\\{folderName}.Application\\Contracts\\Response",
                        Type = "interface",
                        Usings = new List<string>(),
                        Inherits = $": IBaseResponse<object,object>",
                        Namespace = $"{folderName}.Application.Contracts.Response;",
                        Constructor = null
                    }
                );
                files.Add(
                     new FileNames
                     {
                         Name = $"{repoDomainNameField}Response",
                         Path = $"{folderPath}\\{folderName}.Application\\Configurations\\Response",
                         Type = "class",
                         Usings = new List<string> {
                            $"using {folderName}.Application.Contracts.Response;",
                         },
                         Inherits = $": BaseResponse<object, object>, I{repoDomainNameField}Response",
                         Namespace = $"{folderName}.Application.Configurations.Response;",
                         Constructor = null
                     }
                );
            }
            return files;
        }
        public static List<string> GetEntities(string folderPath,string folderName)
        {
            DirectoryInfo d = new DirectoryInfo(@"" + $"{folderPath}\\{folderName}.Domain\\Entitites");
            FileInfo[] Files = d.GetFiles("*.cs");
            List<string> entities = new List<string>();

            foreach (FileInfo file2 in Files)
            {
                entities.Add(file2.Name.Split(".")[0]);
            }

            return entities;
        }

        public static void WriteToFiles(string path, string content)
        {
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(content);
            }
        }
    }
}
