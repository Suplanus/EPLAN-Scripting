using System;
using System.Diagnostics;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Gui;
using Eplan.EplApi.Scripting;

public class 
  _09_Externe_Programme_02_Unterschiedliche_Prozesse_ausfuehren
{
  [DeclareAction("StartProcess")]
  public void Function(string processName, string parameter)
  {
    try
    {
      parameter = PathMap.SubstitutePath(parameter);
      Process.Start(processName, parameter);
    }
    catch (Exception ex)
    {
      MessageBox.Show(
          ex.Message,
          "Fehler",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
          );
    }
  }

  private MultiLangString TAB_NAME
  {
    get
    {
      MultiLangString tabName = new MultiLangString();
      tabName.AddString(ISOCode.Language.L_de_DE, "Mein Tab");
      tabName.AddString(ISOCode.Language.L_en_US, "My Tab");
      return tabName;
    }
  }

  private const string GROUP_NAME = "Apps";

  [DeclareUnregister]
  public void UnRegister()
  {
    RibbonBar ribbonBar = new RibbonBar();
    RibbonTab ribbonTab = ribbonBar.GetTab(TAB_NAME, true);
    if (ribbonTab != null)
    {
      RibbonCommandGroup ribbonCommandGroup = 
        ribbonTab.GetCommandGroup(GROUP_NAME);
      if (ribbonCommandGroup != null)
      {
        ribbonCommandGroup.Remove();
      }
    }
  }

  [DeclareRegister]
  public void Register()
  {
    RibbonBar ribbonBar = new RibbonBar();

    RibbonTab ribbonTab = ribbonBar.GetTab(TAB_NAME, true);
    if (ribbonTab == null)
    {
      ribbonTab = ribbonBar.AddTab(TAB_NAME);
    }
    
    RibbonCommandGroup ribbonCommandGroup = 
      ribbonTab.AddCommandGroup(GROUP_NAME);

    string quote = "\"";

    ribbonCommandGroup.AddCommand("Taschenrechner",
      "StartProcess /processName:calc /parameter:''",
      new RibbonIcon(CommandIcon.Application));
    
    ribbonCommandGroup.AddCommand(
      "Projektordner öffnen",
      "StartProcess /processName:explorer /parameter:" +
      quote +"$(PROJECTPATH)" + quote,
      new RibbonIcon(CommandIcon.Application));

    ribbonCommandGroup.AddCommand("Zeichentabelle",
      "StartProcess /processName:charmap /parameter:''",
      new RibbonIcon(CommandIcon.Application));

    string pdfFile = @"C:\test\test.pdf";
    ribbonCommandGroup.AddCommand("PDF öffnen", 
      "StartProcess /processName:" + quote + pdfFile + quote +
      " /parameter:''",
      new RibbonIcon(CommandIcon.Application));
  }
}