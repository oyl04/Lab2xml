using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2xml
{
    public class LINQtoXML: IParse
    {
        public List <Search> AnalyzeFile(Search mySearch, string path)
        {
            List<Search> found = null;
            XDocument doc = new XDocument();
            doc = XDocument.Load(@path);
            found = new List<Search>();
            List<XElement> matches = (from val in doc.Descendants("TextMaterial")
                                      where ((mySearch.faculty == null || mySearch.faculty == val.Attribute("FACULTY").Value) &&
                                      (mySearch.authorName == null || mySearch.authorName == val.Attribute("AUTHOR_NAME").Value) &&
                                      (mySearch.date == null || mySearch.date == val.Attribute("DATE").Value) &&
                                      (mySearch.department == null || mySearch.department == val.Attribute("DEPARTMENT").Value) &&
                                      (mySearch.volume == null || mySearch.isInRange(val.Attribute("VOLUME").Value)) &&
                                      (mySearch.type == null || mySearch.type == val.Attribute("TYPE").Value)
                                      ) select val).ToList();
            foreach (XElement match in matches)
            {
                Search res = new Search();
                res.authorName = match.Attribute("AUTHOR_NAME").Value;
                res.faculty = match.Attribute("FACULTY").Value;
                res.title = match.Attribute("TITLE").Value;
                res.date = match.Attribute("DATE").Value;
                res.department = match.Attribute("DEPARTMENT").Value;
                res.volume = match.Attribute("VOLUME").Value;
                res.type = match.Attribute("TYPE").Value;
                found.Add(res);
            }
            return found;
        }
    }
}
