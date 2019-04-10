using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Manager.Model
{
    public class Project
    {
        public string Name { get; set; }

        public Icon Icon { get; set; }

        public string Path { get; set; }

        public Project(string name)
        {
            Name = name;
        }
    }
}
