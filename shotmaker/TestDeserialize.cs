using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace shotmaker
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

        private string linkField;

        private rssChannelItemProject projectField;

        private string descriptionField;

        private string environmentField;

        private rssChannelItemKey keyField;

        private string summaryField;

        private rssChannelItemType typeField;

        private rssChannelItemPriority priorityField;

        private rssChannelItemStatus statusField;

        private rssChannelItemStatusCategory statusCategoryField;

        private rssChannelItemResolution resolutionField;

        private rssChannelItemAssignee assigneeField;

        private rssChannelItemReporter reporterField;

        private object labelsField;

        private string createdField;

        private string updatedField;

        private string fixVersionField;

        private object dueField;

        private byte votesField;

        private byte watchesField;

        private rssChannelItemComment[] commentsField;

        private rssChannelItemIssuelinks issuelinksField;

        private object attachmentsField;

        private object subtasksField;

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
        public rssChannelItemProject project
        {
            get
            {
                return this.projectField;
            }
            set
            {
                this.projectField = value;
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
        public string environment
        {
            get
            {
                return this.environmentField;
            }
            set
            {
                this.environmentField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemKey key
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
        public string summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemType type
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

        /// <remarks/>
        public rssChannelItemPriority priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemStatusCategory statusCategory
        {
            get
            {
                return this.statusCategoryField;
            }
            set
            {
                this.statusCategoryField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemResolution resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemAssignee assignee
        {
            get
            {
                return this.assigneeField;
            }
            set
            {
                this.assigneeField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemReporter reporter
        {
            get
            {
                return this.reporterField;
            }
            set
            {
                this.reporterField = value;
            }
        }

        /// <remarks/>
        public object labels
        {
            get
            {
                return this.labelsField;
            }
            set
            {
                this.labelsField = value;
            }
        }

        /// <remarks/>
        public string created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <remarks/>
        public string updated
        {
            get
            {
                return this.updatedField;
            }
            set
            {
                this.updatedField = value;
            }
        }

        /// <remarks/>
        public string fixVersion
        {
            get
            {
                return this.fixVersionField;
            }
            set
            {
                this.fixVersionField = value;
            }
        }

        /// <remarks/>
        public object due
        {
            get
            {
                return this.dueField;
            }
            set
            {
                this.dueField = value;
            }
        }

        /// <remarks/>
        public byte votes
        {
            get
            {
                return this.votesField;
            }
            set
            {
                this.votesField = value;
            }
        }

        /// <remarks/>
        public byte watches
        {
            get
            {
                return this.watchesField;
            }
            set
            {
                this.watchesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("comment", IsNullable = false)]
        public rssChannelItemComment[] comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemIssuelinks issuelinks
        {
            get
            {
                return this.issuelinksField;
            }
            set
            {
                this.issuelinksField = value;
            }
        }

        /// <remarks/>
        public object attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }

        /// <remarks/>
        public object subtasks
        {
            get
            {
                return this.subtasksField;
            }
            set
            {
                this.subtasksField = value;
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
    public partial class rssChannelItemProject
    {

        private ushort idField;

        private string keyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemKey
    {

        private uint idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemType
    {

        private ushort idField;

        private string iconUrlField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
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
        public string iconUrl
        {
            get
            {
                return this.iconUrlField;
            }
            set
            {
                this.iconUrlField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemPriority
    {

        private byte idField;

        private string iconUrlField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
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
        public string iconUrl
        {
            get
            {
                return this.iconUrlField;
            }
            set
            {
                this.iconUrlField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemStatus
    {

        private ushort idField;

        private string iconUrlField;

        private string descriptionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
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
        public string iconUrl
        {
            get
            {
                return this.iconUrlField;
            }
            set
            {
                this.iconUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemStatusCategory
    {

        private byte idField;

        private string keyField;

        private string colorNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string colorName
        {
            get
            {
                return this.colorNameField;
            }
            set
            {
                this.colorNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemResolution
    {

        private sbyte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte id
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemAssignee
    {

        private string usernameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemReporter
    {

        private string usernameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemComment
    {

        private ushort idField;

        private string authorField;

        private string createdField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
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
        public string author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemIssuelinks
    {

        private rssChannelItemIssuelinksIssuelinktype issuelinktypeField;

        /// <remarks/>
        public rssChannelItemIssuelinksIssuelinktype issuelinktype
        {
            get
            {
                return this.issuelinktypeField;
            }
            set
            {
                this.issuelinktypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemIssuelinksIssuelinktype
    {

        private string nameField;

        private rssChannelItemIssuelinksIssuelinktypeOutwardlinks outwardlinksField;

        private ushort idField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public rssChannelItemIssuelinksIssuelinktypeOutwardlinks outwardlinks
        {
            get
            {
                return this.outwardlinksField;
            }
            set
            {
                this.outwardlinksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemIssuelinksIssuelinktypeOutwardlinks
    {

        private rssChannelItemIssuelinksIssuelinktypeOutwardlinksIssuelink issuelinkField;

        private string descriptionField;

        /// <remarks/>
        public rssChannelItemIssuelinksIssuelinktypeOutwardlinksIssuelink issuelink
        {
            get
            {
                return this.issuelinkField;
            }
            set
            {
                this.issuelinkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemIssuelinksIssuelinktypeOutwardlinksIssuelink
    {

        private rssChannelItemIssuelinksIssuelinktypeOutwardlinksIssuelinkIssuekey issuekeyField;

        /// <remarks/>
        public rssChannelItemIssuelinksIssuelinktypeOutwardlinksIssuelinkIssuekey issuekey
        {
            get
            {
                return this.issuekeyField;
            }
            set
            {
                this.issuekeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rssChannelItemIssuelinksIssuelinktypeOutwardlinksIssuelinkIssuekey
    {

        private ushort idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort id
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
