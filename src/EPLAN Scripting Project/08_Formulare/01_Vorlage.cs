using System.Windows.Forms;
using Eplan.EplApi.Scripting;

public partial class FormVorlage : Form
{
  #region Windows Form Designer generated code
  public FormVorlage()
  {
    InitializeComponent();
  }

  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    // 
    // FormVorlage
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(284, 261);
    this.Name = "FormVorlage";
    this.StartPosition =
      System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Vorlage";
    this.ResumeLayout(false);

  }
  #endregion

  [Start]
  public void Function()
  {
    FormVorlage form = new FormVorlage();
    form.ShowDialog();
  }
}