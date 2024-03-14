namespace UI;

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
        solveButton = new Button();
        seedBox = new TextBox();
        capacityBox = new TextBox();
        numberOfItemsBox = new TextBox();
        seedLabel = new Label();
        capacityLabel = new Label();
        numberOfItemsLabel = new Label();
        resultLabel = new Label();
        problemLabel = new Label();
        totalWeightBox = new TextBox();
        totalValueBox = new TextBox();
        problemBox = new TextBox();
        totalValueLabel = new Label();
        totalWeightLabel = new Label();
        resultBox = new TextBox();
        SuspendLayout();
        // 
        // solveButton
        // 
        solveButton.Location = new Point(23, 202);
        solveButton.Name = "solveButton";
        solveButton.Size = new Size(146, 36);
        solveButton.TabIndex = 0;
        solveButton.Text = "Solve";
        solveButton.UseVisualStyleBackColor = true;
        solveButton.Click += solveButton_Click;
        // 
        // seedBox
        // 
        seedBox.BackColor = SystemColors.Window;
        seedBox.Location = new Point(23, 45);
        seedBox.Multiline = true;
        seedBox.Name = "seedBox";
        seedBox.Size = new Size(146, 23);
        seedBox.TabIndex = 1;
        seedBox.TextChanged += seedBox_TextChanged;
        // 
        // capacityBox
        // 
        capacityBox.Location = new Point(23, 100);
        capacityBox.Multiline = true;
        capacityBox.Name = "capacityBox";
        capacityBox.Size = new Size(146, 23);
        capacityBox.TabIndex = 2;
        capacityBox.TextChanged += capacityBox_TextChanged;
        // 
        // numberOfItemsBox
        // 
        numberOfItemsBox.Location = new Point(23, 162);
        numberOfItemsBox.Multiline = true;
        numberOfItemsBox.Name = "numberOfItemsBox";
        numberOfItemsBox.Size = new Size(146, 23);
        numberOfItemsBox.TabIndex = 3;
        numberOfItemsBox.TextChanged += numberOfItemsBox_TextChanged;
        // 
        // seedLabel
        // 
        seedLabel.AutoSize = true;
        seedLabel.Location = new Point(23, 27);
        seedLabel.Name = "seedLabel";
        seedLabel.Size = new Size(32, 15);
        seedLabel.TabIndex = 4;
        seedLabel.Text = "Seed";
        // 
        // capacityLabel
        // 
        capacityLabel.AutoSize = true;
        capacityLabel.Location = new Point(23, 82);
        capacityLabel.Name = "capacityLabel";
        capacityLabel.Size = new Size(53, 15);
        capacityLabel.TabIndex = 5;
        capacityLabel.Text = "Capacity";
        // 
        // numberOfItemsLabel
        // 
        numberOfItemsLabel.AutoSize = true;
        numberOfItemsLabel.Location = new Point(23, 144);
        numberOfItemsLabel.Name = "numberOfItemsLabel";
        numberOfItemsLabel.Size = new Size(97, 15);
        numberOfItemsLabel.TabIndex = 6;
        numberOfItemsLabel.Text = "Number of items";
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Font = new Font("Segoe UI", 16F);
        resultLabel.Location = new Point(461, 27);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(70, 30);
        resultLabel.TabIndex = 7;
        resultLabel.Text = "Result";
        // 
        // problemLabel
        // 
        problemLabel.AutoSize = true;
        problemLabel.Location = new Point(201, 27);
        problemLabel.Name = "problemLabel";
        problemLabel.Size = new Size(89, 15);
        problemLabel.TabIndex = 8;
        problemLabel.Text = "Problem details";
        // 
        // totalWeightBox
        // 
        totalWeightBox.Location = new Point(623, 86);
        totalWeightBox.Multiline = true;
        totalWeightBox.Name = "totalWeightBox";
        totalWeightBox.Size = new Size(146, 23);
        totalWeightBox.TabIndex = 9;
        // 
        // totalValueBox
        // 
        totalValueBox.Location = new Point(468, 86);
        totalValueBox.Name = "totalValueBox";
        totalValueBox.Size = new Size(146, 23);
        totalValueBox.TabIndex = 10;
        // 
        // problemBox
        // 
        problemBox.Location = new Point(201, 45);
        problemBox.Multiline = true;
        problemBox.Name = "problemBox";
        problemBox.ScrollBars = ScrollBars.Vertical;
        problemBox.Size = new Size(241, 367);
        problemBox.TabIndex = 11;
        // 
        // totalValueLabel
        // 
        totalValueLabel.AutoSize = true;
        totalValueLabel.Location = new Point(468, 68);
        totalValueLabel.Name = "totalValueLabel";
        totalValueLabel.Size = new Size(63, 15);
        totalValueLabel.TabIndex = 12;
        totalValueLabel.Text = "Total value";
        // 
        // totalWeightLabel
        // 
        totalWeightLabel.AutoSize = true;
        totalWeightLabel.Location = new Point(623, 68);
        totalWeightLabel.Name = "totalWeightLabel";
        totalWeightLabel.Size = new Size(71, 15);
        totalWeightLabel.TabIndex = 13;
        totalWeightLabel.Text = "Total weight";
        // 
        // resultBox
        // 
        resultBox.Location = new Point(468, 115);
        resultBox.Multiline = true;
        resultBox.Name = "resultBox";
        resultBox.ScrollBars = ScrollBars.Vertical;
        resultBox.Size = new Size(301, 297);
        resultBox.TabIndex = 14;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(resultBox);
        Controls.Add(totalWeightLabel);
        Controls.Add(totalValueLabel);
        Controls.Add(problemBox);
        Controls.Add(totalValueBox);
        Controls.Add(totalWeightBox);
        Controls.Add(problemLabel);
        Controls.Add(resultLabel);
        Controls.Add(numberOfItemsLabel);
        Controls.Add(capacityLabel);
        Controls.Add(seedLabel);
        Controls.Add(numberOfItemsBox);
        Controls.Add(capacityBox);
        Controls.Add(seedBox);
        Controls.Add(solveButton);
        Name = "MainWindow";
        Text = "Knapsack problem solver";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button solveButton;
    private TextBox seedBox;
    private TextBox capacityBox;
    private TextBox numberOfItemsBox;
    private Label seedLabel;
    private Label capacityLabel;
    private Label numberOfItemsLabel;
    private Label resultLabel;
    private Label problemLabel;
    private TextBox totalWeightBox;
    private TextBox totalValueBox;
    private TextBox problemBox;
    private Label totalValueLabel;
    private Label totalWeightLabel;
    private TextBox resultBox;
}