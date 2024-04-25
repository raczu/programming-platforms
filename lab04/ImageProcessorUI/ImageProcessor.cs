namespace ImageProcessorUI;

public static class ImageProcessor
{
    public static Bitmap Threshold(Bitmap image, int threshold)
    {
        var copied = (Bitmap)image.Clone();
        for (var y = 0; y < copied.Height; y++)
        {
            for (var x = 0; x < copied.Width; x++)
            {
                var pixel = copied.GetPixel(x, y);
                var average = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                copied.SetPixel(x, y, average < threshold ? Color.Black : Color.White);
            }
        }

        return copied;
    }
    
    public static Bitmap Grayscale(Bitmap image)
    {
        var copied = (Bitmap)image.Clone();
        for (var y = 0; y < copied.Height; y++)
        {
            for (var x = 0; x < copied.Width; x++)
            {
                var pixel = copied.GetPixel(x, y);
                var average = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                copied.SetPixel(x, y, Color.FromArgb(average, average, average));
            }
        }

        return copied;
    }

    public static Bitmap Sepia(Bitmap image)
    {
        var copied = (Bitmap)image.Clone();
        for (var y = 0; y < copied.Height; y++)
        {
            for (var x = 0; x < copied.Width; x++)
            {
                var pixel = copied.GetPixel(x, y);
                var red = (int)((pixel.R * 0.393) + (pixel.G * 0.769) + (pixel.B * 0.189));
                var green = (int)((pixel.R * 0.349) + (pixel.G * 0.686) + (pixel.B * 0.168));
                var blue = (int)((pixel.R * 0.272) + (pixel.G * 0.534) + (pixel.B * 0.131));

                red = red > 255 ? 255 : red;
                green = green > 255 ? 255 : green;
                blue = blue > 255 ? 255 : blue;
                
                copied.SetPixel(x, y, Color.FromArgb(red, green, blue));
            }
        }

        return copied;
    }
    
    public static Bitmap Invert(Bitmap image)
    {
        var copied = (Bitmap)image.Clone();
        for (var y = 0; y < copied.Height; y++)
        {
            for (var x = 0; x < copied.Width; x++)
            {
                var pixel = copied.GetPixel(x, y);
                var invertedColor = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                copied.SetPixel(x, y, invertedColor);
            }
        }

        return copied;
    }
}