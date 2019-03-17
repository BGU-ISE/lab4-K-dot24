using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

namespace Lab4
{

    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static Hashtable dataTable = new Hashtable();
        

        static void Main(string[] args)
        {
            ImplementLoggingFuntion();
            dataTable.Add("Raz", "170694");
            dataTable.Add("Raviv", "Haviv");
            dataTable.Add("TheKiller", "1234567");
            dataTable.Add("Bibi", "ILoveMoney");
        }

        private static Boolean checkLogin()
        {
            Boolean valid = false;
            int i = 0;
            while (!valid & i < 3)
            {
                Console.WriteLine("Enter username por favor:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password por favor:");
                string password = Console.ReadLine();
                if (username.Equals("Shoshi") & password.Equals("rak_bibi"))
                {
                    valid = true;
                    Console.WriteLine("Login successful!");
                }
                else
                    Console.WriteLine("Wrong username and/or password!");
                i++;
            }
            return valid;
        }

        private static void ImplementLoggingFuntion()
        {
            /* We have 5 levels of log message. Let's test all.
             *  FATAL
                ERROR
                WARN
                INFO
                DEBUG
             */
            var secs = 3;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
