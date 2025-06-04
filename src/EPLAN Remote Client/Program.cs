using Eplan.EplApi.RemoteClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EPLAN_Remote_Client
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<EplanServerData> instancesActive = GetInstances();
      if (instancesActive.Any())
      {
        Console.WriteLine("Start active instance...");
        EplanServerData eplanInstanceActive = instancesActive.OrderBy(obj => obj.EplanVersion).Last();

        Execute(eplanInstanceActive);
      }
      else
      {
        Console.WriteLine("No active instance found.");
      }

      Console.WriteLine("Execution completed.");
      Console.ReadKey();
    }
    
    public static List<EplanServerData> GetInstances()
    {
      EplanRemoteClient eplanRemoteClient = new EplanRemoteClient();
      List<EplanServerData> eplanServerDatas = new List<EplanServerData>();
      eplanRemoteClient.GetActiveEplanServersOnLocalMachine(out eplanServerDatas);
      return eplanServerDatas;
    }

    private static void Execute(EplanServerData eplanServerData)
    {
      EplanRemoteClient eplanRemoteClient = new EplanRemoteClient();
      eplanRemoteClient.SynchronousMode = true;
      eplanRemoteClient.Connect("localhost", eplanServerData.ServerPort.ToString(), new TimeSpan(0, 0, 0, 5));

      eplanRemoteClient.ExecuteAction("ActionName");
      eplanRemoteClient.Disconnect();
      eplanRemoteClient.Dispose();
    }
  }
}