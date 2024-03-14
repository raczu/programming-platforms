using lab02;

namespace UI;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();
        problemBox.ReadOnly = true;
        totalWeightBox.ReadOnly = true;
        totalValueBox.ReadOnly = true;
        resultBox.ReadOnly = true;
    }

    private bool isValidInput(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        bool isInteger = int.TryParse(input, out int number);
        if (!isInteger) return false;
        return number >= 0;
    }

    private void setProperColor(TextBox box)
    {
        string userInput = box.Text.Trim();
        if (!isValidInput(userInput))
        {
            box.ForeColor = Color.Red;
        }
        else
        {
            box.ForeColor = SystemColors.WindowText;
        }
    }

    private void seedBox_TextChanged(object sender, EventArgs e)
    {
        setProperColor(seedBox);
    }

    private void capacityBox_TextChanged(object sender, EventArgs e)
    {
        setProperColor(capacityBox);
    }

    private void numberOfItemsBox_TextChanged(object sender, EventArgs e)
    {
        setProperColor(numberOfItemsBox);
    }

    private void solveButton_Click(object sender, EventArgs e)
    {
        var seedInput = seedBox.Text.Trim();
        var capacityInput = capacityBox.Text.Trim();
        var numberOfItemsInput = numberOfItemsBox.Text.Trim();

        if (!isValidInput(seedInput) || !isValidInput(capacityInput) || !isValidInput(numberOfItemsInput)) return;

        var seed = int.Parse(seedInput);
        var capacity = int.Parse(capacityInput);
        var n = int.Parse(numberOfItemsInput);

        var problem = new Problem(n, seed);
        var result = problem.Solve(capacity);

        problemBox.Text = problem.ToString();
        totalValueBox.Text = result.TotalValue.ToString();
        totalWeightBox.Text = result.TotalWeight.ToString();
        resultBox.Text = result.ToString();
    }
}