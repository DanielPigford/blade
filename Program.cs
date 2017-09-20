using System;

namespace blade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blade version 1.1.");
            Console.WriteLine("  Usage: blade {config.json}");

            Console.WriteLine("Reading configuration file. [config.json]");
            BladeConfig conf = new BladeConfig();
            conf.LoadConfig(args); 
            //Read from config...per configuration section
            //  List of tables
            //  List of views
            //  List of procedures
            //  List of templates
            //  Output directory

            Console.WriteLine("Reading database schema and building meta data JSON.");
            //  Read and build meta-data.json for the list of tables, views, procedures in the configuration section

            Console.WriteLine("Generating source code from Handlebar templates and database schema.");
            //  Using list of tables, views, procedures for the template configuration section execute the hbs template for each one

            Console.WriteLine("Publishing source code files.");
            //  Search and process any file break markers to publish final files

            Console.WriteLine("All done.  Have a great day and thanks for using Blade.");
        }
    }
}
