namespace ImageProcessorUI;

partial class MainWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        splitContainer1 = new SplitContainer();
        btnProcess = new Button();
        btnLoad = new Button();
        mainPictureBox = new PictureBox();
        bottomRightPictureBox = new PictureBox();
        bottomLeftPictureBox = new PictureBox();
        topRightPictureBox = new PictureBox();
        topLeftPictureBox = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bottomRightPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bottomLeftPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)topRightPictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)topLeftPictureBox).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(btnProcess);
        splitContainer1.Panel1.Controls.Add(btnLoad);
        splitContainer1.Panel1.Controls.Add(mainPictureBox);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(bottomRightPictureBox);
        splitContainer1.Panel2.Controls.Add(bottomLeftPictureBox);
        splitContainer1.Panel2.Controls.Add(topRightPictureBox);
        splitContainer1.Panel2.Controls.Add(topLeftPictureBox);
        splitContainer1.Size = new Size(800, 450);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 0;
        // 
        // btnProcess
        // 
        btnProcess.Location = new Point(12, 300);
        btnProcess.Name = "btnProcess";
        btnProcess.Size = new Size(240, 36);
        btnProcess.TabIndex = 2;
        btnProcess.Text = "Process image";
        btnProcess.UseVisualStyleBackColor = true;
        btnProcess.Click += btnProcess_Click;
        // 
        // btnLoad
        // 
        btnLoad.Location = new Point(12, 258);
        btnLoad.Name = "btnLoad";
        btnLoad.Size = new Size(240, 36);
        btnLoad.TabIndex = 1;
        btnLoad.Text = "Select image";
        btnLoad.UseVisualStyleBackColor = true;
        btnLoad.Click += btnLoad_Click;
        // 
        // mainPictureBox
        // 
        mainPictureBox.BackgroundImageLayout = ImageLayout.None;
        mainPictureBox.BorderStyle = BorderStyle.FixedSingle;
        mainPictureBox.Location = new Point(12, 12);
        mainPictureBox.Name = "mainPictureBox";
        mainPictureBox.Size = new Size(240, 240);
        mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        mainPictureBox.TabIndex = 0;
        mainPictureBox.TabStop = false;
        // 
        // bottomRightPictureBox
        // 
        bottomRightPictureBox.BackgroundImageLayout = ImageLayout.None;
        bottomRightPictureBox.BorderStyle = BorderStyle.FixedSingle;
        bottomRightPictureBox.Location = new Point(280, 228);
        bottomRightPictureBox.Name = "bottomRightPictureBox";
        bottomRightPictureBox.Size = new Size(210, 210);
        bottomRightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        bottomRightPictureBox.TabIndex = 4;
        bottomRightPictureBox.TabStop = false;
        // 
        // bottomLeftPictureBox
        // 
        bottomLeftPictureBox.BackgroundImageLayout = ImageLayout.None;
        bottomLeftPictureBox.BorderStyle = BorderStyle.FixedSingle;
        bottomLeftPictureBox.Location = new Point(43, 228);
        bottomLeftPictureBox.Name = "bottomLeftPictureBox";
        bottomLeftPictureBox.Size = new Size(210, 210);
        bottomLeftPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        bottomLeftPictureBox.TabIndex = 3;
        bottomLeftPictureBox.TabStop = false;
        // 
        // topRightPictureBox
        // 
        topRightPictureBox.BackgroundImageLayout = ImageLayout.None;
        topRightPictureBox.BorderStyle = BorderStyle.FixedSingle;
        topRightPictureBox.Location = new Point(280, 12);
        topRightPictureBox.Name = "topRightPictureBox";
        topRightPictureBox.Size = new Size(210, 210);
        topRightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        topRightPictureBox.TabIndex = 2;
        topRightPictureBox.TabStop = false;
        // 
        // topLeftPictureBox
        // 
        topLeftPictureBox.BackgroundImageLayout = ImageLayout.None;
        topLeftPictureBox.BorderStyle = BorderStyle.FixedSingle;
        topLeftPictureBox.Location = new Point(43, 12);
        topLeftPictureBox.Name = "topLeftPictureBox";
        topLeftPictureBox.Size = new Size(210, 210);
        topLeftPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        topLeftPictureBox.TabIndex = 1;
        topLeftPictureBox.TabStop = false;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(splitContainer1);
        Name = "MainWindow";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ImageProcessor";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)bottomRightPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)bottomLeftPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)topRightPictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)topLeftPictureBox).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private Button btnProcess;
    private Button btnLoad;
    private PictureBox mainPictureBox;
    private PictureBox bottomRightPictureBox;
    private PictureBox bottomLeftPictureBox;
    private PictureBox topRightPictureBox;
    private PictureBox topLeftPictureBox;
}