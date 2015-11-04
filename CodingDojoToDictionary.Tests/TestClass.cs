using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojoToDictionary.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestSingleAssignment()
        {
            var sut = new Class();
            var input = "a=1";

            Assert.That(sut.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
               {"a", "1"}
            }));
        }

        [Test]
        public void TestMultipleAssignments()
        {
            var sut = new Class();
            var input = "a=1;b=2;c=3";

            Assert.That(sut.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
               {"a", "1"},
               {"b", "2"},
               {"c", "3"}
            }));
        }
    }
}