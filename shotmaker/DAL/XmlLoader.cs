using System.IO;
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
			
			return serializer.Deserialize(xmlReader) as rss;
		}
	}
}