using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class _13_FilesOpenSave_04_FileSelectDecisionContext
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");

    // Save
    FileSelectDecisionContext fsdcSave = new FileSelectDecisionContext();
    fsdcSave.Title = "Choose file:";
    fsdcSave.OpenFileFlag = false;
    fsdcSave.CustomDefaultPath = projectPath;
    fsdcSave.AllowMultiSelect = false;
    fsdcSave.DefaultExtension = "txt";
    fsdcSave.AddFilter("Text files (*.txt)", "*.txt");
    fsdcSave.AddFilter("All files (*.*)", "*.*");

    Decider deciderSave = new Decider();
    EnumDecisionReturn decisionSave = deciderSave.Decide(fsdcSave);
    if (decisionSave == EnumDecisionReturn.eCANCEL)
    {
      return;
    }

    string fullFileNameSave = fsdcSave.GetFiles()[0];
    FileStream fileStream = File.Create(fullFileNameSave);
    fileStream.Dispose();
    MessageBox.Show("File has been saved:" + Environment.NewLine + fullFileNameSave);

    // Open
    FileSelectDecisionContext fsdcOpen = new FileSelectDecisionContext();
    fsdcOpen.Title = "Choose file:";
    fsdcOpen.OpenFileFlag = true;
    fsdcOpen.CustomDefaultPath = projectPath;
    fsdcOpen.AllowMultiSelect = false;
    fsdcOpen.DefaultExtension = "txt";
    fsdcOpen.AddFilter("Text files (*.txt)", "*.txt");
    fsdcOpen.AddFilter("All files (*.*)", "*.*");

    Decider deciderOpen = new Decider();
    EnumDecisionReturn decisionOpen = deciderOpen.Decide(fsdcOpen);
    if (decisionOpen == EnumDecisionReturn.eCANCEL)
    {
      return;
    }

    string fullFileNameOpen = fsdcOpen.GetFiles()[0];
    MessageBox.Show("File openend:" + Environment.NewLine + fullFileNameOpen);
  }
}