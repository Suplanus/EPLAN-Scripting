using System;
using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _13_FilesOpenSave_03_CheckFilenames
{
  [Start]
  public void Function()
  {
    string invalidChars = @"[\\/:*?""<>|]";

    MessageBox.Show("These characters are converted:" + 
      Environment.NewLine + invalidChars,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

    invalidChars = AdjustPath(invalidChars);

    MessageBox.Show(invalidChars,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
  }

  private string AdjustPath(string input)
  {
    return System.Text.RegularExpressions.Regex.Replace(input, @"[\\/:*?""<>|]", "-");
  }
}