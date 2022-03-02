using System.Xml.Serialization;

namespace BankCurrencyService.Common.XmlHelper
{
    public static class XmlHelper
    {
        public static ResultXmlConvert<T> FromXml<T>(string xml)
        {
            var result = new ResultXmlConvert<T>();

            //T returnedXmlClass = default(T);

            try
            {
                using (TextReader reader = new StringReader(xml))
                {
                    try
                    {
                        result.Entity =
                            (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                    }
                    catch (InvalidOperationException)
                    {
                        result.ErrorMessage = "String passed is not XML";
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }

    public class ResultXmlConvert<T>
    {
        public T? Entity { get; set; }
        public bool Success => string.IsNullOrWhiteSpace(ErrorMessage);
        public string? ErrorMessage { get; set; }
    }
}
