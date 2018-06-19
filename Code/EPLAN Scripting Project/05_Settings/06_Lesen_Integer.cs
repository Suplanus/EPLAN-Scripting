using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_06_Lesen_Integer
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    int minColWidth = settings.GetNumericSetting(
    "USER.MF.PREVIEW.MINCOLWIDTH", 0);

    MessageBox.Show("Mindestbreite der Kacheln in der Vorschau: "
        + minColWidth.ToString());

    return;
  }
}