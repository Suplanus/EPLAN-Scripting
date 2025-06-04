using System.Linq;
using System.Windows.Forms;
using Eplan.EplApi.MasterData;
using Eplan.EplApi.Scripting;

class _17_Parts_01_CountParts
{
  [Start]
  public void Function()
  {
    MDPartsManagement mdPartsManagement = new MDPartsManagement();
    int partCount;

    using (MDPartsDatabase database = mdPartsManagement.OpenDatabase())
    {
      partCount = database.Parts
                            .Count(obj => obj.ProductSubGroup ==
                              MDPartsDatabaseItem.Enums.ProductSubGroup.MotorOverloadSwitch);
    }
    MessageBox.Show("Count motor overload switches: " + partCount);
  }
}