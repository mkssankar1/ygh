using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Web.Mail;
using System.Web.UI.WebControls;

using System.Xml.Serialization;
using System.Reflection;
using System.Configuration;
using System.Xml;


namespace GreenChits.Common.Utility
{
    public class Deserializer
    {
       /* private OperatorTemplate operatorTemplate = null;

        public void InitializeXml()
        {
            using (Stream schemaStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Flex.BenefitSystem.Common.Utility.OperatorTemplate.xsd"))
            {
                string requestFileContent = string.Empty;
                //string xmlFilePath = ConfigurationManager.AppSettings["QueryDesignerXMLConfig"].ToString();

                string operatorXmlFilePath = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["operatorXmlFilePath"].ToString());

                using (StreamReader fsReader = File.OpenText(operatorXmlFilePath))
                {
                    requestFileContent = fsReader.ReadToEnd();
                }

                string errors = XMLParser.Validate(requestFileContent, schemaStream);
                if (!(errors.Length > 0))
                {
                    using (StringReader reader = new StringReader(requestFileContent))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(OperatorTemplate));
                        operatorTemplate = (OperatorTemplate)serializer.Deserialize(reader);
                    }
                }
            }
        }

        public List<OperatorTemplate.OperatorRow> GetOperatorsList(string operatorName, bool isReferenceKey = false)
        {
            List<OperatorTemplate.OperatorRow> operatorsRowList = new List<OperatorTemplate.OperatorRow>();
            var operatorType = operatorTemplate.Datatype.Where(s => s.Name == operatorName && Convert.ToBoolean(s.ItemArray[2]) == isReferenceKey).FirstOrDefault();
            OperatorTemplate.OperatorMapRow[] rows = operatorType.GetOperatorMapRows();
            foreach (OperatorTemplate.OperatorMapRow item in rows)
            {
                foreach (string id in item.OperatorIds.Split('|'))
                {
                    operatorsRowList.AddRange(operatorTemplate.Operator.Where(s => s.Id.ToString() == id));
                }
            }

            return operatorsRowList;
        }*/
    }

    public enum JoinType
    {
        InnerJoin = 1,
        LeftJoin,
        RightJoin
    }

    public static class Enumeration
    {
        public static IDictionary<int, string> GetAll<TEnum>() where TEnum : struct
        {
            var enumerationType = typeof(TEnum);

            if (!enumerationType.IsEnum)
                throw new ArgumentException("Enumeration type is expected.");

            var dictionary = new Dictionary<int, string>();

            foreach (int value in Enum.GetValues(enumerationType))
            {
                var name = Enum.GetName(enumerationType, value);
                dictionary.Add(value, name);
            }

            return dictionary;
        }
    }
}
