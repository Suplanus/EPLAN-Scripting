using System.Windows.Forms;
using Eplan.EplApi.Scripting;

class _03_Classes_12_OwnClass
{
  [Start]
  public void Function()
  {
    Person john = new Person();
    john.FirstName = "John";
    john.LastName = "Doe";
    MessageBox.Show(john.FirstName + " " + john.LastName);

    Person jane = new Person("Jane", "Public");
    jane.DisplayFullName();
  }

  class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

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