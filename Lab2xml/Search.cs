using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2xml
{
    public class Search
    {
        public string authorName = null;
        public string title = null;
        public string faculty = null;
        public string date = null;
        public string department = null;
        public string volume = null;
        public string type = null;
        public Search()
        {
            
        }

        public bool isInRange(string value)
        {
            int val = Convert.ToInt32(value.Split(" ")[0]);
            int leftval = Convert.ToInt32(this.volume.Split("-")[0]);
            int rightval = Convert.ToInt32(this.volume.Split("-")[1]);
            if (leftval <= val && val <= rightval) return true;
            else return false;
        }
        public bool Compare(Search obj)
        {
            if (this.title == obj.title &&
                this.faculty == obj.faculty &&
                this.date == obj.date &&
                this.department == obj.department &&
                this.volume == obj.volume &&
                this.type == obj.type &&
                this.authorName == obj.authorName
                ) return true;
            else return false;
        }
    }
}
