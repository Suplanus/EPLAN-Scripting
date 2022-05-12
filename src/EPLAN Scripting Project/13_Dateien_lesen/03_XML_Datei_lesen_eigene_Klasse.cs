using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

public class _13_Dateien_lesen_03_XML_Datei_lesen_eigene_Klasse
{
  [Start]
  public void Function()
  {
    string xmlPath = PathMap.SubstitutePath("$(MD_XML)");
    string fileName = Path.Combine(xmlPath, "Persons.xml");

    List<Person> persons = ReadXml(fileName);
    foreach (Person person in persons)
    {
      MessageBox.Show(person.FullName);
    }
  }

  public static List<Person> ReadXml(string fileName)
  {
    XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
    StreamReader reader = new StreamReader(fileName);

    List<Person> persons = (List<Person>)serializer.Deserialize(reader);
    reader.Close();
    reader.Dispose();
    return persons;
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

    public class AddressClass
    {
      [XmlAttribute]
      public string City { get; set; }

      [XmlAttribute]
      public string Street { get; set; }
    }
  }
}