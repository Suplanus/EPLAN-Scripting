using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

public class _14_FilesWrite_02_XmlWrite
{
  [Start]
  public void Function()
  {
    List<Person> persons = new List<Person>();

    Person max = new Person("John", "Doe", "Munich", "Marienplatz 1");
    persons.Add(max);

    Person maria = new Person("Jane", "Public", "Nuremberg", "Zeppelinfeld 2");
    persons.Add(maria);

    string xmlPath = PathMap.SubstitutePath("$(MD_XML)");
    string fileName = Path.Combine(xmlPath, "Persons.xml");

    WriteXml(persons, fileName);
    MessageBox.Show("XML-file created");
  }

  public static void WriteXml(List<Person> persons, string fileName)
  {
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();

    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    settings.Encoding = Encoding.UTF8;
    XmlWriter writer = XmlWriter.Create(fileName, settings);

    serializer.Serialize(writer, persons, namespaces);
    writer.Close();
    writer.Dispose();
  }

  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AddressClass Address { get; set; }

    public string FullName
    {
      get { return FirstName + " " + LastName; }
    }

    public Person()
    {
    }

    public Person(string firstName, string lastName,
      string city, string street)
    {
      FirstName = firstName;
      LastName = lastName;

      Address = new AddressClass();
      Address.City = city;
      Address.Street = street;
    }

    public class AddressClass
    {
      [XmlAttribute]
      public string City { get; set; }

      [XmlAttribute]
      public string Street { get; set; }
    }
  }
}