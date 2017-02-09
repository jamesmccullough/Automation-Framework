﻿using AutomationFramework_example_v1.Framework.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework_example_v1.Framework.TableMappings
{
    class ProjectInfo : TableMap
    {
        [ColumnMap("Project Name")]
        public string Name;
        [ColumnMap("Project Url")]
        public string Url;

        public ProjectInfo Populate(string projectName)
        {
            Command cmd = new Command("getProjectInformation");
            cmd.AddParameter("projectName", projectName);
            ProjectInfo result = this.ExecuteStoredProcedure(cmd)[0];
            cmd.Dispose();
            return result;

        }
    }
}
