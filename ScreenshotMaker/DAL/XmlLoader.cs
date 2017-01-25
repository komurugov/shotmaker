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
			rss result;
			try
			{
				XmlReader xmlReader = XmlReader.Create(filePath);
				result = serializer.Deserialize(xmlReader) as rss;
			}
			catch (Exception exception)
			{
				throw new InvalidDataException(string.Format("Can't parse file {0}: {1}", filePath, exception.Message));
			}
			return result;
		}
	}
}