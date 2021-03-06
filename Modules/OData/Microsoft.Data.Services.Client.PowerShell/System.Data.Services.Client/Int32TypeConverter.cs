namespace System.Data.Services.Client
{
    using System;
    using System.Xml;

    internal sealed class Int32TypeConverter : PrimitiveTypeConverter
    {
        internal override object Parse(string text)
        {
            return XmlConvert.ToInt32(text);
        }

        internal override string ToString(object instance)
        {
            return XmlConvert.ToString((int) instance);
        }
    }
}

