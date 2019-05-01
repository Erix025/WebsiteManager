using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteManager.Varibute;
using DataEdit;
namespace WebsiteManager
{
    namespace DataEdit
    {
        class DataLoad
        {
            public static Array_Website WebsiteLoad(string path)
            {
                var tem = ReadFiles.ItemRead(path);
                string[] item_keys = tem.Item2;
                string[] item_values = tem.Item3;
                Array_Website websites = new Array_Website();
                string Name = "";
                for (int i = 0; i < item_keys.Length; i++)
                {
                    switch (item_keys[i])
                    {
                        case "Name":
                            Name = item_values[i];
                            break;
                        case "URL":
                            websites.Add(new Website(Name, item_values[i]));
                            break;
                    }
                }
                return websites;
            }
        }
        class DataSave
        {
            public static void WebsiteSave(Array_Website websites, string path)
            {
                string[] output = new string[websites.GetTotal() * 3];
                for(int i=0; i<websites.GetTotal(); i++){
                    Website tem = websites.GetArray()[i];
                    output[i * 3 + 0] = "[" + tem.Name + "]";
                    output[i * 3 + 1] = "Name=" + tem.Name;
                    output[i * 3 + 2] = "URL=" + tem.URL;
                }
                WriteFiles.Write(output, path);
            }
        }
    }
}
