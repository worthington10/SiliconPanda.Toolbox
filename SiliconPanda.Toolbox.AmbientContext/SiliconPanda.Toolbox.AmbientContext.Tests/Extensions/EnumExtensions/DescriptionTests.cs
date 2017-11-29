using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using SiliconPanda.Toolbox.AmbientContext.Extensions;

namespace SiliconPanda.Toolbox.AmbientContext.Tests.Extensions.EnumExtensions
{
    [TestFixture]
    public class DescriptionTests
    {
        [TestCase(TestEnum.Test, ExpectedResult = "Test")]
        [TestCase(TestEnum.AnotherTest, ExpectedResult = "Another Test")]
        public string EnumShouldReturnDescription(TestEnum value)
        {
            return value.Description();
        }

        public enum TestEnum
        {
            Test,
            [Display(Description = "Another Test")]
            AnotherTest
        }
    }
}
