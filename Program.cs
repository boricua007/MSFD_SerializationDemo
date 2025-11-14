using System.Formats.Asn1;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

public class Project {
    public class Person
    {
        public string UserName {get; set;}
        public int UserAge {get; set;}
    }

    static void Main()
    {
        Person samplePerson = new Person {
            UserName = "Alice",
            UserAge = 30
        };

        // Binary Serialization
        using(FileStream fs = new FileStream("person.dat", FileMode.Create))
        {
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(samplePerson.UserName);
            bw.Write(samplePerson.UserAge);
        }

        Console.WriteLine("Binary serilization complete.");


        // XML Serialization
        XmlSerializer xs = new XmlSerializer(typeof(Person));

        using (StreamWriter sw = new StreamWriter("person.xml"))
        {
            xs.Serialize(sw, samplePerson);
        }

        Console.WriteLine("XML serializatoin file saved.");


        // JSON Serialization
        string jsonString = JsonSerializer.Serialize(samplePerson);
        File.WriteAllText("person.json", jsonString);

        Console.WriteLine("JSON serilaization complete.");

    }
}