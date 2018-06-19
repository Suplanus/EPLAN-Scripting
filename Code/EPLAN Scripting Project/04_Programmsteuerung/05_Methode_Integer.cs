using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public class _04_Programmsteuerung_05_Methode_Integer
{
    [DeclareAction("MethodeInt")]
    public void Function(int int1, int int2)
    {
        CalcMessageBox(int1, int2);
        FinishedMessageBox();

        return;
    }

    private static void CalcMessageBox(int int1, int int2)
    {
        int intResult = int1 + int2;
        MessageBox.Show(int1.ToString() +
            " + " + int2.ToString() +
            " = " + intResult.ToString());

        return;
    }

    private static void FinishedMessageBox()
    {
        MessageBox.Show("Berechnung abgeschlossen.");

        return;
    }
}