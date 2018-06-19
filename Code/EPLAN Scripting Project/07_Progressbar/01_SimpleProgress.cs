using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Threading;

public class _07_Progressbar_01_SimpleProgress
{
  [Start]
  public void Function()
  {
    Progress progress = new Progress("SimpleProgress");
    progress.SetAllowCancel(true);
    progress.SetAskOnCancel(true);
    progress.SetNeededSteps(3);
    progress.SetTitle("Meine Progressbar");
    progress.ShowImmediately();

    try
    {
      if (!progress.Canceled())
      {
        progress.SetActionText("Step 1");
        progress.SetTitle("Titelzeile 1");
        progress.Step(1);

        Thread.Sleep(1000);
      }

      if (!progress.Canceled())
      {
        progress.SetActionText("Step 2");
        progress.SetTitle("Titelzeile 2");
        progress.Step(1);

        Thread.Sleep(1000);
      }

      if (!progress.Canceled())
      {
        progress.SetActionText("Step 3");
        progress.SetTitle("Titelzeile 3");
        progress.Step(1);

        Thread.Sleep(1000);
      }
    }
    finally
    {
      progress.EndPart(true);
    }

    return;
  }
}