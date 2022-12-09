using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2xml
{
    public interface IParse
    {
        List<Search> AnalyzeFile(Search mySearch, string path);
    }
}
