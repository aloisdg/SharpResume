using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpResume;
using SharpResume.Model;

namespace SharpResumeSample
{
	class Program
	{
		static void Main()
		{
			const string jsonName = "resume.json";
			var directoryPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
			var json = File.ReadAllText(Path.Combine(directoryPath, jsonName));
			var resume = Resume.Create(json);

			Console.WriteLine("Hello {0}!", resume.Basics.Name);
			Console.ReadLine();
		}
	}
}
