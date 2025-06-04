using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _14_FilesWrite_01_TextFileWrite
{
  [Start]
  public void Function()
  {
    string fileName = PathMap.SubstitutePath(@"$(PROJECTPATH)\Test-file.txt");

    StringBuilder sb = new StringBuilder();
    sb.Append("Example");
    sb.Append(" text");
    sb.AppendLine();
    sb.Append("with multiple lines");

    File.WriteAllText(fileName, sb.ToString(), Encoding.Unicode);

    MessageBox.Show(
        "Text file exported successfully.",
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
        );

    Process.Start(fileName);
  }
}