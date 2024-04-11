namespace URLScanner
{
    partial class AnalysisDetails
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label2 = new Label();
            txtDate = new TextBox();
            label1 = new Label();
            txtUrl = new TextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label3 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            label4 = new Label();
            dtgResults = new DataGridView();
            methodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            engineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outcomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resultBindingSource = new BindingSource(components);
            txtTimeout = new TextBox();
            txtHarmless = new TextBox();
            label7 = new Label();
            txtMalicious = new TextBox();
            txtUndetected = new TextBox();
            label5 = new Label();
            txtSuspicious = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).BeginInit();
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
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUrl);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 64);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 8;
            label8.Text = "Scanned At";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Scanned At";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(23, 82);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(203, 23);
            txtDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 7;
            label1.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(23, 37);
            txtUrl.Name = "txtUrl";
            txtUrl.ReadOnly = true;
            txtUrl.Size = new Size(203, 23);
            txtUrl.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnPrevious);
            groupBox2.Controls.Add(btnNext);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dtgResults);
            groupBox2.Controls.Add(txtTimeout);
            groupBox2.Controls.Add(txtHarmless);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtMalicious);
            groupBox2.Controls.Add(txtUndetected);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSuspicious);
            groupBox2.Location = new Point(14, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 417);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 37);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "Harmless";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 35);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Malicious";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(334, 360);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(415, 360);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Suspicious";
            // 
            // dtgResults
            // 
            dtgResults.AllowUserToAddRows = false;
            dtgResults.AllowUserToDeleteRows = false;
            dtgResults.AutoGenerateColumns = false;
            dtgResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgResults.Columns.AddRange(new DataGridViewColumn[] { methodDataGridViewTextBoxColumn, engineDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, outcomeDataGridViewTextBoxColumn });
            dtgResults.DataSource = resultBindingSource;
            dtgResults.Location = new Point(16, 82);
            dtgResults.Name = "dtgResults";
            dtgResults.ReadOnly = true;
            dtgResults.ScrollBars = ScrollBars.None;
            dtgResults.Size = new Size(472, 272);
            dtgResults.TabIndex = 0;
            // 
            // methodDataGridViewTextBoxColumn
            // 
            methodDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            methodDataGridViewTextBoxColumn.DataPropertyName = "Method";
            methodDataGridViewTextBoxColumn.FillWeight = 20F;
            methodDataGridViewTextBoxColumn.HeaderText = "Method";
            methodDataGridViewTextBoxColumn.Name = "methodDataGridViewTextBoxColumn";
            methodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineDataGridViewTextBoxColumn
            // 
            engineDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            engineDataGridViewTextBoxColumn.DataPropertyName = "Engine";
            engineDataGridViewTextBoxColumn.FillWeight = 40F;
            engineDataGridViewTextBoxColumn.HeaderText = "Engine";
            engineDataGridViewTextBoxColumn.Name = "engineDataGridViewTextBoxColumn";
            engineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.FillWeight = 20F;
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outcomeDataGridViewTextBoxColumn
            // 
            outcomeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            outcomeDataGridViewTextBoxColumn.DataPropertyName = "Outcome";
            outcomeDataGridViewTextBoxColumn.FillWeight = 20F;
            outcomeDataGridViewTextBoxColumn.HeaderText = "Outcome";
            outcomeDataGridViewTextBoxColumn.Name = "outcomeDataGridViewTextBoxColumn";
            outcomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultBindingSource
            // 
            resultBindingSource.DataSource = typeof(Models.Database.Result);
            // 
            // txtTimeout
            // 
            txtTimeout.Location = new Point(162, 53);
            txtTimeout.Name = "txtTimeout";
            txtTimeout.ReadOnly = true;
            txtTimeout.Size = new Size(67, 23);
            txtTimeout.TabIndex = 6;
            // 
            // txtHarmless
            // 
            txtHarmless.Location = new Point(16, 53);
            txtHarmless.Name = "txtHarmless";
            txtHarmless.ReadOnly = true;
            txtHarmless.Size = new Size(67, 23);
            txtHarmless.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 35);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Timeout";
            // 
            // txtMalicious
            // 
            txtMalicious.Location = new Point(309, 53);
            txtMalicious.Name = "txtMalicious";
            txtMalicious.ReadOnly = true;
            txtMalicious.Size = new Size(68, 23);
            txtMalicious.TabIndex = 2;
            // 
            // txtUndetected
            // 
            txtUndetected.Location = new Point(89, 53);
            txtUndetected.Name = "txtUndetected";
            txtUndetected.ReadOnly = true;
            txtUndetected.Size = new Size(67, 23);
            txtUndetected.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 35);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 11;
            label5.Text = "Undetected";
            // 
            // txtSuspicious
            // 
            txtSuspicious.Location = new Point(235, 53);
            txtSuspicious.Name = "txtSuspicious";
            txtSuspicious.ReadOnly = true;
            txtSuspicious.Size = new Size(68, 23);
            txtSuspicious.TabIndex = 3;
            // 
            // AnalysisDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "AnalysisDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "URLScanner - AnalysisDetails";
            Load += AnalysisDetails_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dtgResults;
        private BindingSource resultBindingSource;
        private Button btnPrevious;
        private Button btnNext;
        private Label label2;
        private Label label1;
        private TextBox txtTimeout;
        private TextBox txtHarmless;
        private TextBox txtUndetected;
        private TextBox txtSuspicious;
        private TextBox txtMalicious;
        private TextBox txtUrl;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox txtDate;
        private DataGridViewTextBoxColumn methodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn engineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outcomeDataGridViewTextBoxColumn;
    }
}