using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_01_IF_String
{
  [DeclareAction("IfString")]
  public void Function(string parameter)
  {
    if (parameter == "JA")
    {
      MessageBox.Show("Bedingung erfüllt.");
    }
    else
    {
      MessageBox.Show("Bedingung nicht erfüllt.");
    }

    if (parameter.ToUpper() == "JA")
    {
      MessageBox.Show("Bedingung erfüllt.");
    }
    else
    {
      MessageBox.Show("Bedingung nicht erfüllt.");
    }

    return;
  }
}