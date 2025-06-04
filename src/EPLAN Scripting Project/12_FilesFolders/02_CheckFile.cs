using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _12_FilesFolders_02_CheckFile
{
  [Start]
  public void Function()
  {
    string fileName = @"C:\test\test.txt";

    if (File.Exists(fileName))
    {
      MessageBox.Show("File already exists.");
    }
    else
    {
      FileStream fileStream = File.Create(fileName);
      fileStream.Dispose();
      MessageBox.Show("File created.");
    }
  }
}