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

        [Serializable]
        public class Contact
        {
            public string name;
            public List<string> numbers;

            public Contact()
            {

            }

            public Contact CreateContact(string n, string value)
            {
                name = n;
                numbers = new List<string>();
                numbers.Add(value);
                return this;
            }
        }

        public List<Contact> contacts; //all the contacts

        public InfoHandler()
        {
            contacts = new List<Contact>();
        }

        public bool AddContact(string name, string num)   
        {
            foreach (Contact c in contacts) //Check to see if Contact is inside the list
            {
                if (c.name == name)
                    return false;
            }
            //if contact is not in list, create new one
            Contact newContact = new Contact();
            newContact.CreateContact(name, num);
            contacts.Add(newContact);
            return true;
        }

        public bool AddNumer(string name, string value) //Add a number to the contact
        {
            foreach (Contact c in contacts) //Check to see if COntact is inside the list
            {
                if (c.name == name)
                    c.numbers.Add(value);
            }
            return false;
        }

        public void SaveContacts()
        {
            var path = Environment.CurrentDirectory + "/Contacts.xml";  //Makes the path to SaveFile.xml
            FileStream saveFile = File.Create(path);                    //Actual creation of the path

            XmlSerializer serial = new XmlSerializer(typeof(List<Contact>));//The object that will serialize a contacts
            serial.Serialize(saveFile, contacts);                           //Serializing the Contacts.
            saveFile.Close();                                               //Close this file.
        }

        public List<Contact> ReadContacts()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Contact>));    //Object that will read the xml files.
            List<Contact> tempContacts = new List<Contact>();                   //Temp party to hold the GoodGuys

            StreamReader file = new StreamReader(Environment.CurrentDirectory + "/Contacts.xml");   //Getting this reader set to the GoodSaveFile
            ///Breaks
            tempContacts = (List<Contact>)reader.Deserialize(file);     //Taking the info from GoodSaveFile and turning it back into a Party.
            return tempContacts;
        }

        List<Contact> GetContacts()
        {
            return contacts;
        }
    }
}
