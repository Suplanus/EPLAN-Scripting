using System;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _13_FilesOpenSave_02_OpenFileDialog
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string fileName = "Test-file";

    OpenFileDialog ofd = new OpenFileDialog();
    ofd.DefaultExt = "txt";
    ofd.FileName = fileName;
    ofd.Filter = "Test-File (*Test-File*.txt)|*Test-File*.txt|All files (*.*)|*.*";
    ofd.InitialDirectory = projectPath;
    ofd.Title = "Choose Test-File:";
    ofd.ValidateNames = true;

    if (ofd.ShowDialog() == DialogResult.OK)
    {
      fileName = ofd.FileName;
      MessageBox.Show(
        "The storage location was successfully transferred:" +
        Environment.NewLine +
        fileName,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
      );
    }
  }
}