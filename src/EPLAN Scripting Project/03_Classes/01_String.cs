using System;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _03_Classes_01_String
{
  [Start]
  public void Function()
  {
    MessageBox.Show("I am a text (but actually a string)!");

    string message1 = string.Empty;
    message1 = "I am a string with\nline break!";
    MessageBox.Show(message1);
    MessageBox.Show("Me" + Environment.NewLine + "too!");

    string message2 = "I am also a string!";
    MessageBox.Show(message2);
    message2 = "You can also give me a new text!";
    MessageBox.Show(message2);

    string message3_1 = "And I ";
    string message3_2 = "am one ";
    string message3_3 = "too!";
    MessageBox.Show(message3_1 + message3_2 + message3_3);

    MessageBox.Show("Line break in code " +
                    "is not displayed!");

    string message4 = "The {0} is in the {1}.";
    string message4_1 = string.Format(message4, "comb", "cabinet");
    string message4_2 = string.Format(message4, "cabinet", "bathroom");
    MessageBox.Show(message4_1);
    MessageBox.Show(message4_2);
  }
}