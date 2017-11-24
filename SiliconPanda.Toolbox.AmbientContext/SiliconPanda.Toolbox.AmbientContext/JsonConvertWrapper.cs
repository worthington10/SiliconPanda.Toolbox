using System;
using Newtonsoft.Json.Linq;
using SiliconPanda.Toolbox.AmbientContext.Defaults;

namespace SiliconPanda.Toolbox.AmbientContext
{
    public abstract class JsonConvertWrapper
    {
        private static JsonConvertWrapper _current;

        static JsonConvertWrapper()
        {
            SetDefault();
        }

        public static JsonConvertWrapper Current
        {
            get => _current;

            set => _current = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static void Reset()
        {
            SetDefault();
        }

        public abstract T DeserializeObject<T>(string value);

        public abstract T DeserializeObject<T>(string value, string propertyName);

        public abstract string SerializeObject(object value);

        public abstract string SerializeObjectWithIndentation(object value);

        public abstract JObject Parse(string value);

        private static void SetDefault()
        {
            _current = new DefaultJsonConvertWrapper();
        }

    }
}
