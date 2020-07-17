using System;
using System.IO;


namespace Shapes.Reader.File.Utilities
{
	/// <summary>
	/// Public class for read file to string then to row array. 
	/// </summary>
	public class FileReader
	{
		/// <summary>
		/// File path property for reading to array. 
		/// </summary>
		public string Path { get; private set; }

		/// <summary>
		/// Constuctor initialized file path property.
		/// </summary>
		/// <param name="path"></param>
		public FileReader(string path)
		{
			Path = path;
		}

		/// <summary>
		/// Method which do rows from string.
		/// </summary>
		/// <returns>Rows array.</returns>
		public string[] GetRows()
		{
			var rows = GetString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			return rows;
		}

		/// <summary>
		/// Method which do string from user file.
		/// </summary>
		/// <returns></returns>
		private string GetString()
		{
			string allFile = string.Empty;
			try
			{
				using (StreamReader reader = new StreamReader(Path, System.Text.Encoding.Default))
				{
					string line;
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
