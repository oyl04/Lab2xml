using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab2xml;

namespace LINQtest
{
    [TestClass]
    public class LINQtest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Search mySearch = new Search();
            mySearch.department = "Кафедра теорії та технології програмування";

            string expectedTitle = "Математична логіка. Приклади і задачі: Навчальний посібник";
            string expectedAuthorName = "Шкільняк С.С.";
            string expectedFaculty = "ФКНК";
            string expectedDepartment = "Кафедра теорії та технології програмування";
            string expectedDate = "2007";
            string expectedVolume = "145 с.";
            string expectedType = "Навчальний посібник";

            IParse search = new LINQtoXML();
            List<Search> found = search.AnalyzeFile(mySearch, "C:\\Users\\Олександр\\Desktop\\Labs\\base2.xml");

            Assert.AreEqual(expectedTitle, found[1].title);
            Assert.AreEqual(expectedAuthorName, found[1].authorName);
            Assert.AreEqual(expectedFaculty, found[1].faculty);
            Assert.AreEqual(expectedDepartment, found[1].department);
            Assert.AreEqual(expectedDate, found[1].date);
            Assert.AreEqual(expectedVolume, found[1].volume);
            Assert.AreEqual(expectedType, found[1].type);

        }
    }
}
