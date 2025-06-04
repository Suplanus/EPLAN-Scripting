using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Gui;
using Eplan.EplApi.Scripting;

class _07_RibbonContextMenus_01_Ribbon
{
  private const string ACTION_NAME = "RibbonAction";

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

  [DeclareRegister]
  public void Register()
  {
    RibbonBar ribbonBar = new RibbonBar();
    RibbonTab ribbonTab = ribbonBar.GetTab(TAB_NAME, true);
    if (ribbonTab == null)
    {
      ribbonTab = ribbonBar.AddTab(TAB_NAME);
    }

    // Simple
    RibbonCommandGroup ribbonCommandGroup1 = ribbonTab.AddCommandGroup("My group 1");
    RibbonIcon ribbonIcon1 = new RibbonIcon(CommandIcon.Accumulator);
    ribbonCommandGroup1.AddCommand("My action 1", ACTION_NAME, ribbonIcon1);

    // Extended
    MultiLangString groupText = new MultiLangString();
    groupText.AddString(ISOCode.Language.L_de_DE, "Meine Gruppe 2");
    groupText.AddString(ISOCode.Language.L_en_US, "My group 2");
    RibbonCommandGroup ribbonCommandGroup2 = ribbonTab.AddCommandGroup(groupText);

    MultiLangString commandText = new MultiLangString();
    commandText.AddString(ISOCode.Language.L_de_DE, "Meine Aktion 2");
    commandText.AddString(ISOCode.Language.L_en_US, "My action 2");

    MultiLangString tooltip = new MultiLangString();
    tooltip.AddString(ISOCode.Language.L_de_DE, "Mein ToolTip");
    tooltip.AddString(ISOCode.Language.L_en_US, "My tooltip");

    MultiLangString description = new MultiLangString();
    description.AddString(ISOCode.Language.L_de_DE, "Meine Beschreibung");
    description.AddString(ISOCode.Language.L_en_US, "My description");

    string imagePath = @"C:\test\test.svg";
    RibbonIcon ribbonIcon2 = ribbonBar.AddIcon(imagePath);
    ribbonCommandGroup2.AddCommand(commandText, ACTION_NAME, tooltip, description, ribbonIcon2);
  }

  [DeclareUnregister]
  public void UnRegister()
  {
    RibbonBar ribbonBar = new RibbonBar();
    RibbonTab ribbonTab = ribbonBar.GetTab(TAB_NAME, true);
    if (ribbonTab != null)
    {
      ribbonTab.Remove();
    }
  }

  [DeclareAction(ACTION_NAME)]
  public void Function()
  {
    MessageBox.Show("Action was executed!");
  }
}