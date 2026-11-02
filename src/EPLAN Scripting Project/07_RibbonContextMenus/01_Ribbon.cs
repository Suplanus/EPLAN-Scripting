using System.Diagnostics;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Gui;
using Eplan.EplApi.Scripting;

class _07_RibbonContextMenus_01_Ribbon
{
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
    
    ribbonIcon2.IsLarge = true;

    // Dropdown-Button
    var rootDropDown = new RibbonCommandInfo("Dropdown-Button", "")
    {
      IsDropdownRoot = true,
      IsSplitButton = false,
      Icon = ribbonIcon2
    };
    var rootCommandDropDown = ribbonCommandGroup2.AddCommand(rootDropDown);
    var subDropDown1 = new RibbonCommandInfo("Sub-Button 1", ACTION_NAME_SUB1);
    rootCommandDropDown.AddSubCommand(subDropDown1);
    var subDropDown2 = new RibbonCommandInfo("Sub-Button 2", ACTION_NAME_SUB2);
    rootCommandDropDown.AddSubCommand(subDropDown2);

    // Split-Button
    var rootDropSplit = new RibbonCommandInfo("Split-Button", ACTION_NAME_SPLIT)
    {
      IsDropdownRoot = true,
      IsSplitButton = true,
      Icon = ribbonIcon2
    };
    var rootCommandSplit = ribbonCommandGroup2.AddCommand(rootDropSplit);
    var subSplit1 = new RibbonCommandInfo("Sub-Button 1", ACTION_NAME_SUB1);
    rootCommandSplit.AddSubCommand(subSplit1);
    var subSplit2 = new RibbonCommandInfo("Sub-Button 2", ACTION_NAME_SUB2);
    rootCommandSplit.AddSubCommand(subSplit2);
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

  private const string ACTION_NAME = "RibbonAction";
  [DeclareAction(ACTION_NAME)]
  public void Function()
  {
    MessageBox.Show("Action was executed!");
  }
  
  private const string ACTION_NAME_SPLIT = "SplitAction";
  [DeclareAction(ACTION_NAME_SPLIT)]
  public void FunctionSplit()
  {
    MessageBox.Show("SplitAction was executed!");
  }
  
   private const string ACTION_NAME_SUB1 = "SubAction1";
   [DeclareAction(ACTION_NAME_SUB1)]
   public void FunctionSub1()
   {
     MessageBox.Show("SubAction1 was executed!");
   }
   
   private const string ACTION_NAME_SUB2 = "SubAction2";
   [DeclareAction(ACTION_NAME_SUB2)]
   public void FunctionSub2()
   {
     MessageBox.Show("SubAction2 was executed!");
   }

}