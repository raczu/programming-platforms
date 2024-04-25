namespace ImageProcessorUI;

public partial class MainWindow : Form
{
    private Bitmap? _image = null;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        var fileDialog = new OpenFileDialog
        {
            Filter = @"Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *png;"
        };

        if (fileDialog.ShowDialog() != DialogResult.OK) return;
        var filePath = fileDialog.FileName;
        _image = new Bitmap(filePath);
        mainPictureBox.Image = _image;
    }

    private void btnProcess_Click(object sender, EventArgs e)
    {
        if (_image == null)
        {
            MessageBox.Show(
                @"Please specify image to process.",
                @"Processing Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var functions = new[]
        {
            (image) => ImageProcessor.Threshold(image, 128),
            ImageProcessor.Grayscale,
            ImageProcessor.Sepia,
            ImageProcessor.Invert
        };
        
        var boxes = new[]
        {
            topLeftPictureBox,
            topRightPictureBox,
            bottomLeftPictureBox,
            bottomRightPictureBox
        };
        
        var countdownEvent = new CountdownEvent(boxes.Length);
        for (var i = 0; i < boxes.Length; i++)
        {
            var index = i;
            var copied = (Bitmap)_image.Clone();
            new Thread(() =>
            {
                var result = functions[index](copied);
                boxes[index].Invoke(new Action(() => boxes[index].Image = result));
                countdownEvent.Signal();
            }).Start();
        }

        new Thread (() =>
        {
            countdownEvent.Wait();
            Invoke(new Action(() =>
            {
                MessageBox.Show(
                    @"All images have been processed.",
                    @"Processing complete.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }).Start();
    }
}