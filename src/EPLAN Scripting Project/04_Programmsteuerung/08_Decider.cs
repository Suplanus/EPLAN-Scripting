using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_08_Decider
{
  [Start]
  public void Function()
  {
    // OK
    Decider deciderOk = new Decider();
    deciderOk.Decide(
      EnumDecisionType.eOkDecision,
      "Ich sag mal OK!",
      "Decider",
      EnumDecisionReturn.eOK,
      EnumDecisionReturn.eOK);

    // YesNo
    Decider deciderYesNo = new Decider();
    EnumDecisionReturn decisionYesNo = deciderYesNo.Decide(
      EnumDecisionType.eYesNoDecision,
      "Ja oder Nein?",
      "Decider",
      EnumDecisionReturn.eYES,
      EnumDecisionReturn.eYES);

    switch (decisionYesNo)
    {
      case EnumDecisionReturn.eYES:
        MessageBox.Show("Ja");
        break;

      case EnumDecisionReturn.eNO:
        MessageBox.Show("Nein");
        break;
    }

    // YesNoAll
    Decider deciderYesNoAll = new Decider();
    EnumDecisionReturn decisionYesNoAll = deciderYesNoAll.Decide(
      EnumDecisionType.eYesAllNoAllDecision,
      "Ja oder Nein für alle?",
      "Decider",
      EnumDecisionReturn.eYES,
      EnumDecisionReturn.eYES);

    switch (decisionYesNoAll)
    {
      case EnumDecisionReturn.eYES:
        MessageBox.Show("Ja");
        break;

      case EnumDecisionReturn.eNO:
        MessageBox.Show("Nein");
        break;

      case EnumDecisionReturn.eYES_ALL:
        MessageBox.Show("Ja für alle");
        break;

      case EnumDecisionReturn.eNO_ALL:
        MessageBox.Show("Nein für alle");
        break;
    }

    // Icon and CheckBox
    Decider deciderIconAndCheckBox = new Decider();
    EnumDecisionReturn decisionIconAndCheckBox =
      deciderIconAndCheckBox.Decide(
        EnumDecisionType.eRetryCancelDecision,
        "Icon und CheckBox. Toll, oder?",
        "Decider",
        EnumDecisionReturn.eRETRY,
        EnumDecisionReturn.eRETRY,
        "DecisionIconAndCheckBox",
        true,
        EnumDecisionIcon.eQUESTION);

    if (decisionIconAndCheckBox == EnumDecisionReturn.eRETRY)
    {
      MessageBox.Show("Einmal reicht...");
    }
  }
}