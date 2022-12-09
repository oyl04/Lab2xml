using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2xml
{
    public class SAX : IParse
    {
        private List<Search> lastResult = null;
        public List<Search> AnalyzeFile(Search mySearch, string path)
        {
                XmlReader reader = XmlReader.Create(path);
                List<Search> result = new List<Search>();
                Search found = null;
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "TextMaterial")
                            {
                                found = new Search();
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "AUTHOR_NAME") found.authorName = reader.Value;
                                    if (reader.Name == "TITLE") found.title = reader.Value;
                                    if (reader.Name == "FACULTY") found.faculty = reader.Value;
                                    if (reader.Name == "DATE") found.date = reader.Value;
                                    if (reader.Name == "DEPARTMENT") found.department = reader.Value;
                                    if (reader.Name == "VOLUME") found.volume = reader.Value;
                                    if (reader.Name == "TYPE") found.type = reader.Value;
                                }
                                result.Add(found);
                            }
                            break;
                    }
                }
                lastResult = Filter(result, mySearch);
                return lastResult;
            }
        private List<Search> Filter(List<Search> allRes, Search myTemplate)
        {
            List<Search> newResult = new List<Search>();
            if (allRes != null)
            {
                foreach (Search el in allRes)
                {
                    if ((myTemplate.authorName == el.authorName || myTemplate.authorName == null) &&
                        (myTemplate.faculty == el.faculty || myTemplate.faculty == null) &&
                        (myTemplate.date == el.date || myTemplate.date == null) &&
                        (myTemplate.department == el.department || myTemplate.department == null) &&
                        (myTemplate.volume == null || myTemplate.isInRange(el.volume)) &&
                        (myTemplate.type == el.type || myTemplate.type == null)
                        )
                    {
                        newResult.Add(el);
                    }
                }
            }
            return newResult;
        }
    }
}