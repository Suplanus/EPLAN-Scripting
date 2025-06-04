using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _05_ActionsWithValues_02_ActionWithActionCallingContext
{
  private ActionCallingContext _acc;

  [DeclareAction("ActionWithActionCallingContext")]
  public void ReturnAction(ActionCallingContext acc)
  {
    _acc = acc;

    string firstName = GetParameterValue("firstName");

    string message = "Hello";
    if (!string.IsNullOrWhiteSpace(firstName))
    {
      message = message + " " + firstName;

      string lastName = GetParameterValue("lastName");
      if (!string.IsNullOrWhiteSpace(lastName))
      {
        message = message + " " + lastName;
      }
    }

    MessageBox.Show(message);
  }

  private string GetParameterValue(string parameterName)
  {
    string parameter = null;
    _acc.GetParameter(parameterName, ref parameter);
    return parameter;
  }
}