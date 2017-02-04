using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL
{
	class FileInfoDto
	{
		public FileInfoDto(string path = "", string fileName = "")
		{
			Path = path;
			FileName = fileName;
		}
		public string Path { get; set; }
		public string FileName { get; set; }
	}
}
