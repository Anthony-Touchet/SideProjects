using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        Dictionary<string, string> contacts;    //People as the Key, and they're Numbers as their values

        public InfoHandler()
        {
            contacts = new Dictionary<string, string>();
        }

        public bool AddContact(string name, string value)   //Add a contact To the Dictonary
        {
            if(!contacts.ContainsKey(name))
            {
                contacts.Add(name, value);
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
                writer.Write(contacts.Count);
                foreach(var cont in contacts)
                {
                    writer.Write(cont.Key);
                    writer.Write(cont.Value);
                }
            }
        }

        public void ReadContacts(string file)
        {
            var Tempcontacts = new Dictionary<string, string>();
            using (FileStream fs = File.OpenRead(file))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int count = reader.ReadInt32();
                for(int i = 0; i < 0; i++)
                {
                    string key = reader.ReadString();
                    string value = reader.ReadString();
                    contacts.Add(key, value);
                }
                this.instance.contacts = Tempcontacts;
            }
        }

        public Dictionary<string, string> GetContacts()
        {
            return contacts;
        }
    }
}
