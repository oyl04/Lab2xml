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
            
            string expectedAuthorName = "������� �. �.";
            string expectedTitle = "����'������ ��������� ��� ���";
            string expectedFaculty = "����";
            string expectedDate = "1991";
            string expectedDepartment = "������� ����������� �����������";
            string expectedVolume = "205 �.";
            string expectedType = "�������-��������� ���������";
           

        }
}
}