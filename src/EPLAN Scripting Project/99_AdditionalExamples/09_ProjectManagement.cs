﻿using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _99_AdditionalExamples_09_ProjectManagement
{
  [Start]
  public void Function()
  {
    string projectsPath = PathMap.SubstitutePath("$(MD_PROJECTS)");

    OpenFileDialog ofd = new OpenFileDialog();
    ofd.Filter = "ProjectInfo.xml|ProjectInfo.xml";
    ofd.InitialDirectory = projectsPath;
    ofd.Title = "Choose project properties file:";
    ofd.ValidateNames = false;

    if (ofd.ShowDialog() == DialogResult.OK)
    {
      Progress progress = new Progress("SimpleProgress");
      progress.SetAllowCancel(false);
      progress.BeginPart(100, "");
      progress.SetTitle("Import project properties");
      progress.ShowImmediately();

      CommandLineInterpreter cli = new CommandLineInterpreter();
      ActionCallingContext acc = new ActionCallingContext();

      acc.AddParameter("TYPE", "READPROJECTINFO");
      acc.AddParameter("FILENAME", ofd.FileName);
      cli.Execute("projectmanagement", acc);

      progress.EndPart(true);

      cli.Execute("XPrjActionPropertiesEdit");
    }
  }
}