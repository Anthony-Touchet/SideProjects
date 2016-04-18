using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Info
{
    public class InfoHandler
    {
        //Singleton
        private InfoHandler _instance;
        public InfoHandler instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InfoHandler();
                return _instance;
            }
        }

        public Dictionary<string, string> contacts;    //People as the Key, and they're Numbers as their values

        public InfoHandler()
        {
            contacts = new Dictionary<string, string>();
        }

        public bool AddContact(string name, string value)   //Add a contact To the Dictonary
        {
            if(!contacts.ContainsKey(name))
            {
                string tempString = "";
                tempString += value;
                contacts.Add(name, tempString);
                return true;
            }
            return false;
        }

        public bool AddNumer(string name, string value) //Add a number to the contact
        {
            if(contacts.ContainsKey(name))
            {               
                contacts[name] += value;
                return true;
            }
            return false;
        }

        public void SaveContacts(Dictionary<string, string> contacts, string file)
        {
            using (FileStream fs = File.OpenWrite(file))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                // Put count.
                writer.Write(contacts.Count);
                // Write pairs.
                foreach (var pair in contacts)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
            }
        }

        public Dictionary<string, string> ReadContacts(string file)
        {
            var result = new Dictionary<string, string>();
            using (FileStream fs = File.OpenRead(file))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                // Get count.
                int count = reader.ReadInt32();
                // Read in all pairs.
                for (int i = 0; i < count; i++)
                {
                    string key = reader.ReadString();
                    string value = reader.ReadString();
                    result[key] = value;
                }
            }
            return result;
        }

        public Dictionary<string, string> GetContacts()
        {
            return contacts;
        }
    }
}
