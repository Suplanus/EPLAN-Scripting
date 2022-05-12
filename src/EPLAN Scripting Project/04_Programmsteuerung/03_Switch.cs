using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_03_Switch
{
  [Start]
  public void Function()
  {
    DialogResult result = MessageBox.Show(
        "Soll die Aktion ausgeführt werden?",
        "Titelzeile",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);

    switch (result)
    {
      case DialogResult.Yes:
        MessageBox.Show("Es wurde 'Ja' gedrückt.");
        break;

      case DialogResult.No:
        goto default;

      default:
        MessageBox.Show("Es wurde 'Nein' oder"
        + "'Abbrechen' gedrückt.");
        break;
    }
  }
}