﻿using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ScreenshotMaker.DAL
{
	// autogenerated and manually corrected

	/// <remarks />
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "", IsNullable = false)]
	public class rss
	{
		/// <remarks />
		public rssChannel channel { get; set; }

		/// <remarks />
		[XmlAttribute]
		public decimal version { get; set; }
	}

	/// <remarks />
	[XmlType(AnonymousType = true)]
	public class rssChannel
	{
		/// <remarks />
		public rssChannelItem item { get; set; }
	}

	/// <remarks />
	[XmlType(AnonymousType = true)]
	public class rssChannelItem
	{
		/// <remarks />
		public string title { get; set; }

		/// <remarks />
		[XmlArrayItem("customfield", IsNullable = false)]
		public rssChannelItemCustomfield[] customfields { get; set; }
	}

	/// <remarks />
	[XmlType(AnonymousType = true)]
	public class rssChannelItemCustomfield
	{
		/// <remarks />
		public string customfieldname { get; set; }

		/// <remarks />
		public rssChannelItemCustomfieldCustomfieldvalues customfieldvalues { get; set; }

		/// <remarks />
		[XmlAttribute]
		public string id { get; set; }

		/// <remarks />
		[XmlAttribute]
		public string key { get; set; }
	}

	/// <remarks />
	[XmlType(AnonymousType = true)]
	public class rssChannelItemCustomfieldCustomfieldvalues
	{
		/// <remarks />
		public string customfieldvalue { get; set; }

		/// <remarks />
		[XmlArrayItem("step", IsNullable = false)]
		public rssChannelItemCustomfieldCustomfieldvaluesStep[] steps { get; set; }
	}

	/// <remarks />
	[XmlType(AnonymousType = true)]
	public class rssChannelItemCustomfieldCustomfieldvaluesStep
	{
		/// <remarks />
		public byte index { get; set; }

		/// <remarks />
		public rssChannelItemCustomfieldCustomfieldvaluesStepStep step { get; set; }

		/// <remarks />
		public rssChannelItemCustomfieldCustomfieldvaluesStepData data { get; set; }

		/// <remarks />
		public rssChannelItemCustomfieldCustomfieldvaluesStepResult result { get; set; }
	}

	/// <remarks />
	public class rssChannelItemCustomfieldCustomfieldvaluesStepStep : IXmlSerializable
	{
		/// <remarks />
		public string Text;

		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			Text = reader.ReadInnerXml();
		}

		public void WriteXml(XmlWriter writer)
		{
			throw new NotImplementedException();
		}
	}

	/// <remarks />
	public class rssChannelItemCustomfieldCustomfieldvaluesStepData : IXmlSerializable
	{
		/// <remarks />

		public string Text;

		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			Text = reader.ReadInnerXml();
		}

		public void WriteXml(XmlWriter writer)
		{
			throw new NotImplementedException();
		}
	}

	/// <remarks />
	public class rssChannelItemCustomfieldCustomfieldvaluesStepResult : IXmlSerializable
	{
		/// <remarks />
		public string Text;

		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			Text = reader.ReadInnerXml();
		}

		public void WriteXml(XmlWriter writer)
		{
			throw new NotImplementedException();
		}
	}
}