using System;

namespace SiliconPanda.Toolbox.AmbientContext.Defaults
{
    internal class DefaultDateTimeWrapper : DateTimeWrapper
    {
        public override DateTime Now => DateTime.Now;

        public override DateTime UtcNow => DateTime.UtcNow;

        public override DateTimeOffset OffsetNow => DateTimeOffset.Now;

        public override DateTimeOffset OffsetUtcNow => DateTimeOffset.UtcNow;
    }
}
