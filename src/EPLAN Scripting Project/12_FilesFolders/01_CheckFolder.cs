using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _12_FilesFolders_01_CheckFolder
{
  [Start]
  public void Function()
  {
    string path = @"C:\test\";

    if (Directory.Exists(path))
    {
      MessageBox.Show("Folder already exists.");
    }
    else
    {
      Directory.CreateDirectory(path);
      MessageBox.Show("Folder created.");
    }
  }
}