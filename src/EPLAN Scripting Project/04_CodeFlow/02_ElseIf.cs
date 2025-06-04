using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_CodeFlow_02_ElseIf
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

    if (result == DialogResult.Yes)
    {
      MessageBox.Show("Yes");
    }
    else if (result == DialogResult.No)
    {
      MessageBox.Show("No");
    }
    else if (result == DialogResult.Cancel)
    {
      MessageBox.Show("Cancel");
    }
  }
}