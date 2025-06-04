using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _12_FilesFolders_04_FileWithDateTimeStamp
{
  [Start]
  public void Function()
  {
    string date = DateTime.Now.ToString("yyyy-MM-dd");
    string time = DateTime.Now.ToString("HH-mm-ss");
    string fileName = @"C:\test\test_" + date + "_" + time + ".txt";

    FileStream fileStream = File.Create(fileName);
    fileStream.Dispose();
    MessageBox.Show("File created.");
  }
}