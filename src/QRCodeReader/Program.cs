///


Console.WriteLine("Enter the path of the QR code image file:");
var imagePath = Console.ReadLine();

if (!File.Exists(imagePath))
{
    Console.WriteLine("File does not exist.");
    return;
}

var reader = new BarcodeReader<>();
var result = reader.Decode(new Bitmap(imagePath));

if (result != null)
{
    Console.WriteLine("QR code content:");
    Console.WriteLine(result.Text);

    Console.WriteLine("Enter the path for the output file:");
    var outputFilePath = Console.ReadLine() ?? throw new InvalidOperationException();

    using (var writer = new StreamWriter(outputFilePath))
    {
        writer.Write(result.Text);
    }

    Console.WriteLine($"QR code content has been saved to {outputFilePath}.");
}
else
{
    Console.WriteLine("The provided image does not contain a QR code.");
}

Console.ReadKey();