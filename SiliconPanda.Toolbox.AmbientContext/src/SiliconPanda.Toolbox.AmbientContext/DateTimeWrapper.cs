using System;
using SiliconPanda.Toolbox.AmbientContext.Defaults;

namespace SiliconPanda.Toolbox.AmbientContext
{
    public abstract class DateTimeWrapper
    {
        private static DateTimeWrapper _current;

        static DateTimeWrapper()
        {
            CreateDefault();
        }

        public static DateTimeWrapper Current
        {
            get => _current;

            set => _current = value ?? throw new ArgumentNullException(nameof(value));
        }

        public abstract DateTime Now { get; }

        public abstract DateTime UtcNow { get; }

        public abstract DateTimeOffset OffsetNow { get; }

        public abstract DateTimeOffset OffsetUtcNow { get; }

        public static void Reset()
        {
            _current = new DefaultDateTimeWrapper();
        }

        private static void CreateDefault()
        {
            _current = new DefaultDateTimeWrapper();
        }
    }
}
