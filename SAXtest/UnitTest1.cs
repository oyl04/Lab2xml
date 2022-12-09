using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2xml;
using System.Collections.Generic;

namespace SAXtest
{
    [TestClass]
    public class SAXtest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Search by artist and genre.
            //Search criteria = new Search("", "", "", "", null);
            
            // Song (should be first in the found list).
            
            string expectedAuthorName = "Шкільняк С. С.";
            string expectedTitle = "Комп'ютерна лінгвістика для всіх";
            string expectedFaculty = "ФКНК";
            string expectedDate = "1991";
            string expectedDepartment = "Кафедра математичної інформатики";
            string expectedVolume = "205 с.";
            string expectedType = "Науково-популярна література";
           

        }
}
}