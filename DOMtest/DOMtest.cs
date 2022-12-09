using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lab2xml;

namespace DOMtest
{
    [TestClass]
    public class DOMtest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Search mySearch = new Search();
            mySearch.faculty = "����";
            mySearch.type = "������� ������";
            mySearch.date = "2003";

            string expectedTitle = "������������� ��������������� ����� ������������ � �������� �������� ���'����";
            string expectedAuthorName = "������� �.�.";
            string expectedFaculty = "����";
            string expectedDepartment = "������� ���������� ����������";
            string expectedDate = "2003";
            string expectedVolume = "5 �.";
            string expectedType = "������� ������";

            IParse search = new DOM();
            List<Search> found = search.AnalyzeFile(mySearch, "C:\\Users\\���������\\Desktop\\Labs\\base1.xml");

            Assert.AreEqual(expectedTitle, found[0].title);
            Assert.AreEqual(expectedAuthorName, found[0].authorName);
            Assert.AreEqual(expectedFaculty, found[0].faculty);
            Assert.AreEqual(expectedDepartment, found[0].department);
            Assert.AreEqual(expectedDate, found[0].date);
            Assert.AreEqual(expectedVolume, found[0].volume);
            Assert.AreEqual(expectedType, found[0].type);

        }
    }
}
