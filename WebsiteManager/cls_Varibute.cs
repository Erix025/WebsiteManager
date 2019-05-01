using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteManager
{
    namespace Varibute
    {
        class Website
        {
            public string Name { get; set; }
            public string URL { get; set; }
            public Website(string Name, string URL)
            {
                this.Name = Name;
                this.URL = URL;
            }
        }
        class Array_Website
        {
            private Website[] websites;
            private int total;
            public Array_Website()
            {
                websites = new Website[0];
                total = 0;
            }
            public void Add(Website website)
            {
                Website
[] tem = websites;
                total++;
                websites = new Website[total];
                int i = 0;
                foreach(Website tem_website in tem)
                {
                    websites[i] = tem[i];
                    i++;
                }
                websites[total - 1] = website;
            }
            public void Delete(int index)
            {
                Website[] tem = websites;
                for(int i=index + 1; i<total; i++)
                {
                    tem[i - 1] = tem[i];
                }
                total--;
                websites = new Website[total];
                for(int i=0; i<total; i++)
                {
                    websites[i] = tem[i];
                }
            }
            public Website[] GetArray()
            {
                return websites;
            }
            public int GetTotal()
            {
                return total;
            }
        }
        class EditVaribute
        {
            public static string name;
            public static string URL;
        }
    }
}
