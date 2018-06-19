using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public partial class FormularBeispiel : System.Windows.Forms.Form
{
  private Button ButtonCancel;
  private Button ButtonOk;
  private CheckBox CheckBoxProjectCheck;
  private CheckBox CheckBoxReport;
  private CheckBox chkCheckall;
  private Label LabelProject;
  private ProgressBar ProgressBarFull;

  #region Vom Windows Form-Designer generierter Code

  /// <summary>
  /// Erforderliche Designervariable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Verwendete Ressourcen bereinigen.
  /// </summary>
  /// <param name="disposing">True, wenn verwaltete Ressourcen
  /// gelöscht werden sollen; andernfalls False.</param>
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  /// <summary>
  /// Erforderliche Methode für die Designerunterstützung.
  /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert
  /// werden.
  /// </summary>
  private void InitializeComponent()
  {
      this.ButtonCancel = new System.Windows.Forms.Button();
      this.ButtonOk = new System.Windows.Forms.Button();
      this.CheckBoxProjectCheck = new System.Windows.Forms.CheckBox();
      this.CheckBoxReport = new System.Windows.Forms.CheckBox();
      this.chkCheckall = new System.Windows.Forms.CheckBox();
      this.LabelProject = new System.Windows.Forms.Label();
      this.ProgressBarFull = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // ButtonCancel
      // 
      this.ButtonCancel.Location = new System.Drawing.Point(207, 240);
      this.ButtonCancel.Name = "ButtonCancel";
      this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
      this.ButtonCancel.TabIndex = 5;
      this.ButtonCancel.Text = "Abbrechen";
      this.ButtonCancel.UseVisualStyleBackColor = true;
      this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
      // 
      // ButtonOk
      // 
      this.ButtonOk.Location = new System.Drawing.Point(126, 240);
      this.ButtonOk.Name = "ButtonOk";
      this.ButtonOk.Size = new System.Drawing.Size(75, 23);
      this.ButtonOk.TabIndex = 4;
      this.ButtonOk.Text = "OK";
      this.ButtonOk.UseVisualStyleBackColor = true;
      this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
      // 
      // CheckBoxProjectCheck
      // 
      this.CheckBoxProjectCheck.AutoSize = true;
      this.CheckBoxProjectCheck.Checked = true;
      this.CheckBoxProjectCheck.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CheckBoxProjectCheck.Location = new System.Drawing.Point(12, 25);
      this.CheckBoxProjectCheck.Name = "CheckBoxProjectCheck";
      this.CheckBoxProjectCheck.Size = new System.Drawing.Size(62, 17);
      this.CheckBoxProjectCheck.TabIndex = 1;
      this.CheckBoxProjectCheck.Text = "Prüflauf";
      this.CheckBoxProjectCheck.UseVisualStyleBackColor = true;
      // 
      // CheckBoxReport
      // 
      this.CheckBoxReport.AutoSize = true;
      this.CheckBoxReport.Checked = true;
      this.CheckBoxReport.CheckState = System.Windows.Forms.CheckState.Checked;
      this.CheckBoxReport.Location = new System.Drawing.Point(12, 48);
      this.CheckBoxReport.Name = "CheckBoxReport";
      this.CheckBoxReport.Size = new System.Drawing.Size(129, 17);
      this.CheckBoxReport.TabIndex = 2;
      this.CheckBoxReport.Text = "Auswertung erzeugen";
      this.CheckBoxReport.UseVisualStyleBackColor = true;
      // 
      // chkCheckall
      // 
      this.chkCheckall.AutoSize = true;
      this.chkCheckall.Checked = true;
      this.chkCheckall.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkCheckall.Location = new System.Drawing.Point(12, 244);
      this.chkCheckall.Name = "chkCheckall";
      this.chkCheckall.Size = new System.Drawing.Size(92, 17);
      this.chkCheckall.TabIndex = 3;
      this.chkCheckall.Text = "Alle aktivieren";
      this.chkCheckall.UseVisualStyleBackColor = true;
      this.chkCheckall.CheckedChanged += new System.EventHandler(this.chbCheckall_CheckedChanged);
      // 
      // LabelProject
      // 
      this.LabelProject.AutoSize = true;
      this.LabelProject.Location = new System.Drawing.Point(9, 9);
      this.LabelProject.Name = "LabelProject";
      this.LabelProject.Size = new System.Drawing.Size(66, 13);
      this.LabelProject.TabIndex = 5;
      this.LabelProject.Text = "Projektname";
      // 
      // ProgressBarFull
      // 
      this.ProgressBarFull.Location = new System.Drawing.Point(12, 224);
      this.ProgressBarFull.Maximum = 3;
      this.ProgressBarFull.Name = "ProgressBarFull";
      this.ProgressBarFull.Size = new System.Drawing.Size(270, 10);
      this.ProgressBarFull.Step = 1;
      this.ProgressBarFull.TabIndex = 6;
      // 
      // FormularBeispiel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 273);
      this.Controls.Add(this.ProgressBarFull);
      this.Controls.Add(this.LabelProject);
      this.Controls.Add(this.chkCheckall);
      this.Controls.Add(this.CheckBoxReport);
      this.Controls.Add(this.CheckBoxProjectCheck);
      this.Controls.Add(this.ButtonOk);
      this.Controls.Add(this.ButtonCancel);
      this.Name = "FormularBeispiel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Formularbeispiel";
      this.Load += new System.EventHandler(this.FormularBeispiel_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  public FormularBeispiel()
  {
    InitializeComponent();
  }

  #endregion

  [Start]
  public void Function()
  {
    FormularBeispiel form = new FormularBeispiel();
    form.ShowDialog();

    return;
  }

  private void ButtonCancel_Click(object sender, System.EventArgs e)
  {
    this.Close();

    return;
  }

  private void ButtonOk_Click(object sender, System.EventArgs e)
  {
    CommandLineInterpreter cli = new CommandLineInterpreter();

    ProgressBarFull.PerformStep();
    if (CheckBoxProjectCheck.Checked)
    {
      cli.Execute("XMsgActionStartVerification");
    }

    ProgressBarFull.PerformStep();
    if (CheckBoxReport.Checked)
    {
      cli.Execute("reports");
    }

    ProgressBarFull.PerformStep();   
    ProgressBarFull.Value = 0;

    this.Close();

    return;
  }

  private void chbCheckall_CheckedChanged(object sender, System.EventArgs e)
  {
    if (chkCheckall.Checked)
    {
      CheckBoxProjectCheck.Checked = true;
      CheckBoxReport.Checked = true;
    }
    else
    {
      CheckBoxProjectCheck.Checked = false;
      CheckBoxReport.Checked = false;
    }

    return;
  }

  private void FormularBeispiel_Load(object sender, System.EventArgs e)
  {
    LabelProject.Text = PathMap.SubstitutePath("$(PROJECTNAME)");
  }
}