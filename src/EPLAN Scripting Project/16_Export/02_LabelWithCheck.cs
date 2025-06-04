using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _16_Export_02_LabelWithCheck
{
  [Start]
  public void Function()
  {
    string fileName;

    fileName = GetFileName(@"$(DOC)\BOM.xlsx");
    if (fileName != null)
    {
      ActionCallingContext context1 = new ActionCallingContext();
      context1.AddParameter("configscheme", "Summarized parts list");
      context1.AddParameter("filterscheme", "");
      context1.AddParameter("sortscheme", "");
      context1.AddParameter("language", "de_DE");
      context1.AddParameter("destinationfile", fileName);
      context1.AddParameter("recrepeat", "1");
      context1.AddParameter("taskrepeat", "1");
      context1.AddParameter("showoutput", "1");
      context1.AddParameter("type", "PROJECT");
      new CommandLineInterpreter().Execute("label", context1);
    }

    fileName = GetFileName(@"$(DOC)\Device-List.xlsx");
    if (fileName != null)
    {
      ActionCallingContext context2 = new ActionCallingContext();
      context2.AddParameter("configscheme", "Device tag list");
      context2.AddParameter("filterscheme", "");
      context2.AddParameter("sortscheme", "");
      context2.AddParameter("language", "de_DE");
      context2.AddParameter("destinationfile", fileName);
      context2.AddParameter("recrepeat", "1");
      context2.AddParameter("taskrepeat", "1");
      context2.AddParameter("showoutput", "1");
      context2.AddParameter("type", "PROJECT");
      new CommandLineInterpreter().Execute("label", context2);
    }
  }

  private static string GetFileName(string fileName)
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");
    string fullFileName = PathMap.SubstitutePath(fileName);

    if (File.Exists(fullFileName))
    {
      DialogResult dialogResult = MessageBox.Show(
        "The file already exists: '" +
        fullFileName +
        Environment.NewLine +
        Environment.NewLine +
        "Do you want to override it?",
        "Label",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
      );

      if (dialogResult == DialogResult.No)
      {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.DefaultExt = "xlsx";
        sfd.FileName = fileName;
        sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
        sfd.InitialDirectory = projectPath;
        sfd.Title = "Choose location for " + fileName + " :";
        sfd.ValidateNames = true;

        DialogResult sfdDialogResult = sfd.ShowDialog();
        if (sfdDialogResult == DialogResult.OK)
        {
          fullFileName = sfd.FileName;
        }
        else if (sfdDialogResult == DialogResult.Cancel)
        {
          fullFileName = null;
        }
      }
    }
    return fullFileName;
  }
}