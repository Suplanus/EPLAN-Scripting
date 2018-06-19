using System;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _05_Settings_08_Import_Projekteinstellung
{
  [DeclareAction("Verbindungsabzweigungen")]
  public void Function(int setting)
  {
    try
    {
      string scripts = PathMap.SubstitutePath("$(MD_SCRIPTS)" + @"\");
      string project = PathMap.SubstitutePath("$(P)");
      string message = string.Empty;

      CommandLineInterpreter cli = new CommandLineInterpreter();
      ActionCallingContext acc = new ActionCallingContext();
      acc.AddParameter("Project", project);

      switch (setting)
      {
        case 1:
          message = "[Mit Zielfestlegung]";
          acc.AddParameter("XmlFile", scripts + @"1.xml");
          break;

        case 2:
          message = "[Als Punkt]";
          acc.AddParameter("XmlFile", scripts + @"2.xml");
          break;

        case 3:
          message = "[Wie gezeichnet]";
          acc.AddParameter("XmlFile", scripts + @"3.xml");
          break;

        default:
          MessageBox.Show("Parameter nicht bekannt",
              "Fehler", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
          return;
      }

      cli.Execute("XSettingsImport", acc);

      MessageBox.Show("Einstellungen wurden importiert." + Environment.NewLine +
                      message,
        "Information",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

    }
    catch (Exception ex)
    {
      MessageBox.Show(ex.Message, "Fehler",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
    }

    return;
  }
}