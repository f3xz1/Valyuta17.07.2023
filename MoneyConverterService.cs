using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace valyuta
{
    public class MoneyConverterService
    {

       private string req { get; set; } = "https://www.cbar.az/currencies/";


        public async Task<ValCurs> Get()
        {
            HttpClient Client = new();
            HttpResponseMessage message = await Client.GetAsync(req + DateTime.Now.ToString().Split()[0] + ".xml");

            XmlSerializer serializer = new XmlSerializer(typeof(ValCurs));

            ValCurs result = new();

            if (message.Content != null)
            {
                using (StringReader reader = new StringReader(message.Content.ToString()))
                {
                    result = (ValCurs)serializer.Deserialize(reader);
                }
            }

            return result;
        }
    }
}
