using System.IO;
using FluentAssertions;
using NUnit.Framework;
using SypexDotNet.Model;

namespace SypexDotNet.Tests
{
    [TestFixture]
    public class ReaderTest
    {
        private readonly string dir = TestContext.CurrentContext.TestDirectory;

        [Test]
        public void GetLocationTest()
        {
            using (var reader = new Reader(Path.Combine(dir, "SxGeoCity.dat")))
            {
                SypexResponse res = reader.GetLocation("123.146.14.14", true);
                res.Should().NotBe(null);
                res.City.NameEn.Should().Be("Chongqing");
                res.Region.NameRu.Should().Be("Чунцин");
                res.Country.Iso.Should().Be("CN");
            }
        }
    }
}
