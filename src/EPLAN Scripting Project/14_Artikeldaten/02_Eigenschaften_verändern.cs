using Eplan.EplApi.MasterData;
using Eplan.EplApi.Scripting;
using System.Linq;

class _14_Artikeldaten_02_Eigenschaften_veraendern
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
        part.Properties.ARTICLE_DESCR1 = "Motorschutzschalter";
      }
    }
  }
}