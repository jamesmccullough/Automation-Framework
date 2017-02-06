﻿

using AutomationFramework_example_v1.Framework.SQL;
using System.Data;

namespace AutomationFramework_example_v1
{
    class Program
    {
        /// <summary>
        /// The default connection string name from the App config.
        /// </summary>
       // public const string DefaultConnectionStringName = "Tony'sLocalConnection";
        public const string DefaultConnectionStringName = "James'LocalConnection";

        static void Main(string[] args)
        {
            Command cmd = new Command("getSuiteInformation");
            DataSet ds = DAO.ExecuteStoredProcedure(cmd);
            
            //MyFirstTest.Main1();
            //may be able to pass in the path for the test suite inventory to drive the current instance of the framework
            //use args to set up framework properties like debugging and show console ect.

            //call the appropriate controller method, this may also be controled by argument
            new Controller("my//automation//test//suite.xlsx");


            //the command line command structure to call the framework would need to be well documented
        }
    }
}
