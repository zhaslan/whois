using NUnit.Framework;
using Whois.Models;
using Whois.Parsers;

namespace Whois.Parsing.Whois.Nic.Dz.Dz
{
    [TestFixture]
    public class DzParsingTests : ParsingTests
    {
        private WhoisParser parser;

        [SetUp]
        public void SetUp()
        {
            SerilogConfig.Init();

            parser = new WhoisParser();
        }

        [Test]
        public void Test_not_found()
        {
            var sample = SampleReader.Read("whois.nic.dz", "dz", "not_found.txt");
            var response = parser.Parse("whois.nic.dz", "dz", sample);

            Assert.Greater(sample.Length, 0);
            Assert.AreEqual(WhoisResponseStatus.NotFound, response.Status);
        }

        [Test]
        public void Test_found()
        {
            var sample = SampleReader.Read("whois.nic.dz", "dz", "found.txt");
            var response = parser.Parse("whois.nic.dz", "dz", sample);

            Assert.Greater(sample.Length, 0);
            Assert.AreEqual(WhoisResponseStatus.Found, response.Status);
        }
    }
}