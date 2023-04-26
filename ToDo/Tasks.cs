using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ToDo
{
    static class Tasks
    {
        public static List<Task> ListOfTasks { get; set; }
        public static void Read(string path)
        {
            StreamReader re = null;
            FileStream fs = null;
            try
            {
                if (File.Exists(path))
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                    re = new StreamReader(fs);
                    string line = null;
                    ListOfTasks = new List<Task>();
                    while ((line = re.ReadLine()) != null)
                    {
                        ListOfTasks.Add(new Task(line));
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static bool Write(string path)
        {
            bool isSaved = false;
            StreamWriter sw = null;
            FileStream fs = null;
            try
            {
                fs = File.Create(path);
                sw = new StreamWriter(fs);
                foreach (Task obj in ListOfTasks)
                {
                    sw.WriteLine(obj.ToString());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    isSaved = true;
                }
            }
            return isSaved;
        }
    }
}
