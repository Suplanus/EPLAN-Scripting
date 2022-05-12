using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _12_Dateien_schreiben_04_Textdatei_schreiben
{
  [Start]
  public void Function()
  {
    string fileName = 
      PathMap.SubstitutePath(@"$(PROJECTPATH)\Testdatei.txt");

    StringBuilder sb = new StringBuilder();
    sb.Append("Beispiel");
    sb.Append("text");
    sb.AppendLine();
    sb.Append("mit mehreren Zeilen");

    File.WriteAllText(fileName, sb.ToString(), Encoding.Unicode);

    MessageBox.Show(
        "Textdatei erfolgreich exportiert.",
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
        );

    Process.Start(fileName);
  }
}