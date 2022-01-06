using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTheGreatTpList.Classes
{
    internal class Tirage
    {
        private string PathFileOrigin = "listeOrigine.txt";
        private string PathFile = "listeDeja.txt";
        private List<string> liste;
        private List<string> deja;

        public List<string> Liste { get => liste; }
        public List<string> Deja { get => deja; }

        public Tirage()
        {
            liste = new List<string>();
            deja = new List<string>();
            Init();
        }
        private void Init()
        {
            try
            {
                StreamReader reader = new StreamReader(PathFileOrigin);
                string contentOrigine = reader.ReadToEnd();
                liste = contentOrigine != "" ? JsonConvert.DeserializeObject<List<string>>(contentOrigine) : new List<string>();
                reader.Close();
                reader = new StreamReader(PathFile);
                string content = reader.ReadToEnd();
                deja = content !="" ? JsonConvert.DeserializeObject<List<string>>(content) : new List<string>();
                reader.Close();
            }
            catch (Exception)
            {
                Save();
            }

        }

        private void Save()
        {
            StreamWriter writer = new StreamWriter(PathFile);
            writer.WriteLine(JsonConvert.SerializeObject(deja));
            writer.Close();
        }

        public string Pull()
        {
            Random rand = new Random();
            string prenom;
            do
            {
                prenom = liste[rand.Next(liste.Count)];
            } while (deja.Find(x => x == prenom)==prenom);
            
            return prenom;
        }

        public void AddPulled(string prenom)
        {
            deja.Add(prenom);
            Save();

            if (deja.Count == liste.Count)
            {
                deja.Clear();
                Save();
            }
        }
    }
}
