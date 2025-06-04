using System.Windows.Forms;
using Eplan.EplApi.Scripting;
using Eplan.EplApi.Base;

public class _10_Debug_01_DebugSetting
{
  [DeclareRegister]
  public void Register()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting("USER.EplanEplApiScriptLog.DebugScripts", true, 0);

    MessageBox.Show("Debugging enabled");
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    Settings settings = new Settings();

    settings.SetBoolSetting("USER.EplanEplApiScriptLog.DebugScripts", false, 0);

    MessageBox.Show("Debugging disabled");
  }
}