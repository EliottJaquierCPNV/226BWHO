using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using Who;

namespace TestWho
{
    public class TestSoccer
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
            DateTime expected_birthdate = new DateTime(2004, 2, 25);
            int expected_number = 10;
            string expected_haircut = "Muck";

            //when
            Soccer soccer = new Soccer(expected_firstname, expected_name, expected_birthdate,expected_number,expected_haircut);

            //then
            Assert.AreEqual(expected_firstname, soccer.Firstname);
            Assert.AreEqual(expected_name, soccer.Name);
            Assert.AreEqual(expected_birthdate, soccer.Birthdate);
            Assert.AreEqual(expected_haircut, soccer.Haircut);
            Assert.AreEqual(expected_number, soccer.Number);
        }
        [Test]
        public void Walk_NominalCace_Success()
        {
            //given
            string expected_firstname = "Eliott";
            string expected_name = "Jaquier";
            DateTime expected_birthdate = new DateTime(2004, 2, 25);
            int expected_number = 10;
            string expected_haircut = "Muck";
            string expected_walk = expected_firstname + " walking faster.";
            
            Soccer soccer = new Soccer(expected_firstname, expected_name, expected_birthdate, expected_number, expected_haircut);
            string walkResult;

            //when
            walkResult = soccer.Walk();

            //then
            Assert.AreEqual(expected_walk, walkResult);
        }
    }
}
