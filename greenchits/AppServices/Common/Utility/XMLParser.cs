using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GreenChits.Common.Utility
{
    public static class XMLParser
    {
        /// <summary>
        /// Deserializes the XML content to the object notation.
        /// </summary>
        /// <typeparam name="T"> The type to which the xml has to be de-serialized into.</typeparam>
        /// <param name="xmlString">The XML string fragment to be de-serialized.</param>
        /// <returns>The deserialized object read from the xml.</returns>
        public static T Deserialize<T>(string xmlString)
        {
            if (string.IsNullOrEmpty(xmlString))
                return default(T);
            try
            {
                using (StringReader reader = new StringReader(xmlString.Replace("\r\n", string.Empty)))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {                
                return default(T);
            }
        }

        /// <summary>
        /// Validates the specified XML fragement.
        /// </summary>
        /// <param name="xmlFragement">The XML fragement.</param>
        /// <param name="schemaPath">The schema path.</param>
        /// <returns>Error details if any.</returns>
        public static string Validate(string xmlFragement, Stream schemaStream)
        {
            // Create the XMLSchema object
            XmlSchema schema = null;
            using (XmlReader reader = XmlReader.Create(schemaStream))
            {
                schema = XmlSchema.Read(reader, null);
            }

            // Load a document and attach the schema
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlFragement);
            document.Schemas.Add(schema);

            string errorDetails = string.Empty;
            // Validate it using the attached schemas
            document.Validate((sender, e) =>
            {
                if (e.Severity == XmlSeverityType.Error || e.Severity == XmlSeverityType.Warning)
                    System.Diagnostics.Trace.WriteLine(
                      errorDetails = String.Format("Line: {0}, Position: {1} \"{2}\"",
                          e.Exception.LineNumber, e.Exception.LinePosition,
          e.Exception.Message));
            });

            return errorDetails;
        }
    }
}
