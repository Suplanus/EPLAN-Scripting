using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_07_MethodOverloading
{
  [Start]
  public void Function()
  {
    string message = string.Empty;

    message = DoSomething("Bananas");

    MessageBox.Show(message,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

    message = DoSomething("Bananas", "3");

    MessageBox.Show(message,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
  }

  /// <summary>
  /// Gibt einen Wert zurück, der den Satz enthält:
  /// "Ich habe gerade [food] gegessen!"
  /// </summary>
  /// <param name="food">Nahrungsmittel</param>
  private static string DoSomething(string food)
  {
    string fullMessage = "I have just eaten " + food + "!";

    return fullMessage;
  }

  /// <summary>
  /// Gibt einen Wert zurück, der den Satz enthält:
  /// "Ich habe gerade [amount] [food] gegessen!"
  /// </summary>
  /// <param name="food">Nahrungsmittel</param>
  /// <param name="amount">Menge</param>
  private static string DoSomething(string food, string amount)
  {
    return "I have just eaten " + amount + " " + food + "!";
  }
}