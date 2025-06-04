using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _13_FilesOpenSave_01_SaveFileDialog
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string fileName = "Test-file";

    SaveFileDialog sfd = new SaveFileDialog();
    sfd.DefaultExt = "txt";
    sfd.FileName = fileName;
    sfd.Filter = "Text files (*.txt)|*.txt";
    sfd.InitialDirectory = projectPath;
    sfd.Title = "Select storage location for test file:";
    sfd.ValidateNames = true;

    if (sfd.ShowDialog() == DialogResult.OK)
    {
      FileStream fileStream = File.Create(sfd.FileName);
      fileStream.Dispose();
      MessageBox.Show(
        "File was saved successfully:" + Environment.NewLine +
        sfd.FileName,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }
  }
}