using System;
using System.IO;


namespace Shapes.Reader.File.Utilities
{
	public class FileReader
	{
		public string Path { get; private set; }

		public FileReader(string path)
		{
			Path = path;
		}

		public string[] GetRows()
		{
			var rows = GetString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			return rows;
		}

		private string GetString()
		{
			string allFile = string.Empty;
			try
			{
				using (StreamReader reader = new StreamReader(Path, System.Text.Encoding.Default))
				{
					string line;
					int i = 0;
					while ((line = reader.ReadLine()) != null)
					{
						allFile += line + "\n";
					}
				}
			}
			catch (Exception)
			{
				throw new Exception();
			}
			return allFile;
		}
	}
}
