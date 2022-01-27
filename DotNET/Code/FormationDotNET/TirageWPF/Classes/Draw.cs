using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirageWPF.Classes
{
    internal class Draw
    {
        // Path vers les fichiers source
        private string PathFileOrigin = "ListOrigin.txt";
        private string PathFileAlready = "AlreadyList.txt";
        private string PathFileSave = "SaveList.txt";
        

        // Liste des personnes pour notre class tirage
        private ObservableCollection<Person> personList;
        private ObservableCollection<Person> alreadyList;

        public Draw()
        {
            PersonList = new ObservableCollection<Person>();
            AlreadyList = new ObservableCollection<Person>();
            Init();
        }

        internal ObservableCollection<Person> PersonList { get => personList; set => personList = value; }
        internal ObservableCollection<Person> AlreadyList { get => alreadyList; set => alreadyList = value; }

        private void Init()
        {
            try
            {
                StreamReader reader = new StreamReader(PathFileOrigin);
                string contentOrigin = reader.ReadToEnd();
                PersonList = contentOrigin != "" ? JsonConvert.DeserializeObject<ObservableCollection<Person>>(contentOrigin) : new ObservableCollection<Person>();
                reader.Close();
                reader = new StreamReader(PathFileAlready);
                string content = reader.ReadToEnd();
                AlreadyList = content != "" ? JsonConvert.DeserializeObject<ObservableCollection<Person>>(content) : new ObservableCollection<Person>();
                reader.Close();
            }
            catch (Exception)
            {
                SaveNewList();
                Save();
            }
        }        
        public void SaveNewList()
        {
            StreamWriter w = new StreamWriter(PathFileOrigin);
            w.WriteLine(JsonConvert.SerializeObject(PersonList));
            w.Close();
        }
        public void SaveUserList(string fileName, ObservableCollection<Person> userList)
        {
            string pathFile = $"save\\{fileName}.txt";
            StreamWriter w = new StreamWriter(pathFile);
            w.WriteLine(JsonConvert.SerializeObject(userList));
            w.Close();
        }
        public bool LoadUserList(string fileName)
        {
            string pathFile = $"save\\{fileName}.txt";            
            
            try
            {
                StreamReader reader = new StreamReader(pathFile);
                string contentOrigin = reader.ReadToEnd();
                PersonList = JsonConvert.DeserializeObject<ObservableCollection<Person>>(contentOrigin) ;
                reader.Close();  
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Save()
        {
            StreamWriter w = new StreamWriter(PathFileAlready);
            w.WriteLine(JsonConvert.SerializeObject(AlreadyList));
            w.Close();
        }
        public Person MakeDraw()
        {
            Random randon = new Random();
            Person tmp=null;
            bool valid = false;
            if (AlreadyList.Count == PersonList.Count)
            {
                AlreadyList.Clear();
            }
            if (PersonList.Count >0)
            {
                while (!valid)
                {
                    bool drawed = false;
                    tmp = PersonList[randon.Next(PersonList.Count)];

                    for (int i = 0; i < AlreadyList.Count; i++)
                    {
                        if (AlreadyList[i].FirstName == tmp.FirstName && AlreadyList[i].LastName == tmp.LastName)
                        {
                            drawed = true;
                        }
                    }
                    if (!drawed)
                        valid = true;
                }
            }
            return tmp;
        }
        public void SaveDraw(Person p)
        {
            if (p != null)
            {
                AlreadyList.Add(p);
                
                Save();
            }
        }        
        public bool AddPerson(Person p)
        {
            int tmp = PersonList.Count();
            PersonList.Add(p);
            int tmp2 = PersonList.Count();
            
            return tmp2 - tmp == 1 ? true : false;
        }
    }
}
