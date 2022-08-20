using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_generator
{
    internal class FileNames
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public bool IsStatic { get; set; }
        public List<string> Usings { get; set; }
        public string Inherits { get; set; }
        public string Namespace { get; set; }
        public string Constructor { get; set; }
    }
}
