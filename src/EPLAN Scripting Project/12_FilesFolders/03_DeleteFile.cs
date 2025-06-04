using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _12_FilesFolders_03_DeleteFile
{
  [Start]
  public void Function()
  {
    string fileName = @"C:\test\test.txt";

    if (File.Exists(fileName))
    {
      File.Delete(fileName);
      MessageBox.Show("File deleted.");
    }
  }
}