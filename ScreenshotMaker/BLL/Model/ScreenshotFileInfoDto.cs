using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenshotMaker.BLL
{
	public class ScreenshotFileInfoDto
	{
		public ScreenshotFileInfoDto(string path, string fileName)
		{
			Path = path;
			_possiblyFileNames = new List<string> { fileName };
			_actualFileNameIndex = 0;
		}
		private List<string> _possiblyFileNames;
		private int _actualFileNameIndex = 0;
		public string Path { get; set; }
		public string FileName
		{
			get
			{
				return _actualFileNameIndex < _possiblyFileNames.Count ? _possiblyFileNames[_actualFileNameIndex] : "";
			}
			set
			{
				_actualFileNameIndex = _possiblyFileNames.IndexOf(value);
				if (_actualFileNameIndex < 0)
				{
					_possiblyFileNames.Add(value);
					_actualFileNameIndex = _possiblyFileNames.Count - 1;
				}
			}
		}
		public IReadOnlyCollection<string> GetPossiblyFileNames()
		{
			return _possiblyFileNames.AsReadOnly();
		}
		public void TransformFileNames(Func<string, string> transformation)
		{
			_possiblyFileNames = _possiblyFileNames.Select(transformation).ToList();
		}
		public void AddPossiblyFileName(string possiblyFileName)
		{
			if (!_possiblyFileNames.Contains(possiblyFileName))
				_possiblyFileNames.Add(possiblyFileName);
		}
	}
}
