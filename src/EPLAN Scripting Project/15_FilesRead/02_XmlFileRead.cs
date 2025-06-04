using System;
using System.Windows.Forms;
using System.Xml;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _15_FilesRead_02_XmlFileRead
{
  [Start]
  public void Function()
  {
    string fileName = PathMap.SubstitutePath("$(PROJECTPATH)" + @"\" + "Projectinfo.xml");
    int id = 10043;
    string lastVersion = ReadProjectProperty(fileName, id);

    if (lastVersion != null)
    {
      MessageBox.Show("Last used EPLAN version:" + Environment.NewLine + lastVersion);
    }
    else
    {
      MessageBox.Show(
        "Property " + id + " not found.",
        "Warning",
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
              reader.Close();
              return property;
            }
          }
        }
      }
    }

    reader.Close();
    return property;
  }
}