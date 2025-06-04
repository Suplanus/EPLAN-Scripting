using System.Collections.Specialized;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_09_ListSelectDecisionContext
{
  [Start]
  public void Function()
  {
    string title = "Will the story end?";
    string redPill = "Red pill";
    string bluePill = "Blue pill";
    
    StringCollection entries = new StringCollection();
    entries.Add(redPill);
    entries.Add(bluePill);
    
    ListSelectDecisionContext listSelectDecision = new ListSelectDecisionContext(entries, redPill, title);
    listSelectDecision.AllowMultiSelect = false;
    
    var result = new Decider().Decide(listSelectDecision);
    if (result == EnumDecisionReturn.eOK)
    {
      MessageBox.Show(listSelectDecision.SelectedEntry);
    }
  }
}