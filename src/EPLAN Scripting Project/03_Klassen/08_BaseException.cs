﻿using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _03_Klassen_08_BaseException
{
  [Start]
  public void Function()
  {
    BaseException bexAssert =
      new BaseException("Assert", MessageLevel.Assert);
    bexAssert.FixMessage();

    BaseException bexError =
      new BaseException("Error", MessageLevel.Error);
    bexError.FixMessage();

    BaseException bexFatalError =
      new BaseException("FatalError", MessageLevel.FatalError);                      
    bexFatalError.FixMessage();

    BaseException bexMessage =
      new BaseException("Message", MessageLevel.Message);
    bexMessage.FixMessage();

    BaseException bexTrace =
      new BaseException("Trace", MessageLevel.Trace);
    bexTrace.FixMessage();

    BaseException bexWarning =
      new BaseException("Warning", MessageLevel.Warning);
    bexWarning.FixMessage();

    CommandLineInterpreter cli = new CommandLineInterpreter();
    cli.Execute("SystemErrDialog");
  }
}