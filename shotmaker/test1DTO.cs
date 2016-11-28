using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shotmaker
{
    public class test1DTO
    {








        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class rss
        {

            private rssChannel channelField;

            private decimal versionField;

            /// <remarks/>
            public rssChannel channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannel
        {

            private string titleField;

            private string linkField;

            private string descriptionField;

            private string languageField;

            private rssChannelBuildinfo buildinfoField;

            private rssChannelItem itemField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string language
            {
                get
                {
                    return this.languageField;
                }
                set
                {
                    this.languageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("build-info")]
            public rssChannelBuildinfo buildinfo
            {
                get
                {
                    return this.buildinfoField;
                }
                set
                {
                    this.buildinfoField = value;
                }
            }

            /// <remarks/>
            public rssChannelItem item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelBuildinfo
        {

            private string versionField;

            private ushort buildnumberField;

            private string builddateField;

            /// <remarks/>
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("build-number")]
            public ushort buildnumber
            {
                get
                {
                    return this.buildnumberField;
                }
                set
                {
                    this.buildnumberField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("build-date")]
            public string builddate
            {
                get
                {
                    return this.builddateField;
                }
                set
                {
                    this.builddateField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItem
        {

            private string titleField;

            private rssChannelItemCustomfield[] customfieldsField;

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("customfield", IsNullable = false)]
            public rssChannelItemCustomfield[] customfields
            {
                get
                {
                    return this.customfieldsField;
                }
                set
                {
                    this.customfieldsField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfield
        {

            private string customfieldnameField;

            private rssChannelItemCustomfieldCustomfieldvalues customfieldvaluesField;

            private string idField;

            private string keyField;

            /// <remarks/>
            public string customfieldname
            {
                get
                {
                    return this.customfieldnameField;
                }
                set
                {
                    this.customfieldnameField = value;
                }
            }

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvalues customfieldvalues
            {
                get
                {
                    return this.customfieldvaluesField;
                }
                set
                {
                    this.customfieldvaluesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvalues
        {

            private rssChannelItemCustomfieldCustomfieldvaluesStep[] stepsField;

            private rssChannelItemCustomfieldCustomfieldvaluesCustomfieldvalue customfieldvalueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("step", IsNullable = false)]
            public rssChannelItemCustomfieldCustomfieldvaluesStep[] steps
            {
                get
                {
                    return this.stepsField;
                }
                set
                {
                    this.stepsField = value;
                }
            }

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesCustomfieldvalue customfieldvalue
            {
                get
                {
                    return this.customfieldvalueField;
                }
                set
                {
                    this.customfieldvalueField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStep
        {

            private byte indexField;

            private rssChannelItemCustomfieldCustomfieldvaluesStepStep stepField;

            private rssChannelItemCustomfieldCustomfieldvaluesStepData dataField;

            private rssChannelItemCustomfieldCustomfieldvaluesStepResult resultField;

            /// <remarks/>
            public byte index
            {
                get
                {
                    return this.indexField;
                }
                set
                {
                    this.indexField = value;
                }
            }

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesStepStep step
            {
                get
                {
                    return this.stepField;
                }
                set
                {
                    this.stepField = value;
                }
            }

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesStepData data
            {
                get
                {
                    return this.dataField;
                }
                set
                {
                    this.dataField = value;
                }
            }

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesStepResult result
            {
                get
                {
                    return this.resultField;
                }
                set
                {
                    this.resultField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStepStep
        {

            private rssChannelItemCustomfieldCustomfieldvaluesStepStepP pField;

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesStepStepP p
            {
                get
                {
                    return this.pField;
                }
                set
                {
                    this.pField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStepStepP
        {

            private object[] brField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("br")]
            public object[] br
            {
                get
                {
                    return this.brField;
                }
                set
                {
                    this.brField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStepData
        {

            private rssChannelItemCustomfieldCustomfieldvaluesStepDataUL ulField;

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesStepDataUL ul
            {
                get
                {
                    return this.ulField;
                }
                set
                {
                    this.ulField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStepDataUL
        {

            private string[] liField;

            private string classField;

            private string typeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("li")]
            public string[] li
            {
                get
                {
                    return this.liField;
                }
                set
                {
                    this.liField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @class
            {
                get
                {
                    return this.classField;
                }
                set
                {
                    this.classField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStepResult
        {

            private rssChannelItemCustomfieldCustomfieldvaluesStepResultP pField;

            /// <remarks/>
            public rssChannelItemCustomfieldCustomfieldvaluesStepResultP p
            {
                get
                {
                    return this.pField;
                }
                set
                {
                    this.pField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesStepResultP
        {

            private object[] brField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("br")]
            public object[] br
            {
                get
                {
                    return this.brField;
                }
                set
                {
                    this.brField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class rssChannelItemCustomfieldCustomfieldvaluesCustomfieldvalue
        {

            private ushort keyField;

            private bool keyFieldSpecified;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort key
            {
                get
                {
                    return this.keyField;
                }
                set
                {
                    this.keyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool keySpecified
            {
                get
                {
                    return this.keyFieldSpecified;
                }
                set
                {
                    this.keyFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }










    }
}
