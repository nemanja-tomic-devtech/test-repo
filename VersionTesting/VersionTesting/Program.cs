using System;
using System.Diagnostics;
using System.Reflection;

namespace VersionTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			Assembly assembly = Assembly.GetExecutingAssembly();
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
			string version = fileVersionInfo.ProductVersion;
			Console.WriteLine("Hello Dear");
			Console.WriteLine("Hello Dear");
			Console.WriteLine("Informational version: {0}", version);

			Console.ReadKey();
		}
	}
}
