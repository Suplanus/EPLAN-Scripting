using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

class _11_Dateien_oeffnen_speichern_04_FileSelectDecisionContext
{
  [Start]
  public void Function()
  {
    string projectPath = PathMap.SubstitutePath("$(PROJECTPATH)");

    // Save
    FileSelectDecisionContext fsdcSave = new FileSelectDecisionContext();
    fsdcSave.Title = "Datei auswählen";
    fsdcSave.OpenFileFlag = false;
    fsdcSave.CustomDefaultPath = projectPath;
    fsdcSave.AllowMultiSelect = false;
    fsdcSave.DefaultExtension = "txt";
    fsdcSave.AddFilter("Textdatei (*.txt)", "*.txt");
    fsdcSave.AddFilter("Alle Dateien (*.*)", "*.*");

    Decider deciderSave = new Decider();
    EnumDecisionReturn decisionSave = deciderSave.Decide(fsdcSave);
    if (decisionSave == EnumDecisionReturn.eCANCEL)
    {
      return;
    }

    string fullFileNameSave = fsdcSave.GetFiles()[0];
    FileStream fileStream = File.Create(fullFileNameSave);
    fileStream.Dispose();
    MessageBox.Show("Datei wurde gespeichert:" + Environment.NewLine +
                    fullFileNameSave);

    // Open
    FileSelectDecisionContext fsdcOpen = new FileSelectDecisionContext();
    fsdcOpen.Title = "Datei auswählen";
    fsdcOpen.OpenFileFlag = true;
    fsdcOpen.CustomDefaultPath = projectPath;
    fsdcOpen.AllowMultiSelect = false;
    fsdcOpen.DefaultExtension = "txt";
    fsdcOpen.AddFilter("Textdatei (*.txt)", "*.txt");
    fsdcOpen.AddFilter("Alle Dateien (*.*)", "*.*");

    Decider deciderOpen = new Decider();
    EnumDecisionReturn decisionOpen = deciderOpen.Decide(fsdcOpen);
    if (decisionOpen == EnumDecisionReturn.eCANCEL)
    {
      return;
    }

    string fullFileNameOpen = fsdcOpen.GetFiles()[0];
    MessageBox.Show("Datei wurde geöffnet:" + Environment.NewLine +
                    fullFileNameOpen);
  }
}