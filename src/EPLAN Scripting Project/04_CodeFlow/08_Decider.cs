using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_08_Decider
{
  [Start]
  public void Function()
  {
    // OK
    Decider deciderOk = new Decider();
    deciderOk.Decide(
      EnumDecisionType.eOkDecision,
      "I say OK!",
      "Decider",
      EnumDecisionReturn.eOK,
      EnumDecisionReturn.eOK);

    // YesNo
    Decider deciderYesNo = new Decider();
    EnumDecisionReturn decisionYesNo = deciderYesNo.Decide(
      EnumDecisionType.eYesNoDecision,
      "Yes or no?",
      "Decider",
      EnumDecisionReturn.eYES,
      EnumDecisionReturn.eYES);

    switch (decisionYesNo)
    {
      case EnumDecisionReturn.eYES:
        MessageBox.Show("Yes");
        break;

      case EnumDecisionReturn.eNO:
        MessageBox.Show("No");
        break;
    }

    // YesNoAll
    Decider deciderYesNoAll = new Decider();
    EnumDecisionReturn decisionYesNoAll = deciderYesNoAll.Decide(
      EnumDecisionType.eYesAllNoAllDecision,
      "Yes or no for all?",
      "Decider",
      EnumDecisionReturn.eYES,
      EnumDecisionReturn.eYES);

    switch (decisionYesNoAll)
    {
      case EnumDecisionReturn.eYES:
        MessageBox.Show("Yes");
        break;

      case EnumDecisionReturn.eNO:
        MessageBox.Show("No");
        break;

      case EnumDecisionReturn.eYES_ALL:
        MessageBox.Show("Yes for all");
        break;

      case EnumDecisionReturn.eNO_ALL:
        MessageBox.Show("No for all");
        break;
    }

    // Icon and CheckBox
    Decider deciderIconAndCheckBox = new Decider();
    EnumDecisionReturn decisionIconAndCheckBox =
      deciderIconAndCheckBox.Decide(
        EnumDecisionType.eRetryCancelDecision,
        "Icon and CheckBox. Great, isn't it?",
        "Decider",
        EnumDecisionReturn.eRETRY,
        EnumDecisionReturn.eRETRY,
        "DecisionIconAndCheckBox",
        true,
        EnumDecisionIcon.eQUESTION);

    if (decisionIconAndCheckBox == EnumDecisionReturn.eRETRY)
    {
      MessageBox.Show("Once is enough...");
    }
  }
}