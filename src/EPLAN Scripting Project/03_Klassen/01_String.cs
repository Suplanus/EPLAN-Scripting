using System;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Klassen_01_String
{
  [Start]
  public void Function()
  {
    MessageBox.Show("Ich bin ein Text (aber eigentlich ein String)!");

    string message1 = string.Empty;
    message1 = "Ich bin ein String mit\nZeilenumbruch!";
    MessageBox.Show(message1);
    MessageBox.Show("Ich" + Environment.NewLine + "auch!");

    string message2 = "Ich bin auch ein String!";
    MessageBox.Show(message2);
    message2 = "Mir kann man auch einen neuen Text übergeben!";
    MessageBox.Show(message2);

    string message3_1 = "Und ich ";
    string message3_2 = "bin auch ";
    string message3_3 = "einer!";
    MessageBox.Show(message3_1 + message3_2 + message3_3);

    MessageBox.Show("Zeilenumbruch im Code "
                    + "wird nicht angezeigt!");

    string message4 = "Der {0} ist im {1}.";
    string message4_1 = string.Format(message4, "Kamm", "Schrank");
    string message4_2 = string.Format(message4, "Schrank", "Badezimmer");
    MessageBox.Show(message4_1);
    MessageBox.Show(message4_2);
  }
}