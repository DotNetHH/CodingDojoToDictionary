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
            var input = "a=1";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
               {"a", "1"}
            }));
        }

        [Test]
        public void TestMultipleAssignments()
        {
            var input = "a=1;b=2;c=3";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
               {"a", "1"},
               {"b", "2"},
               {"c", "3"}
            }));
        }

        [Test]
        public void TestAssignmentsWithDuplicateKey()
        {
            string input = "a=1;a=2";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
               {"a", "2"}
            }));
        }

        [Test]
        public void TestEmptyAssignment()
        {
            string input = "a=1;;a=2";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
                {"a", "2"}
            }));
        }

        [Test]
        public void TestEmptyValue()
        {
            var input = "a=";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
               {"a", ""}
            }));
        }

        [Test]
        public void TestEmptyInput()
        {
            var input = "";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
            }));
        }

        [Test]
        public void TestInvalidInput()
        {
            var input = "=1";
            Assert.Throws<Exception>(() => { StringUtils.ToDictionary(input); });
        }

        [Test]
        public void TestDoubleSplitOperators()
        {
            var input = "a==1";

            Assert.That(StringUtils.ToDictionary(input), Is.EqualTo(new Dictionary<string, string>
            {
                { "a", "=1"}
            }));
        }
    }
}