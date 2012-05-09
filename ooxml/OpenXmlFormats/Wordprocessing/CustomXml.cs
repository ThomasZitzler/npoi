﻿using System;
using System.Collections.Generic;
using System.Text;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_CustomXmlRow
    {

        private CT_CustomXmlPr customXmlPrField;

        private object[] itemsField;

        private ItemsChoiceType21[] itemsElementNameField;

        private string uriField;

        private string elementField;

        public CT_CustomXmlRow()
        {
            this.itemsElementNameField = new ItemsChoiceType21[0];
            this.itemsField = new object[0];
            this.customXmlPrField = new CT_CustomXmlPr();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CT_CustomXmlPr customXmlPr
        {
            get
            {
                return this.customXmlPrField;
            }
            set
            {
                this.customXmlPrField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkStart", typeof(CT_Bookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeStart", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXml", typeof(CT_CustomXmlRow), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("del", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("ins", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFrom", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveTo", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("permEnd", typeof(CT_Perm), Order = 1)]
        [System.Xml.Serialization.XmlElement("permStart", typeof(CT_PermStart), Order = 1)]
        [System.Xml.Serialization.XmlElement("proofErr", typeof(CT_ProofErr), Order = 1)]
        [System.Xml.Serialization.XmlElement("sdt", typeof(CT_SdtRow), Order = 1)]
        [System.Xml.Serialization.XmlElement("tr", typeof(CT_Row), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType21[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_CustomXmlPr
    {

        private CT_String placeholderField;

        private List<CT_Attr> attrField;

        public CT_CustomXmlPr()
        {
            this.attrField = new List<CT_Attr>();
            this.placeholderField = new CT_String();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CT_String placeholder
        {
            get
            {
                return this.placeholderField;
            }
            set
            {
                this.placeholderField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("attr", Order = 1)]
        public List<CT_Attr> attr
        {
            get
            {
                return this.attrField;
            }
            set
            {
                this.attrField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Attr
    {

        private string uriField;

        private string nameField;

        private string valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
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

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string val
        {
            get
            {
                return this.valField;
            }
            set
            {
                this.valField = value;
            }
        }
    }



    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType21
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        sdt,

    
        tr,
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType22
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        sdt,

    
        tr,
    }



    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_CustomXmlRun
    {

        private CT_CustomXmlPr customXmlPrField;

        private object[] itemsField;

        private ItemsChoiceType24[] itemsElementNameField;

        private string uriField;

        private string elementField;

        public CT_CustomXmlRun()
        {
            this.itemsElementNameField = new ItemsChoiceType24[0];
            this.itemsField = new object[0];
            this.customXmlPrField = new CT_CustomXmlPr();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CT_CustomXmlPr customXmlPr
        {
            get
            {
                return this.customXmlPrField;
            }
            set
            {
                this.customXmlPrField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkStart", typeof(CT_Bookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeStart", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXml", typeof(CT_CustomXmlRun), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("del", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("fldSimple", typeof(CT_SimpleField), Order = 1)]
        [System.Xml.Serialization.XmlElement("hyperlink", typeof(CT_Hyperlink1), Order = 1)]
        [System.Xml.Serialization.XmlElement("ins", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFrom", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveTo", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("permEnd", typeof(CT_Perm), Order = 1)]
        [System.Xml.Serialization.XmlElement("permStart", typeof(CT_PermStart), Order = 1)]
        [System.Xml.Serialization.XmlElement("proofErr", typeof(CT_ProofErr), Order = 1)]
        [System.Xml.Serialization.XmlElement("r", typeof(CT_R), Order = 1)]
        [System.Xml.Serialization.XmlElement("sdt", typeof(CT_SdtRun), Order = 1)]
        [System.Xml.Serialization.XmlElement("smartTag", typeof(CT_SmartTagRun), Order = 1)]
        [System.Xml.Serialization.XmlElement("subDoc", typeof(CT_Rel), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType24[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType24
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        fldSimple,

    
        hyperlink,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        r,

    
        sdt,

    
        smartTag,

    
        subDoc,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_SmartTagRun
    {

        private List<CT_Attr> smartTagPrField;

        private object[] itemsField;

        private ItemsChoiceType25[] itemsElementNameField;

        private string uriField;

        private string elementField;

        public CT_SmartTagRun()
        {
            this.itemsElementNameField = new ItemsChoiceType25[0];
            this.itemsField = new object[0];
            this.smartTagPrField = new List<CT_Attr>();
        }

        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("attr", IsNullable = false)]
        public List<CT_Attr> smartTagPr
        {
            get
            {
                return this.smartTagPrField;
            }
            set
            {
                this.smartTagPrField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkStart", typeof(CT_Bookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeStart", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXml", typeof(CT_CustomXmlRun), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("del", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("fldSimple", typeof(CT_SimpleField), Order = 1)]
        [System.Xml.Serialization.XmlElement("hyperlink", typeof(CT_Hyperlink1), Order = 1)]
        [System.Xml.Serialization.XmlElement("ins", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFrom", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveTo", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("permEnd", typeof(CT_Perm), Order = 1)]
        [System.Xml.Serialization.XmlElement("permStart", typeof(CT_PermStart), Order = 1)]
        [System.Xml.Serialization.XmlElement("proofErr", typeof(CT_ProofErr), Order = 1)]
        [System.Xml.Serialization.XmlElement("r", typeof(CT_R), Order = 1)]
        [System.Xml.Serialization.XmlElement("sdt", typeof(CT_SdtRun), Order = 1)]
        [System.Xml.Serialization.XmlElement("smartTag", typeof(CT_SmartTagRun), Order = 1)]
        [System.Xml.Serialization.XmlElement("subDoc", typeof(CT_Rel), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType25[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType25
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        fldSimple,

    
        hyperlink,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        r,

    
        sdt,

    
        smartTag,

    
        subDoc,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_CustomXmlBlock
    {

        private CT_CustomXmlPr customXmlPrField;

        private object[] itemsField;

        private ItemsChoiceType26[] itemsElementNameField;

        private string uriField;

        private string elementField;

        public CT_CustomXmlBlock()
        {
            this.itemsElementNameField = new ItemsChoiceType26[0];
            this.itemsField = new object[0];
            this.customXmlPrField = new CT_CustomXmlPr();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CT_CustomXmlPr customXmlPr
        {
            get
            {
                return this.customXmlPrField;
            }
            set
            {
                this.customXmlPrField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkStart", typeof(CT_Bookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeStart", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXml", typeof(CT_CustomXmlBlock), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("del", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("ins", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFrom", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveTo", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("p", typeof(CT_P), Order = 1)]
        [System.Xml.Serialization.XmlElement("permEnd", typeof(CT_Perm), Order = 1)]
        [System.Xml.Serialization.XmlElement("permStart", typeof(CT_PermStart), Order = 1)]
        [System.Xml.Serialization.XmlElement("proofErr", typeof(CT_ProofErr), Order = 1)]
        [System.Xml.Serialization.XmlElement("sdt", typeof(CT_SdtBlock), Order = 1)]
        [System.Xml.Serialization.XmlElement("tbl", typeof(CT_Tbl), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType26[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType26
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        p,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        sdt,

    
        tbl,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_CustomXmlCell
    {

        private CT_CustomXmlPr customXmlPrField;

        private object[] itemsField;

        private ItemsChoiceType27[] itemsElementNameField;

        private string uriField;

        private string elementField;

        public CT_CustomXmlCell()
        {
            this.itemsElementNameField = new ItemsChoiceType27[0];
            this.itemsField = new object[0];
            this.customXmlPrField = new CT_CustomXmlPr();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CT_CustomXmlPr customXmlPr
        {
            get
            {
                return this.customXmlPrField;
            }
            set
            {
                this.customXmlPrField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("oMath", typeof(CT_OMath), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("oMathPara", typeof(CT_OMathPara), Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("bookmarkStart", typeof(CT_Bookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("commentRangeStart", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXml", typeof(CT_CustomXmlCell), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlDelRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlInsRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveFromRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeEnd", typeof(CT_Markup), Order = 1)]
        [System.Xml.Serialization.XmlElement("customXmlMoveToRangeStart", typeof(CT_TrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("del", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("ins", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFrom", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveFromRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveTo", typeof(CT_RunTrackChange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeEnd", typeof(CT_MarkupRange), Order = 1)]
        [System.Xml.Serialization.XmlElement("moveToRangeStart", typeof(CT_MoveBookmark), Order = 1)]
        [System.Xml.Serialization.XmlElement("permEnd", typeof(CT_Perm), Order = 1)]
        [System.Xml.Serialization.XmlElement("permStart", typeof(CT_PermStart), Order = 1)]
        [System.Xml.Serialization.XmlElement("proofErr", typeof(CT_ProofErr), Order = 1)]
        [System.Xml.Serialization.XmlElement("sdt", typeof(CT_SdtCell), Order = 1)]
        [System.Xml.Serialization.XmlElement("tc", typeof(CT_Tc), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType27[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string element
        {
            get
            {
                return this.elementField;
            }
            set
            {
                this.elementField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum ItemsChoiceType27
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        sdt,

    
        tc,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_SmartTagPr
    {

        private List<CT_Attr> attrField;

        public CT_SmartTagPr()
        {
            this.attrField = new List<CT_Attr>();
        }

        [System.Xml.Serialization.XmlElement("attr", Order = 0)]
        public List<CT_Attr> attr
        {
            get
            {
                return this.attrField;
            }
            set
            {
                this.attrField = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
    public enum Items1ChoiceType
    {

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMath")]
        oMath,

    
        [System.Xml.Serialization.XmlEnumAttribute("http://schemas.openxmlformats.org/officeDocument/2006/math:oMathPara")]
        oMathPara,

    
        bookmarkEnd,

    
        bookmarkStart,

    
        commentRangeEnd,

    
        commentRangeStart,

    
        customXml,

    
        customXmlDelRangeEnd,

    
        customXmlDelRangeStart,

    
        customXmlInsRangeEnd,

    
        customXmlInsRangeStart,

    
        customXmlMoveFromRangeEnd,

    
        customXmlMoveFromRangeStart,

    
        customXmlMoveToRangeEnd,

    
        customXmlMoveToRangeStart,

    
        del,

    
        ins,

    
        moveFrom,

    
        moveFromRangeEnd,

    
        moveFromRangeStart,

    
        moveTo,

    
        moveToRangeEnd,

    
        moveToRangeStart,

    
        permEnd,

    
        permStart,

    
        proofErr,

    
        sdt,

    
        tr,
    }

}
