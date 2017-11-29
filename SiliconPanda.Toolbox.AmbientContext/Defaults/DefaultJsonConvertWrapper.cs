using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SiliconPanda.Toolbox.AmbientContext.Defaults
{
    internal class DefaultJsonConvertWrapper : JsonConvertWrapper
    {
        public override T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public override T DeserializeObject<T>(string value, string propertyName)
        {
            var result = JObject.Parse(value).SelectToken(propertyName).ToString();
            return DeserializeObject<T>(result);
        }

        public override string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
        
        public override string SerializeObjectWithIndentation(object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        public override JObject Parse(string value)
        {
            return JObject.Parse(value);
        }
    }
}
