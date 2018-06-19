using System.Windows.Forms;
using Eplan.EplApi.Scripting;

class _03_Klassen_13_Eigene_Klasse
{
  [Start]
  public void Function()
  {
    Person max = new Person();
    max.FirstName = "Max";
    max.LastName = "Mustermann";
    MessageBox.Show(max.FirstName + " " + max.LastName);

    Person maria = new Person("Maria", "Musterfrau");
    maria.DisplayFullName();
  }

  class Person
  {
    public string FirstName { get; internal set; }
    public string LastName { get; internal set; }

    public string FullName
    {
      get { return FirstName + " " + LastName; }
    }

    public Person()
    {
    }

    public Person(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }

    public void DisplayFullName()
    {
      MessageBox.Show(FullName);
    }
  }
}