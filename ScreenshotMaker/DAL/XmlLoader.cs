using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace ScreenshotMaker.DAL
{
	public static class XmlLoader
	{
		public static rss LoadFromFile(string filePath)
		{
			if (!File.Exists(filePath))
				throw new FileNotFoundException(string.Format("Can't find file {0}", filePath));
			
			var serializer = new XmlSerializer(typeof(rss));
			XmlReader xmlReader = XmlReader.Create(filePath);
			rss result;
			try
			{
				result = serializer.Deserialize(xmlReader) as rss;
			}
			catch
			{
				throw new InvalidDataException(string.Format("Can't parse file {0}", filePath));
			}
			return result;
		}
	}
}