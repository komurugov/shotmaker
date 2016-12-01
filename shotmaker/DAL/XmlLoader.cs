using System.Xml;
using System.Xml.Serialization;

namespace ScreenshotMaker.DAL
{
	public static class XmlLoader
	{
		public static rss LoadFromFile(string path, out string result)
		{
			var serializer = new XmlSerializer(typeof(rss));
			XmlReader xml;
			try
			{
				xml = XmlReader.Create(path);
			}
			catch
			{
				result = "can't open file";
				return null;
			}
			rss dto;
			try
			{
				dto = serializer.Deserialize(xml) as rss;
			}
			catch
			{
				result = "incorrect format of file";
				return null;
			}
			result = null;
			return dto;
		}
	}
}