using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_03_Switch
{
  [Start]
  public void Function()
  {
    DialogResult result = MessageBox.Show(
      "Should the action be executed?",
      "Title",
      MessageBoxButtons.YesNoCancel,
      MessageBoxIcon.Question
    );

    switch (result)
    {
      case DialogResult.Yes:
        MessageBox.Show("Yes");
        break;

      case DialogResult.No:
        goto default;

      default:
        MessageBox.Show("No or cancel");
        break;
    }
  }
}