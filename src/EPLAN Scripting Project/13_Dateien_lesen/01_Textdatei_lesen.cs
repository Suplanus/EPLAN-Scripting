using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _13_Dateien_lesen_01_Textdatei_lesen
{
  [Start]
  public void Function()
  {
    string fileName = PathMap.SubstitutePath(@"$(TMP)\Last_Version.txt");

    LabellingText(fileName);

    string lastVersion = ReadLine(fileName, 0);

    MessageBox.Show(
        "Zuletzt verwendete EPLAN-Version:" + Environment.NewLine +
        lastVersion,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
        );

    File.Delete(fileName);
  }

  public string ReadLine(string fileName, int line)
  {
    string[] lines = File.ReadAllLines(fileName, Encoding.Unicode);
    string text = lines[line];
    return text;
  }

  private static void LabellingText(string fileName)
  {
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("CONFIGSCHEME", 
      "Zuletzt verwendete EPLAN-Version_Textdatei");
    acc.AddParameter("DESTINATIONFILE", fileName);
    acc.AddParameter("FILTERSCHEME", "");
    acc.AddParameter("LANGUAGE", "de_DE");
    acc.AddParameter("LogMsgActionDone", "true");
    acc.AddParameter("SHOWOUTPUT", "0");
    acc.AddParameter("RECREPEAT", "1");
    acc.AddParameter("SORTSCHEME", "");
    acc.AddParameter("TASKREPEAT", "1");
    new CommandLineInterpreter().Execute("label", acc);
  }
}