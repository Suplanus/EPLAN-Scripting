using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class Projektsuche : System.Windows.Forms.Form
{
  public string ProjectPath = string.Empty;

  #region Formular
  public Projektsuche()
  {
    InitializeComponent();
  }

  private System.Windows.Forms.Button ButtonOK;
  private System.Windows.Forms.ListView ListViewResult;
  private System.Windows.Forms.ColumnHeader columnHeader1;
  private System.Windows.Forms.ColumnHeader columnHeader2;
  private System.Windows.Forms.ColumnHeader columnHeader3;
  private System.Windows.Forms.Button ButtonSearch;
  private System.Windows.Forms.TextBox TextBoxSearch;
  private System.Windows.Forms.StatusStrip StatusStipMain;
  private System.Windows.Forms.Button ButtonCancel;
  private ToolStripStatusLabel ToolStripLabel;

  ///
  /// Erforderliche Designervariable.
  ///
  private System.ComponentModel.IContainer components = null;

  ///
  /// Verwendete Ressourcen bereinigen.
  ///
  /// True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.
  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
    {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

  ///
  /// Erforderliche Methode für die Designerunterstützung.
  /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
  ///
  private void InitializeComponent()
  {
      this.ButtonOK = new System.Windows.Forms.Button();
      this.ListViewResult = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ButtonSearch = new System.Windows.Forms.Button();
      this.TextBoxSearch = new System.Windows.Forms.TextBox();
      this.StatusStipMain = new System.Windows.Forms.StatusStrip();
      this.ToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.ButtonCancel = new System.Windows.Forms.Button();
      this.StatusStipMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // ButtonOK
      // 
      this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ButtonOK.Location = new System.Drawing.Point(474, 274);
      this.ButtonOK.Name = "ButtonOK";
      this.ButtonOK.Size = new System.Drawing.Size(75, 23);
      this.ButtonOK.TabIndex = 6;
      this.ButtonOK.Text = "OK";
      this.ButtonOK.UseVisualStyleBackColor = true;
      this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
      // 
      // ListViewResult
      // 
      this.ListViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ListViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.ListViewResult.FullRowSelect = true;
      this.ListViewResult.GridLines = true;
      this.ListViewResult.HideSelection = false;
      this.ListViewResult.Location = new System.Drawing.Point(12, 39);
      this.ListViewResult.Name = "ListViewResult";
      this.ListViewResult.Size = new System.Drawing.Size(618, 229);
      this.ListViewResult.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.ListViewResult.TabIndex = 10;
      this.ListViewResult.UseCompatibleStateImageBehavior = false;
      this.ListViewResult.View = System.Windows.Forms.View.Details;
      this.ListViewResult.DoubleClick += new System.EventHandler(this.ListViewResult_DoubleClick);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Projektname";
      this.columnHeader1.Width = 76;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Pfad";
      this.columnHeader2.Width = 89;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Erweiterung";
      this.columnHeader3.Width = 223;
      // 
      // ButtonSearch
      // 
      this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ButtonSearch.Enabled = false;
      this.ButtonSearch.Location = new System.Drawing.Point(530, 9);
      this.ButtonSearch.Name = "ButtonSearch";
      this.ButtonSearch.Size = new System.Drawing.Size(100, 23);
      this.ButtonSearch.TabIndex = 9;
      this.ButtonSearch.Text = "Suchen";
      this.ButtonSearch.UseVisualStyleBackColor = true;
      this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
      // 
      // TextBoxSearch
      // 
      this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TextBoxSearch.Location = new System.Drawing.Point(12, 11);
      this.TextBoxSearch.Name = "TextBoxSearch";
      this.TextBoxSearch.Size = new System.Drawing.Size(512, 20);
      this.TextBoxSearch.TabIndex = 8;
      this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
      // 
      // StatusStipMain
      // 
      this.StatusStipMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel});
      this.StatusStipMain.Location = new System.Drawing.Point(0, 301);
      this.StatusStipMain.Name = "StatusStipMain";
      this.StatusStipMain.Size = new System.Drawing.Size(642, 22);
      this.StatusStipMain.TabIndex = 13;
      this.StatusStipMain.Text = "statusStrip1";
      // 
      // ToolStripLabel
      // 
      this.ToolStripLabel.Name = "ToolStripLabel";
      this.ToolStripLabel.Size = new System.Drawing.Size(627, 17);
      this.ToolStripLabel.Spring = true;
      this.ToolStripLabel.Text = "Suchbegriff eingeben...";
      this.ToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ButtonCancel
      // 
      this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ButtonCancel.Location = new System.Drawing.Point(555, 274);
      this.ButtonCancel.Name = "ButtonCancel";
      this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
      this.ButtonCancel.TabIndex = 15;
      this.ButtonCancel.Text = "Abbrechen";
      this.ButtonCancel.UseVisualStyleBackColor = true;
      this.ButtonCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // Projektsuche
      // 
      this.AcceptButton = this.ButtonSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(642, 323);
      this.Controls.Add(this.ButtonCancel);
      this.Controls.Add(this.StatusStipMain);
      this.Controls.Add(this.ListViewResult);
      this.Controls.Add(this.ButtonSearch);
      this.Controls.Add(this.TextBoxSearch);
      this.Controls.Add(this.ButtonOK);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(450, 200);
      this.Name = "Projektsuche";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Projektsuche";
      this.Load += new System.EventHandler(this.Projektsuche_Load);
      this.StatusStipMain.ResumeLayout(false);
      this.StatusStipMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  #endregion

  [DeclareAction("Projektsuche")]
  public void SearchMacrosVoid()
  {
    Projektsuche form = new Projektsuche();
    form.ShowDialog();
  }

  private void Projektsuche_Load(object sender, System.EventArgs e)
  {
    ProjectPath = PathMap.SubstitutePath("$(MD_PROJECTS)");
    TextBoxSearch.Select();
  }

  private void btnCancel_Click(object sender, System.EventArgs e)
  {
    this.Close();
  }

  private void OpenProject(string fullProjectPath)
  {
    Cursor.Current = Cursors.WaitCursor;

    ToolStripLabel.Text = "Projekt '"
        + Path.GetFileNameWithoutExtension(fullProjectPath)
        + "' wird geöffnet...";

    this.Update();

    CommandLineInterpreter cli = new CommandLineInterpreter();
    ActionCallingContext acc = new ActionCallingContext();
    acc.AddParameter("Project", fullProjectPath);
    cli.Execute("ProjectOpen", acc);

    Cursor.Current = Cursors.Default;
  }

  private void ButtonSearch_Click(object sender, System.EventArgs e)
  {
    Cursor.Current = Cursors.WaitCursor;

    ToolStripLabel.Text = "Projekt(e) werden gesucht...";

    ListViewResult.BeginUpdate();

    GetProjects();

    ListViewResult.AutoResizeColumns(
      ColumnHeaderAutoResizeStyle.ColumnContent);

    ListViewResult.EndUpdate();

    Cursor.Current = Cursors.Default;
  }

  private void GetProjects()
  {
    ListViewResult.Items.Clear();

    string[] result = Directory.GetFiles(ProjectPath,
        "*" + TextBoxSearch.Text + "*.el*",
        SearchOption.TopDirectoryOnly
        );

    foreach (string project in result)
    {
      FillListView(project);
    }

    ToolStripLabel.Text = "Projekte gefunden: " +
      ListViewResult.Items.Count.ToString();
  }

  private void FillListView(string fullPath)
  {
    FileInfo fileInfo = new FileInfo(fullPath);

    string fileNameWithoutExtension =
        Path.GetFileNameWithoutExtension(fileInfo.FullName);
    string directory = fileInfo.Directory.ToString() + @"\";
    string extension = fileInfo.Extension;

    ListViewItem listViewItem = new ListViewItem();
    listViewItem.Text = fileNameWithoutExtension;
    listViewItem.SubItems.Add(directory);
    listViewItem.SubItems.Add(extension);
    ListViewResult.Items.Add(listViewItem);
  }

  private void ButtonOK_Click(object sender, System.EventArgs e)
  {
    GetFileNameAndOpen();
  }

  private void ListViewResult_DoubleClick(
    object sender, EventArgs e)
  {
    GetFileNameAndOpen();
  }

  private void GetFileNameAndOpen()
  {
    if (ListViewResult.SelectedItems.Count > 0)
    {
      string project =
            ListViewResult.SelectedItems[0].SubItems[1].Text
          + ListViewResult.SelectedItems[0].SubItems[0].Text
          + ListViewResult.SelectedItems[0].SubItems[2].Text;

      OpenProject(project);
    }

    this.Close();
  }

  private void TextBoxSearch_TextChanged(
    object sender, System.EventArgs e)
  {
    if (TextBoxSearch.Text == "")
    {
      ButtonSearch.Enabled = false;
    }
    else
    {
      ButtonSearch.Enabled = true;
    }
  }
}