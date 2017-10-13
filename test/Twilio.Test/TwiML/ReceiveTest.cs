/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML.Fax;

namespace Twilio.Tests.TwiML 
{

    [TestFixture]
    public class ReceiveTest : TwilioTest 
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new Receive();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Receive></Receive>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithParams()
        {
            var elem = new Receive(new Uri("https://example.com"), Twilio.Http.HttpMethod.Get);
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Receive action=\"https://example.com\" method=\"GET\"></Receive>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new Receive();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Receive newParam1=\"value\" newParam2=\"1\"></Receive>",
                elem.ToString()
            );
        }
    }

}