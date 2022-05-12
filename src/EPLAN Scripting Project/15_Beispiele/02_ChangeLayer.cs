﻿using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class _15_Beispiele_02_ChangeLayer
{
  [Start]
  public void Function()
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();

    acc.AddParameter("LAYER", "EPLAN400");
    acc.AddParameter("TEXTHEIGHT", "10");

    cli.Execute("changeLayer", acc);

    MessageBox.Show("Action ausgeführt.");
  }
}