using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_02_ElseIf
{
  [Start]
  public void Function()
  {
    DialogResult result = MessageBox.Show(
        "Soll die Aktion ausgeführt werden?",
        "Titelzeile",
        MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question
        );

    if (result == DialogResult.Yes)
    {
      MessageBox.Show("Es wurde 'Ja' gedrückt.");
    }
    else if (result == DialogResult.No)
    {
      MessageBox.Show("Es wurde 'Nein' gedrückt.");
    }
    else if (result == DialogResult.Cancel)
    {
      MessageBox.Show("Es wurde 'Abbrechen' gedrückt.");
    }

    return;
  }
}