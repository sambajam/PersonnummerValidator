





//using NUnit.Framework;

namespace PersonnummerValidator.Tests
{
    public class UnitTests
    {
        [Test]
        public void Test_Valid_Personnummer()
        {
            Assert.That(Program.IsValidSwedishPersonalNumber("800101-1234"), Is.True);
        }

        [Test]
        public void Test_Invalid_Personnummer()
        {
            Assert.That(Program.IsValidSwedishPersonalNumber("123456-7890"), Is.False);
        }

        [Test]
        public void Test_Null_Or_Empty_Personnummer()
        {
            Assert.That(Program.IsValidSwedishPersonalNumber(null), Is.False);
            Assert.That(Program.IsValidSwedishPersonalNumber(""), Is.False);
        }

        [Test]
        public void Test_Invalid_Format_Personnummer()
        {
            Assert.That(Program.IsValidSwedishPersonalNumber("8001011234"), Is.False);
            Assert.That(Program.IsValidSwedishPersonalNumber("80-01-01-1234"), Is.False);
        }
    }
}
