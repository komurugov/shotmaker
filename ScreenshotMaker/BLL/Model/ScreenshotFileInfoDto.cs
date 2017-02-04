using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL
{
	public class ScreenshotFileInfoDto
	{
		public ScreenshotFileInfoDto(string path = "", string fileName = "")
		{
			Path = path;
			FileName = fileName;
			_possiblyFileNames = new List<string>();
		}
		public string Path { get; set; }
		public string FileName { get; set; }
		private List<string> _possiblyFileNames;
		public List<string> GetPossiblyFileNames()
		{
			return _possiblyFileNames.Concat(new List<string> { FileName }).ToList();
		}
		public void AddPossiblyFileName(string fileName)
		{
			_possiblyFileNames.Add(fileName);
		}
	}
}
