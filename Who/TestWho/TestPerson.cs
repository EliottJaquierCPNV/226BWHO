using NUnit.Framework;
using System;
using Who;

namespace TestWho
{
    public class TestPerson
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Getters_NorminalCase_Success()
        {
            //given
            string expected_firstname = "Eliott";
            string expected_name = "Jaquier";
            DateTime expected_birthdate = new DateTime(2004,2,25);

            //when
            Person person = new Person(expected_firstname,expected_name, expected_birthdate);
            
            //then
            Assert.AreEqual(expected_firstname, person.Firstname);
            Assert.AreEqual(expected_name, person.Name);
            Assert.AreEqual(expected_birthdate, person.Birthdate);
        }
    }
}