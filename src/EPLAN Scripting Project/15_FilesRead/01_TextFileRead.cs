using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _15_FilesRead_01_TextFileRead
{
  [Start]
  public void Function()
  {
    string fileName = PathMap.SubstitutePath(@"$(PROJECTPATH)\Test-file.txt");

    string[] lines = File.ReadAllLines(fileName, Encoding.Unicode);

    MessageBox.Show(lines[0]);
  }
}