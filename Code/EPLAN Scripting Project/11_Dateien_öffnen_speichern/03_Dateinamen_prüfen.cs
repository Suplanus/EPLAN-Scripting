using System;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _11_Dateien_oeffnen_speichern_Dateinamen_pruefen
{
  [Start]
  public void Function()
  {
    string invalidChars = @"[\\/:*?""<>|]";

    MessageBox.Show("Diese Zeichen werden umgewandelt:" + Environment.NewLine +
        invalidChars,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

    invalidChars = AdjustPath(invalidChars);

    MessageBox.Show(invalidChars,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

    return;
  }

  private string AdjustPath(string input)
  {
    return System.Text.RegularExpressions.Regex.Replace(input,
      @"[\\/:*?""<>|]", "-");
  }
}