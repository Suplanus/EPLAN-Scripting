using System;
using System.Windows.Forms;
using System.Xml;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _13_Dateien_lesen_02_XML_Datei_lesen
{
  [Start]
  public void Function()
  {
    string fileName = PathMap.SubstitutePath("$(PROJECTPATH)" + @"\"
                                              + "Projectinfo.xml");
    int id = 10043;
    string lastVersion = ReadProjectProperty(fileName, id);

    if (lastVersion != null)
    {
      MessageBox.Show(
          "Zuletzt verwendete EPLAN-Version:" + Environment.NewLine +
          lastVersion,
          "Information",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information
          );
    }
    else
    {
      MessageBox.Show(
        "Eigenschaft " + id + " nicht gefunden.",
        "Warnung",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
      );
    }
  }

  private static string ReadProjectProperty(string fileName, int id)
  {
    string property = null;

    XmlTextReader reader = new XmlTextReader(fileName);

    while (reader.Read())
    {
      if (reader.HasAttributes)
      {
        while (reader.MoveToNextAttribute())
        {
          if (reader.Name == "id")
          {
            if (reader.Value == id.ToString())
            {
              property = reader.ReadString();
            }
          }
        }
      }
    }

    reader.Close();
    return property;
  }
}