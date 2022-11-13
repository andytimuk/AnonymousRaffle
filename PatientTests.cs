using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClinicalTrial;
using System;

namespace PatientUnitTests
{

    [TestClass]public class PatientTesting
    {
        [TestMethod]public void RandomizeInitials_PatientInitialsPopulated_ReturnsTrue()
        {
            Patient Patient = new Patient();
            string initialsTest = Patient.RandomizeInitials();
            Assert.AreEqual(Patient.Initials.Length, initialsTest.Length);
        }
        
        [TestMethod]public void RandomizeInitials_PatientInitialsEqualsTwoCharacters_ReturnsTrue()
        {
            Patient Patient = new Patient();
            const int INITIALSTEST = 2;
            Assert.AreEqual(Patient.Initials.Length, INITIALSTEST);
        }

        [TestMethod]public void RandomizeDate_PatientDateOfBirthIsBetweenTwoSpecifiedDates_ReturnsTrue()
        {
            Patient Patient = new Patient();
            DateTime outOfBoundsDate = new DateTime(1900, 01, 01);
            DateTime outOfBoundsDate2 = new DateTime(2023, 12, 12);
            Assert.IsTrue(outOfBoundsDate < (DateTime)Patient.DOB);
            Assert.IsTrue(outOfBoundsDate2 > (DateTime)Patient.DOB);

        }
    }

}