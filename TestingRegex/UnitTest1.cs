using RegexProblem;
using System.Text.RegularExpressions;

namespace TestingRegex
{
    public class Tests
    {
        Regexproblems regexProblem=new Regexproblems(null);
        [Test]
        public void TestForFirstName_When_input_correct()
        {
            string requiredoutput = "Aftab";
            string result = regexProblem.Validatefirstname("Aftab");
            Assert.AreEqual(result,requiredoutput);
        }
        [Test]
        public void TestForLastName_When_input_correct()
        {
            string requiredoutput = "Patel";
            string result = regexProblem.Validatelastname("Patel");
            Assert.AreEqual(result, requiredoutput);
        }
        [Test]
        public void TestForEmail_When_input_correct()
        {
            string requiredoutput = "abc.xyz@bridgelabz.co.in";
            string result = regexProblem.ValidateEmail("abc.xyz@bridgelabz.co.in");
            Assert.AreEqual(result, requiredoutput);
        }
        [Test]
        public void TestForPhonenumber_When_input_correct()
        {
            string requiredoutput = "91 9876987654";
            string result = regexProblem.ValidateNumber("91 9876987654");
            Assert.AreEqual(result, requiredoutput);
        }
        [Test]
        public void TestForPasswordRule1_When_input_correct()
        {
            string requiredoutput = "aftabkas";
            string result = regexProblem.ValidatePassword("aftabkas");
            Assert.AreEqual(result, requiredoutput);
        }
        [Test]
        public void TestForPasswordRule2_When_input_correct()
        {
            string requiredoutput = "Aftabpat";
            string result = regexProblem.ValidatePassword2("Aftabpat");
            Assert.AreEqual(result, requiredoutput);
        }
        [Test]
        public void TestForPasswordRule3_When_input_correct()
        {
            string requiredoutput = "Aftabpat3";
            string result = regexProblem.ValidatePassword3("Aftabpat3");
            Assert.AreEqual(result, requiredoutput);
        }
        [Test]
        public void TestForPasswordRule4_When_input_correct()
        {
            string requiredoutput = "Aftabpat@3";
            string result = regexProblem.ValidatePassword4("Aftabpat@3");
            Assert.AreEqual(result, requiredoutput);
        }
    }
}