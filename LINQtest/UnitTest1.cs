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
            mySearch.department = "������� ���� �� �������㳿 �������������";

            string expectedTitle = "����������� �����. �������� � ������: ���������� �������";
            string expectedAuthorName = "������� �.�.";
            string expectedFaculty = "����";
            string expectedDepartment = "������� ���� �� �������㳿 �������������";
            string expectedDate = "2007";
            string expectedVolume = "145 �.";
            string expectedType = "���������� �������";

            IParse search = new LINQtoXML();
            List<Search> found = search.AnalyzeFile(mySearch, "C:\\Users\\���������\\Desktop\\Labs\\base2.xml");

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
