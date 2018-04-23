using EdmGen06.Properties;
using System;
using System.Diagnostics;

namespace EdmGen06 {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 5 && args[0] == "/ModelGen") {
                new EdmGenModelGen().ModelGen(
                    args[1],
                    args[2],
                    args[3],
                    args[4],
                    (args.Length > 5) ? new Version(args[5]) : new Version("3.0")
                    );
                return;
            }
            if (args.Length >= 7 && args[0] == "/EFModelGen")
            {
                new EdmGenModelGen().ModelGen2(
                    args[1], //connection
                    args[2], //provider
                    args[3], //type provider services
                    args[4], //csdl model name
                    args[5], //target schema (ssdl model)                   
                    (args.Length > 7) ? new Version(args[7]) : new Version("3.0"),
                    args[6] //edmx name
                );
                return;
            }
            if (args.Length >= 6 && args[0] == "/EFModelGen") {
                new EdmGenModelGen().ModelGen2(
                    args[1], //connection
                    args[2], //provider
                    args[3], //type provider services
                    args[4], //model name
                    args[5], //target schema
                    (args.Length > 6) ? new Version(args[6]) : new Version("3.0")
                    );
                return;
            }
            else if (args.Length >= 5 && args[0] == "/DataSet") {
                new EdmGenDataSet().DataSet(
                    args[1],
                    args[2],
                    args[3],
                    args[4]
                    );
                return;
            }
            else if (args.Length >= 3 && args[0] == "/DataSet.cs") {
                new EdmGenDataSet().DataSet_cs(
                    args[1],
                    args[2]
                    );
                return;
            }
            else if (args.Length >= 4 && args[0] == "/EFCodeFirstGen") {
                new EdmGenClassGen().CodeFirstGen(
                    args[1],
                    args[2],
                    args[3],
                    "Host=xxx;Port=xxx;Username=xxx;Password=xxx;Database=xxx;"
                    );
                return;
            }
            Console.Error.WriteLine(Resources.Usage);
            Environment.ExitCode = 1;
        }

    }
}
