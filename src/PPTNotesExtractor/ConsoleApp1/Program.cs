using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System.IO.Abstractions;

namespace Combiner;

public class PptNotesExtractor
{
    private readonly IFileSystem _fileSystem;

    public PptNotesExtractor(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
    }

    /*public IDictionary<int, string> ExtractNotesFromPowerPointFile(string filePath)
    {
        if (!_fileSystem.File.Exists(filePath))
        {
            throw new ArgumentException("File does not exist.", nameof(filePath));
        }

        var notesDictionary = new Dictionary<int, string>();

        using (PresentationDocument ppt = PresentationDocument.Open(filePath, false))
        {
            PresentationPart? presentationPart = ppt.PresentationPart;
            if (presentationPart != null)
            {
                int slideIndex = 1;
                foreach (var element in presentationPart.Presentation.SlideIdList.ChildElements)
                {
                    if (element is SlideId slideId && slideId.RelationshipId != null)
                    {
                        SlidePart? slidePart = (SlidePart?)presentationPart.GetPartById(slideId.RelationshipId);

                        if (slidePart?.NotesSlidePart != null)
                        {
                            string notesText = slidePart.NotesSlidePart.NotesSlide.InnerText;
                            notesDictionary.Add(slideIndex, notesText);
                        }

                        slideIndex++;
                    }
                }
            }
        }

        return notesDictionary;
    }*/

    public void ExtractNotesFromPowerPointFile(string filePath)
    {
        if (!_fileSystem.File.Exists(filePath))
        {
            throw new ArgumentException("File does not exist.", nameof(filePath));
        }

        using PresentationDocument ppt = PresentationDocument.Open(filePath, isEditable: false);
        PresentationPart? presentationPart = ppt.PresentationPart;
        if (presentationPart != null)
        {
            OpenXmlElementList childElements = presentationPart.Presentation.SlideIdList.ChildElements;
            foreach (OpenXmlElement element in childElements)
            {
                if (element is SlideId slideId && slideId.RelationshipId != null)
                {
                    SlidePart? slidePart = (SlidePart?)presentationPart.GetPartById(slideId.RelationshipId);

                    if (slidePart?.NotesSlidePart != null)
                    {
                        string notesText = slidePart.NotesSlidePart.NotesSlide.InnerText;

                        // Write the notes to a text file named after the slide id
                        string fileName = $"Notes\\{slideId.RelationshipId}.txt";
                        _fileSystem.Directory.CreateDirectory("Notes");
                        _fileSystem.File.WriteAllText(fileName, notesText);
                    }
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to the PowerPoint file as an argument.");
            Console.Write($"filePath = ");
            return;
        }

        var filePath = args[0];
        PptNotesExtractor? pptNotesExtractor = new(new FileSystem());

        try
        {
            pptNotesExtractor.ExtractNotesFromPowerPointFile(filePath);
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }
}