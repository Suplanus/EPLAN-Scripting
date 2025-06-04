using Eplan.EplApi.MasterData;
using Eplan.EplApi.Scripting;
using System.Linq;

class _17_Parts_02_ChangePartProperties
{
  [Start]
  public void Function()
  {
    MDPartsManagement mdPartsManagement = new MDPartsManagement();
    using (MDPartsDatabase database = mdPartsManagement.OpenDatabase())
    {
      var parts = database.Parts
                        .Where(obj => obj.ProductSubGroup ==
                          MDPartsDatabaseItem.Enums.ProductSubGroup
                          .MotorOverloadSwitch);

      foreach (MDPart part in parts)
      {
        part.Properties.ARTICLE_DESCR1 = "Motor overload switch";
      }
    }
  }
}