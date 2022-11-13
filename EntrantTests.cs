using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnonymousRaffle;
using System;

namespace EntrantUnitTests
{

    [TestClass]public class EntrantTesting
    {
        [TestMethod]public void RandomizeInitials_EntrantInitialsPopulated_ReturnsTrue()
        {
            Entrant Entrant = new Entrant();
            string initialsTest = Entrant.RandomizeInitials();
            Assert.AreEqual(Entrant.Initials.Length, initialsTest.Length);
        }
        
        [TestMethod]public void RandomizeInitials_EntrantInitialsEqualsTwoCharacters_ReturnsTrue()
        {
            Entrant Entrant = new Entrant();
            const int INITIALSTEST = 2;
            Assert.AreEqual(Entrant.Initials.Length, INITIALSTEST);
        }

        [TestMethod]public void RandomizeDate_EntrantDateOfBirthIsBetweenTwoSpecifiedDates_ReturnsTrue()
        {
            Entrant Entrant = new Entrant();
            DateTime outOfBoundsDate = new DateTime(1900, 01, 01);
            DateTime outOfBoundsDate2 = new DateTime(2023, 12, 12);
            Assert.IsTrue(outOfBoundsDate < (DateTime)Entrant.DOB);
            Assert.IsTrue(outOfBoundsDate2 > (DateTime)Entrant.DOB);

        }
    }

}