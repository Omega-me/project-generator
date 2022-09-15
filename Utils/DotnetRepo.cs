using CliWrap;
using CliWrap.Buffered;

namespace Project_generator.Utils
{
    internal static class DotnetRepo
    {
        public static List<FileNames> RepoTemplateConfig(string folderPath,string folderName,string repoDomainNameField,bool dotnetResponseCheckbox)
        {
            List<FileNames> files = new List<FileNames>
            {
                new FileNames{
                    Name = repoDomainNameField, //Doamin
                    Path = @$"{folderPath}\{folderName}.Domain\Entitites",
                    Type = "class",
                    Usings=new List<string>(),
                    Inherits= ": BaseEntity",
                    Namespace=$"{folderName}.Domain.Entitites;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"I{repoDomainNameField}Query", //IDomainQuery
                    Path = @$"{folderPath}\{folderName}.Application\Contracts\RepositoryManager\Query",
                    Usings=new List<string>{
                        $"using {folderName}.Domain.Entitites;",
                    },
                    Type = "interface",
                    Inherits=$": IBaseQuery<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"I{repoDomainNameField}Command", //IDomainCommand
                    Path = @$"{folderPath}\{folderName}.Application\Contracts\RepositoryManager\Command",
                    Usings=new List<string>{
                        $"using {folderName}.Domain.Entitites;",
                    },
                    Type = "interface",
                    Inherits=$": IBaseCommand<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Query", //DomainQuery
                    Path = @$"{folderPath}\{folderName}.Infrastructure\RepositoryManager\Query",
                    Usings=new List<string>{
                        $"using {folderName}.Application.Contracts.RepositoryManager.Query;",
                        $"using {folderName}.Domain.Entitites;",
                        $"using {folderName}.Persistence;"
                    },
                    Type = "class",
                    Inherits=$": BaseQuery<{repoDomainNameField}>, I{repoDomainNameField}Query",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Query;",
                    Constructor=$"public {repoDomainNameField}Query(DatabaseContext context) : base(context)" +
                                 "{ }"
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Command", //DomainCommand
                    Path = @$"{folderPath}\{folderName}.Infrastructure\RepositoryManager\Command",
                    Usings=new List<string>{
                        $"using {folderName}.Application.Contracts.RepositoryManager.Command;",
                        $"using {folderName}.Domain.Entitites;",
                        $"using {folderName}.Persistence;"
                    },
                    Type = "class",
                    Inherits=$": BaseCommand<{repoDomainNameField}>, I{repoDomainNameField}Command",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Command;",
                    Constructor=$"public {repoDomainNameField}Command(DatabaseContext context) : base(context)" +
                                 "{ }"
                },
                new FileNames{
                    Name = "IQuery", //IQuery
                    Path = @$"{folderPath}\{folderName}.Application\Contracts\RepositoryManager\Query",
                    Type = "interface",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits=null,
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = "ICommands", //ICommands
                    Path = @$"{folderPath}\{folderName}.Application\Contracts\RepositoryManager\Command",
                    Type = "interface",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits=null,
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = "Query", //Query
                    Path = @$"{folderPath}\{folderName}.Infrastructure\RepositoryManager\Query",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="IQuery",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = "Commands", //Commands
                    Path = @$"{folderPath}\{folderName}.Infrastructure\RepositoryManager\Command",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="ICommands",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = "DatabaseContext", //DatabaseContext
                    Path = @$"{folderPath}\{folderName}.Persistence",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="DbContext",
                    Namespace=$"{folderName}.Persistence;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Configuration", //DomainConfiguration
                    Path = @$"{folderPath}\{folderName}.Persistence\Configurations\Entities",
                    Usings=new List<string>{
                        $"using {folderName}.Domain.Entitites;",
                        "using Microsoft.EntityFrameworkCore;",
                        "using Microsoft.EntityFrameworkCore.Metadata.Builders;"
                    },
                    Type = "class",
                    Inherits=$": IEntityTypeConfiguration<{repoDomainNameField}>",
                    Namespace=$"{folderName}.Persistence.Configurations.Entities;",
                    Constructor=$"public void Configure(EntityTypeBuilder<{repoDomainNameField}> builder)" + "{}"
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Manager", //DoaminManager
                    Path = @$"{folderPath}\{folderName}.API\Managers",
                    Type = "class",
                    Usings=new List<string>{
                        "using AutoMapper;",
                        $"using {folderName}.Application.Common.RepositoryOptions;",
                        $"using {folderName}.Application.Common.Response;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Command;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Query;",
                        $"using {folderName}.Domain.Entitites;",
                        "using Microsoft.AspNetCore.JsonPatch;",
                    },
                    IsStatic=true,
                    Inherits=null,
                    Namespace=$"{folderName}.API.Managers;",
                    Constructor=null
                },
                new FileNames{
                    Name = $"{repoDomainNameField}Controller", //DomainController
                    Path = @$"{folderPath}\{folderName}.API\Controllers",
                    Type = "class",
                    Usings=new List<string>{
                        "using Microsoft.AspNetCore.JsonPatch;",
                        "using Microsoft.AspNetCore.Mvc;",
                        "using Swashbuckle.AspNetCore.Annotations;",
                        "using AutoMapper;",
                        $"using {folderName}.API.Common;",
                        $"using {folderName}.API.Managers;",
                        $"using {folderName}.Application.Common.RepositoryOptions;",
                        $"using {folderName}.Application.Common.Response;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Command;",
                        $"using {folderName}.Application.Contracts.RepositoryManager.Query;",
                        $"using {folderName}.Application.Exceptions.ValidationResponseFilters;",
                        $"using {folderName}.Domain.Entitites;",
                    },
                    Inherits=$": BaseController<{repoDomainNameField}>",
                    Namespace=$"{folderName}.API.Controllers;",
                    Constructor=null
                },
                new FileNames{
                    Name = "MapperConfig", //MapperConfig
                    Path = @$"{folderPath}\{folderName}.Application\Common",
                    Usings = GetEntities(folderPath,folderName),
                    Type = null,
                    Inherits = null,
                    Namespace = $"{folderName}.Application.Common;",
                    Constructor = null
                },
            };
            if (dotnetResponseCheckbox)
            {
                files.Add(
                    new FileNames
                    {
                        Name = $"{repoDomainNameField}ModelStateFilter", //DomainModelStateFilter
                        Path = @$"{folderPath}\{folderName}.Application\Exceptions\ValidationResponseFilters",
                        Type = "class",
                        Usings = new List<string> {
                            $"using {folderName}.Application.Common.Response;",
                            $"using {folderName}.Application.Domain.Entitites;",
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
                        Name = $"I{repoDomainNameField}Response<TData>",//IDomainResponse
                        Path = @$"{folderPath}\{folderName}.Application\Contracts\Response",
                        Type = "interface",
                        Usings = new List<string>(),
                        Inherits = $": IBaseResponse<TData,List<BaseError>>",
                        Namespace = $"{folderName}.Application.Contracts.Response;",
                        Constructor = null
                    }
                );
                files.Add(
                     new FileNames
                     {
                         Name = $"{repoDomainNameField}Response<TData>", //DomainResponse
                         Path = @$"{folderPath}\{folderName}.Application\Common\Response",
                         Type = "class",
                         Usings = new List<string> {
                            $"using {folderName}.Application.Contracts.Response;",
                         },
                         Inherits = $": BaseResponse<TData,List<BaseError>>, I{repoDomainNameField}Response<TData>",
                         Namespace = $"{folderName}.Application.Common.Response;",
                         Constructor = null
                     }
                );
            }
            return files;
        }
        public static List<FileNames> RepoTemplateConfigRegenerate(string folderPath,string folderName)
        {
            List<FileNames> files = new List<FileNames>
            {
                new FileNames{
                    Name = "IQuery",
                    Path = @$"{folderPath}\{folderName}.Application\Contracts\RepositoryManager\Query",
                    Type = "interface",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits=null,
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = "ICommands",
                    Path = @$"{folderPath}\{folderName}.Application\Contracts\RepositoryManager\Command",
                    Type = "interface",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits=null,
                    Namespace=$"{folderName}.Application.Contracts.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = "Query",
                    Path = @$"{folderPath}\{folderName}.Infrastructure\RepositoryManager\Query",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="IQuery",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Query;",
                    Constructor=null
                },
                new FileNames{
                    Name = "Commands",
                    Path = @$"{folderPath}\{folderName}.Infrastructure\RepositoryManager\Command",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="ICommands",
                    Namespace=$"{folderName}.Infrastructure.RepositoryManager.Command;",
                    Constructor=null
                },
                new FileNames{
                    Name = "DatabaseContext",
                    Path = @$"{folderPath}\{folderName}.Persistence",
                    Type = "class",
                    Usings= GetEntities(folderPath,folderName),
                    Inherits="DbContext",
                    Namespace=$"{folderName}.Persistence;",
                    Constructor=null
                },
                new FileNames{
                    Name = "MapperConfig",
                    Path = @$"{folderPath}\{folderName}.Application\Common",
                    Usings = GetEntities(folderPath,folderName),
                    Type = null,
                    Inherits = null,
                    Namespace = $"{folderName}.Application.Common;",
                    Constructor = null
                },
            };
            return files;
        }
        public static List<string> GetEntities(string folderPath,string folderName)
        {
            DirectoryInfo d = new DirectoryInfo($@"{folderPath}\{folderName}.Domain\Entitites");
            FileInfo[] Files = d.GetFiles("*.cs");
            List<string> entities = new List<string>();

            foreach (FileInfo file in Files)
            {
                entities.Add(file.Name.Split(".")[0]);
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
