using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;
using System.Threading;

public class _08_Progressbar_01_SimpleProgress
{
  [Start]
  public void Function()
  {
    Progress progress = new Progress("SimpleProgress");
    progress.SetAllowCancel(true);
    progress.SetAskOnCancel(true);
    progress.SetNeededSteps(3);
    progress.SetTitle("My progress");
    progress.ShowImmediately();

    try
    {
      if (!progress.Canceled())
      {
        progress.SetActionText("Step 1");
        progress.SetTitle("Title 1");
        progress.Step(1);

        Thread.Sleep(1000);
      }

      if (!progress.Canceled())
      {
        progress.SetActionText("Step 2");
        progress.SetTitle("Title 2");
        progress.Step(1);

        Thread.Sleep(1000);
      }

      if (!progress.Canceled())
      {
        progress.SetActionText("Step 3");
        progress.SetTitle("Title 3");
        progress.Step(1);

        Thread.Sleep(1000);
      }
    }
    finally
    {
      progress.EndPart(true);
    }
  }
}