namespace URLScanner;

partial class Dashboard
{
    private System.ComponentModel.IContainer components = null;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        splitContainer1 = new SplitContainer();
        groupBox1 = new GroupBox();
        label2 = new Label();
        btnScan = new Button();
        txtUrlScan = new TextBox();
        groupBox2 = new GroupBox();
        btnReset = new Button();
        label1 = new Label();
        dtgAnalysis = new DataGridView();
        dtgId = new DataGridViewTextBoxColumn();
        dtgUrl = new DataGridViewTextBoxColumn();
        dtgDate = new DataGridViewTextBoxColumn();
        btnSearch = new Button();
        txtUrlSearch = new TextBox();
        btnDelete = new Button();
        btnPrevious = new Button();
        btnNext = new Button();
        analysisBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtgAnalysis).BeginInit();
        ((System.ComponentModel.ISupportInitialize)analysisBindingSource).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(groupBox1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(groupBox2);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(btnScan);
        groupBox1.Controls.Add(txtUrlScan);
        groupBox1.Location = new Point(12, 21);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(237, 149);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Scanner";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(33, 34);
        label2.Name = "label2";
        label2.Size = new Size(28, 15);
        label2.TabIndex = 3;
        label2.Text = "URL";
        // 
        // btnScan
        // 
        btnScan.Location = new Point(33, 81);
        btnScan.Name = "btnScan";
        btnScan.Size = new Size(176, 23);
        btnScan.TabIndex = 1;
        btnScan.Text = "Scan";
        btnScan.UseVisualStyleBackColor = true;
        btnScan.Click += btnScan_Click;
        // 
        // txtUrlScan
        // 
        txtUrlScan.Location = new Point(33, 52);
        txtUrlScan.Name = "txtUrlScan";
        txtUrlScan.Size = new Size(176, 23);
        txtUrlScan.TabIndex = 3;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnReset);
        groupBox2.Controls.Add(label1);
        groupBox2.Controls.Add(dtgAnalysis);
        groupBox2.Controls.Add(btnSearch);
        groupBox2.Controls.Add(txtUrlSearch);
        groupBox2.Controls.Add(btnDelete);
        groupBox2.Controls.Add(btnPrevious);
        groupBox2.Controls.Add(btnNext);
        groupBox2.Location = new Point(14, 21);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(504, 417);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "History";
        // 
        // btnReset
        // 
        btnReset.Location = new Point(411, 50);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(75, 23);
        btnReset.TabIndex = 7;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(168, 34);
        label1.Name = "label1";
        label1.Size = new Size(28, 15);
        label1.TabIndex = 6;
        label1.Text = "URL";
        // 
        // dtgAnalysis
        // 
        dtgAnalysis.AllowUserToAddRows = false;
        dtgAnalysis.AllowUserToDeleteRows = false;
        dtgAnalysis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgAnalysis.Columns.AddRange(new DataGridViewColumn[] { dtgId, dtgUrl, dtgDate });
        dtgAnalysis.Location = new Point(16, 82);
        dtgAnalysis.Name = "dtgAnalysis";
        dtgAnalysis.ReadOnly = true;
        dtgAnalysis.ScrollBars = ScrollBars.None;
        dtgAnalysis.Size = new Size(472, 272);
        dtgAnalysis.TabIndex = 5;
        dtgAnalysis.CellDoubleClick += dtgAnalysis_CellDoubleClick;
        // 
        // dtgId
        // 
        dtgId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dtgId.DataPropertyName = "Id";
        dtgId.FillWeight = 15F;
        dtgId.HeaderText = "ID";
        dtgId.Name = "dtgId";
        dtgId.ReadOnly = true;
        // 
        // dtgUrl
        // 
        dtgUrl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dtgUrl.DataPropertyName = "Url";
        dtgUrl.FillWeight = 50F;
        dtgUrl.HeaderText = "URL";
        dtgUrl.Name = "dtgUrl";
        dtgUrl.ReadOnly = true;
        // 
        // dtgDate
        // 
        dtgDate.DataPropertyName = "Date";
        dtgDate.FillWeight = 35F;
        dtgDate.HeaderText = "Scanned At";
        dtgDate.Name = "dtgDate";
        dtgDate.ReadOnly = true;
        dtgDate.Width = 135;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(330, 50);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(75, 23);
        btnSearch.TabIndex = 4;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // txtUrlSearch
        // 
        txtUrlSearch.Location = new Point(168, 50);
        txtUrlSearch.Name = "txtUrlSearch";
        txtUrlSearch.Size = new Size(156, 23);
        txtUrlSearch.TabIndex = 3;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(249, 360);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 23);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnPrevious
        // 
        btnPrevious.Location = new Point(330, 360);
        btnPrevious.Name = "btnPrevious";
        btnPrevious.Size = new Size(75, 23);
        btnPrevious.TabIndex = 1;
        btnPrevious.Text = "<";
        btnPrevious.UseVisualStyleBackColor = true;
        btnPrevious.Click += btnPrevious_Click;
        // 
        // btnNext
        // 
        btnNext.Location = new Point(411, 360);
        btnNext.Name = "btnNext";
        btnNext.Size = new Size(75, 23);
        btnNext.TabIndex = 0;
        btnNext.Text = ">";
        btnNext.UseVisualStyleBackColor = true;
        btnNext.Click += btnNext_Click;
        // 
        // analysisBindingSource
        // 
        analysisBindingSource.DataSource = typeof(Models.Database.Analysis);
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "Dashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "URLScanner";
        Load += Dashboard_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dtgAnalysis).EndInit();
        ((System.ComponentModel.ISupportInitialize)analysisBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private TextBox txtUrlScan;
    private Button btnScan;
    private GroupBox groupBox1;
    private Label label2;
    private GroupBox groupBox2;
    private Button btnDelete;
    private Button btnPrevious;
    private Button btnNext;
    private DataGridView dtgAnalysis;
    private Button btnSearch;
    private TextBox txtUrlSearch;
    private Label label1;
    private BindingSource analysisBindingSource;
    private Button btnReset;
    private DataGridViewTextBoxColumn dtgId;
    private DataGridViewTextBoxColumn dtgUrl;
    private DataGridViewTextBoxColumn dtgDate;
}