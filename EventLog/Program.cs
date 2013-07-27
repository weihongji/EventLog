using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLog
{
	class Program
	{
		static void Main(string[] args) {
			var logName = "MyNewLog";
			if (args != null && args.Length > 0) {
				logName = args[0];
			}
			if (System.Diagnostics.EventLog.Exists(logName)) {
				System.Diagnostics.EventLog.Delete(logName);
				Console.WriteLine(string.Format("Done.{0}Press any key to exit ...", Environment.NewLine));
			}
			else {
				Console.WriteLine(string.Format("{0} is not found.{1}Press any key to exit ...", logName, Environment.NewLine));
			}
			Console.ReadKey();
		}
	}
}
