﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using NPOI.OpenXmlFormats.Shared;

namespace NPOI.OpenXmlFormats.Wordprocessing
{

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot("fonts", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
    public class CT_FontsList
    {

        private List<CT_Font> fontField;

        public CT_FontsList()
        {
            this.fontField = new List<CT_Font>();
        }

        [System.Xml.Serialization.XmlElement("font", Order = 0)]
        public List<CT_Font> font
        {
            get
            {
                return this.fontField;
            }
            set
            {
                this.fontField = value;
            }
        }
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Font
    {

        private CT_String altNameField;

        private CT_Panose panose1Field;

        private CT_UcharHexNumber charsetField;

        private CT_FontFamily familyField;

        private CT_OnOff notTrueTypeField;

        private CT_Pitch pitchField;

        private CT_FontSig sigField;

        private CT_FontRel embedRegularField;

        private CT_FontRel embedBoldField;

        private CT_FontRel embedItalicField;

        private CT_FontRel embedBoldItalicField;

        private string nameField;

        public CT_Font()
        {
            this.embedBoldItalicField = new CT_FontRel();
            this.embedItalicField = new CT_FontRel();
            this.embedBoldField = new CT_FontRel();
            this.embedRegularField = new CT_FontRel();
            this.sigField = new CT_FontSig();
            this.pitchField = new CT_Pitch();
            this.notTrueTypeField = new CT_OnOff();
            this.familyField = new CT_FontFamily();
            this.charsetField = new CT_UcharHexNumber();
            this.panose1Field = new CT_Panose();
            this.altNameField = new CT_String();
        }

        [System.Xml.Serialization.XmlElement(Order = 0)]
        public CT_String altName
        {
            get
            {
                return this.altNameField;
            }
            set
            {
                this.altNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 1)]
        public CT_Panose panose1
        {
            get
            {
                return this.panose1Field;
            }
            set
            {
                this.panose1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 2)]
        public CT_UcharHexNumber charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 3)]
        public CT_FontFamily family
        {
            get
            {
                return this.familyField;
            }
            set
            {
                this.familyField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 4)]
        public CT_OnOff notTrueType
        {
            get
            {
                return this.notTrueTypeField;
            }
            set
            {
                this.notTrueTypeField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 5)]
        public CT_Pitch pitch
        {
            get
            {
                return this.pitchField;
            }
            set
            {
                this.pitchField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 6)]
        public CT_FontSig sig
        {
            get
            {
                return this.sigField;
            }
            set
            {
                this.sigField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 7)]
        public CT_FontRel embedRegular
        {
            get
            {
                return this.embedRegularField;
            }
            set
            {
                this.embedRegularField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 8)]
        public CT_FontRel embedBold
        {
            get
            {
                return this.embedBoldField;
            }
            set
            {
                this.embedBoldField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 9)]
        public CT_FontRel embedItalic
        {
            get
            {
                return this.embedItalicField;
            }
            set
            {
                this.embedItalicField = value;
            }
        }

        [System.Xml.Serialization.XmlElement(Order = 10)]
        public CT_FontRel embedBoldItalic
        {
            get
            {
                return this.embedBoldItalicField;
            }
            set
            {
                this.embedBoldItalicField = value;
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
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FontFamily
    {

        private ST_FontFamily valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_FontFamily val
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
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_FontFamily
    {

    
        decorative,

    
        modern,

    
        roman,

    
        script,

    
        swiss,

    
        auto,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Pitch
    {

        private ST_Pitch valField;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Pitch val
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
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_Pitch
    {

    
        @fixed,

    
        variable,

    
        @default,
    }


    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_FontSig
    {

        private byte[] usb0Field;

        private byte[] usb1Field;

        private byte[] usb2Field;

        private byte[] usb3Field;

        private byte[] csb0Field;

        private byte[] csb1Field;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] usb0
        {
            get
            {
                return this.usb0Field;
            }
            set
            {
                this.usb0Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] usb1
        {
            get
            {
                return this.usb1Field;
            }
            set
            {
                this.usb1Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] usb2
        {
            get
            {
                return this.usb2Field;
            }
            set
            {
                this.usb2Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] usb3
        {
            get
            {
                return this.usb3Field;
            }
            set
            {
                this.usb3Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] csb0
        {
            get
            {
                return this.csb0Field;
            }
            set
            {
                this.csb0Field = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
        public byte[] csb1
        {
            get
            {
                return this.csb1Field;
            }
            set
            {
                this.csb1Field = value;
            }
        }
    }

    [System.SerializableAttribute()]

    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    [System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
    public class CT_Fonts
    {

        private ST_Hint hintField;

        private bool hintFieldSpecified;

        private string asciiField;

        private string hAnsiField;

        private string eastAsiaField;

        private string csField;

        private ST_Theme asciiThemeField;

        private bool asciiThemeFieldSpecified;

        private ST_Theme hAnsiThemeField;

        private bool hAnsiThemeFieldSpecified;

        private ST_Theme eastAsiaThemeField;

        private bool eastAsiaThemeFieldSpecified;

        private ST_Theme csthemeField;

        private bool csthemeFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Hint hint
        {
            get
            {
                return this.hintField;
            }
            set
            {
                this.hintField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hintSpecified
        {
            get
            {
                return this.hintFieldSpecified;
            }
            set
            {
                this.hintFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string ascii
        {
            get
            {
                return this.asciiField;
            }
            set
            {
                this.asciiField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string hAnsi
        {
            get
            {
                return this.hAnsiField;
            }
            set
            {
                this.hAnsiField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string eastAsia
        {
            get
            {
                return this.eastAsiaField;
            }
            set
            {
                this.eastAsiaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string cs
        {
            get
            {
                return this.csField;
            }
            set
            {
                this.csField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Theme asciiTheme
        {
            get
            {
                return this.asciiThemeField;
            }
            set
            {
                this.asciiThemeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool asciiThemeSpecified
        {
            get
            {
                return this.asciiThemeFieldSpecified;
            }
            set
            {
                this.asciiThemeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Theme hAnsiTheme
        {
            get
            {
                return this.hAnsiThemeField;
            }
            set
            {
                this.hAnsiThemeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hAnsiThemeSpecified
        {
            get
            {
                return this.hAnsiThemeFieldSpecified;
            }
            set
            {
                this.hAnsiThemeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Theme eastAsiaTheme
        {
            get
            {
                return this.eastAsiaThemeField;
            }
            set
            {
                this.eastAsiaThemeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eastAsiaThemeSpecified
        {
            get
            {
                return this.eastAsiaThemeFieldSpecified;
            }
            set
            {
                this.eastAsiaThemeFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public ST_Theme cstheme
        {
            get
            {
                return this.csthemeField;
            }
            set
            {
                this.csthemeField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool csthemeSpecified
        {
            get
            {
                return this.csthemeFieldSpecified;
            }
            set
            {
                this.csthemeFieldSpecified = value;
            }
        }
    }


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_Hint
    {

    
        @default,

    
        eastAsia,

    
        cs,
    }
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
    public enum ST_Theme
    {

    
        majorEastAsia,

    
        majorBidi,

    
        majorAscii,

    
        majorHAnsi,

    
        minorEastAsia,

    
        minorBidi,

    
        minorAscii,

    
        minorHAnsi,
    }

}