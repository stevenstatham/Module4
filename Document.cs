using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			string name;
			string fileName;
			string fileContent;
			string txtCatch = "";
			int count;
			string tryAgain = "yes";
			StreamWriter thisFile = null;
			Exception failure = null;

			while (tryAgain == "yes")
			{
				Console.WriteLine("Document");
				Console.WriteLine("What would you like to name this file?");
				name = Console.ReadLine();

				for (int counter = 1; counter <= 4; counter++)
				{
					txtCatch = txtCatch + name[name.Length - counter];
				}
				if (txtCatch == "txt.")
				{
					fileName = name;
				}
				else
				{
					fileName = name + ".txt";
				}

				Console.WriteLine("What would you like to include in the text file? Press ENTER when done.");
				fileContent = Console.ReadLine();
				count = fileContent.Length;

				try
				{
					thisFile = File.CreateText(fileName);
					thisFile.WriteLine(fileContent);
				}
				catch (IOException e)
				{
					failure = e;
					Console.WriteLine("{0}", failure);
					Console.WriteLine("type 'yes' in lowercase letters if you would like to try again.");
					tryAgain = Console.ReadLine();
				}
				finally
				{
					if (thisFile != null)
					{
						thisFile.Close();
						if (failure == null)
						{
							Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", fileName, count);
							tryAgain = "no";
							Console.ReadLine();
						}
						failure = null;
					}
				}
			}
		}
	}
}
