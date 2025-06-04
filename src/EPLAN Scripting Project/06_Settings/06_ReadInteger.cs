using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _05_Settings_06_ReadInteger
{
  [Start]
  public void Function()
  {
    Settings settings = new Settings();

    int minColWidth = settings.GetNumericSetting("USER.MF.PREVIEW.MINCOLWIDTH", 0);

    MessageBox.Show("Minimum width of the tiles in the preview: "
        + minColWidth.ToString());
  }
}