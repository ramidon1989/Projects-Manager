using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects_Manager.Model;

namespace Projects_Manager.Controller
{
    public static class ProjectManager
    {
        static ProjectsCollection Projects;

        static ProjectManager()
        {
            Projects = new ProjectsCollection();
        }

        public static void Remove(int i)
        {
            Projects.Remove(Projects[i]);
        }
        public static void Remove(Project item)
        {
            Projects.Remove(item);
        }


    }
}
