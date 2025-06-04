using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _99_AdditionalExamples_04_ExecuteScript
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("ScriptFile", @"C:\Test\01_Start.cs");

    cli.Execute("ExecuteScript", acc);
  }
}