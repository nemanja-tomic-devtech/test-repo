using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VersionTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
			string version = fileVersionInfo.ProductVersion;
			Console.WriteLine("Informational version: {0}", version);

			Console.ReadKey();
		}
	}
}
