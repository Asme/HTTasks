using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;


namespace HT_task_1
{
    public class Participant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Task1
    {
        private Participant participant;

        public void SerialiseJson()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory());
            
            if (File.Exists(path + "\\Participant.json"))
            {
                using (StreamReader readFile = File.OpenText(path + "\\Participant.json"))                                               // starts the process to read the file
                {
                    JsonSerializer deserialiser = new JsonSerializer();

                    participant = (Participant)deserialiser.Deserialize(readFile, typeof(Participant));                                 // Deserialises the json file into object data

                    participant.FirstName = "Asbjørn";
                    participant.LastName = "Løvlie Meyer";
                }
            }
            else
            {
                Console.WriteLine("Folder does not contain the file specified");
            }
            
            using (StreamWriter writeFile = File.CreateText(path + "\\Participant.json"))                                               // starts the process to write to file
            {
                JsonSerializer serialiser = new JsonSerializer();

                serialiser.Serialize(writeFile, participant);                                                                            // serialises the "participant" object to json
            }
        }
    }
        
}
