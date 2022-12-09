using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Lab2xml
{
    public class DOM : IParse
    {
        public List <Search> AnalyzeFile (Search mySearch, string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            List<List<Search>> info = new List<List<Search>>();
            if(mySearch.authorName == null && mySearch.faculty == null && mySearch.date == null && mySearch.department == null &&
               mySearch.volume == null && mySearch.type == null)
            {
                return ErrorCatch(doc);
            }
            if (mySearch.authorName != null) info.Add(SearchByAttribute("TextMaterial", "AUTHOR_NAME", mySearch.authorName, doc));
            if (mySearch.faculty != null) info.Add(SearchByAttribute("TextMaterial", "FACULTY", mySearch.faculty, doc));
            if (mySearch.date != null) info.Add(SearchByAttribute("TextMaterial", "DATE", mySearch.date, doc));
            if (mySearch.department != null) info.Add(SearchByAttribute("TextMaterial", "DEPARTMENT", mySearch.department, doc));
            if (mySearch.volume != null) info.Add(SearchByAttribute("TextMaterial", "VOLUME", mySearch.volume, doc));
            if (mySearch.type != null) info.Add(SearchByAttribute("TextMaterial", "TYPE", mySearch.type, doc));

            return Cross(info, mySearch);
        }



        private List<Search> SearchByAttribute (string nodeName, string attribute, string myTemplate, XmlDocument doc)
        {
            List<Search> found = new List<Search>();
            if (myTemplate != null)
            {
                
                if (attribute == "VOLUME")
                {
                    int leftval = Convert.ToInt32(myTemplate.Split("-")[0]);
                    int rightval = Convert.ToInt32(myTemplate.Split("-")[1]);
                    for (int val = leftval; val <= rightval; ++val)
                    {
                        var lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + val.ToString() + " с." + "\"]");
                        if (lst != null)
                        {
                            foreach (XmlNode xmlNode in lst)
                            {
                                found.Add(Info(xmlNode));
                            }
                        }
                    }
                }
                else {
                            var lst = doc.SelectNodes("//" + nodeName + "[@" + attribute + "=\"" + myTemplate + "\"]");
                            if (lst != null)
                            {
                                foreach (XmlNode xmlNode in lst)
                                {
                                    found.Add(Info(xmlNode));
                                }
                            }
                }
             }
                return found;
        }

        private List<Search> ErrorCatch(XmlDocument doc)
        {
            List<Search> result = new List<Search>();
            var lst = doc.SelectNodes("//" + "TextMaterial");
            if (lst != null)
            {
                foreach (XmlNode el in lst)
                {
                    result.Add(Info(el));
                }
            }
            return result;
        }

        private Search Info(XmlNode node)
        {
            Search search = new Search();
            search.authorName = node.Attributes.GetNamedItem("AUTHOR_NAME").Value;
            search.title = node.Attributes.GetNamedItem("TITLE").Value;
            search.faculty = node.Attributes.GetNamedItem("FACULTY").Value;
            search.date = node.Attributes.GetNamedItem("DATE").Value;
            search.volume = node.Attributes.GetNamedItem("VOLUME").Value;
            search.department = node.Attributes.GetNamedItem("DEPARTMENT").Value;
            search.type = node.Attributes.GetNamedItem("TYPE").Value;
            return search;
        }
        
        private List<Search> Cross (List < List<Search> > list, Search myTemplate)
        {
            List<Search> result = new List<Search>();

            List<Search> clear = CheckNodes(list, myTemplate);
            foreach(Search el in clear)
            {
                bool isIn = false;
                foreach(Search s in result)
                {
                    if (s.Compare(el))
                    {
                        isIn = true;
                    }
                }
                if (!isIn)
                {
                    result.Add(el);
                }
            }
            return result;
        }

        private List<Search> CheckNodes(List < List<Search> > list, Search myTemplate)
        {
            List<Search> newResult = new List<Search>();
            foreach(List <Search> el in list)
            {
                foreach (Search s in el)
                {
                    if((myTemplate.authorName == s.authorName || myTemplate.authorName == null) &&
                        (myTemplate.faculty == s.faculty || myTemplate.faculty == null) &&
                        (myTemplate.date == s.date || myTemplate.date == null) &&
                        (myTemplate.department == s.department || myTemplate.department == null) &&
                        (myTemplate.volume == null || myTemplate.isInRange(s.volume)) &&
                        (myTemplate.type == s.type || myTemplate.type == null))
                    {
                        newResult.Add(s);
                    }
                }
            }
            return newResult;
        }
    }
}
