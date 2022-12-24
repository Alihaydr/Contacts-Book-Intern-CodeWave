using firstTest.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstTest.FileController
{
    public static class FileController
    {
        static string[] words;
        static String path = Environment.CurrentDirectory + @"\" + "ContactsBook.txt";
        public static List<Data> datalList = new List<Data>();
        public static Dictionary<int, Data> dData = new Dictionary<int, Data>();
      public static string alltext;
       // public static Dictionary<int, Data> DData;
            public static void SaveInTxt(Dictionary<int, Data> SdData)
            {
                alltext = "";
                foreach (KeyValuePair<int, Data> data in SdData)
                {
                    alltext += data.Value.ToString() +"\n";
                }

               // File.WriteAllText(path, alltext);
                using (TextWriter fileWriter = new StreamWriter(path, append: false))
                    {
                        fileWriter.Write(alltext);
                        fileWriter.Close();

                    }
                //File.WriteAllText(path, String.Empty);
                //TextWriter tw = new StreamWriter(path, true);
                //tw.Write(alltext);
                //tw.Close();
            }

            public static Dictionary<int, Data> GetContacts()
            {
                Dictionary<int, Data> DDatain = new Dictionary<int, Data>();
                    string[] readText = File.ReadAllLines(path);
                    foreach (string s in readText)
                    {
                        if (!string.IsNullOrEmpty(s))
                        {
                            words = s.Split('|');
                            Data data = new Data(Int32.Parse(words[0]), words[1], words[2], words[3], words[4], words[5], words[6]);
                            DDatain.Add(data.Id, data);
                        }

                        
                    }

                    return DDatain;
            }
       
            public static void Update(int id,Data newDataUp)
            {
                dData[id] = newDataUp;
                SaveInTxt(dData);
            }

            public static void Delete(int id)
            {
             Dictionary<int, Data> delData = new Dictionary<int, Data>();

                delData = GetContacts();
                delData.Remove(id);
                SaveInTxt(delData);
            }

            public static void Add(Data newdata)
            {
                Dictionary<int, Data> addData = new Dictionary<int, Data>();
                addData = GetContacts();
                addData.Add(newdata.Id, newdata);
                SaveInTxt(addData);
            }

            public static int getNewId()
            {
                int max = 0;
                int id = 0;

                dData = GetContacts();

                foreach (KeyValuePair<int, Data> data in dData)
                {
                    id = data.Value.Id;
                    if (id > max)
                        max = id;
                }

                return ++max;
            }

    }
}
