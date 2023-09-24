using DocumentFormat.OpenXml.Packaging;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PptxScraperGui
{
    public partial class MainForm : Form
    {
        private TextBox txtFilePath;

        public MainForm()
        {
            InitializeComponent();
            CreateControls();
        }

        private void CreateControls()
        {
            // Create and configure the TextBox
            txtFilePath = new TextBox
            {
                Name = "txtFilePath",
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            Controls.Add(txtFilePath);

            // Create and configure the Browse button
            btnBrowse = new Button
            {
                Name = "btnBrowse",
                Text = "&Browse",
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnBrowse.Click += btnBrowse_Click;
            Controls.Add(btnBrowse);

            // Create and configure the Extract button
            btnExtract = new Button
            {
                Name = "btnExtract",
                Text = "&Extract",
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnExtract.Click += btnExtract_Click;
            Controls.Add(btnExtract);

            // Set the form's properties
            Text = "PowerPoint Slide Text Extractor";
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void ExtractTextFromSlides(string filePath)
        {
            using (var presentationDocument = PresentationDocument.Open(filePath, false))
            {
                var presentationPart = presentationDocument.PresentationPart;
                var slideParts = presentationPart.SlideParts;

                int slideNumber = 1;
                foreach (var slidePart in slideParts)
                {
                    string slideText = string.Join(Environment.NewLine, slidePart.Slide.Descendants<DocumentFormat.OpenXml.Drawing.Text>().Select(t => t.Text));

                    string outputFile = $"{slideNumber}.txt";
                    File.WriteAllText(outputFile, slideText);

                    slideNumber++;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PowerPoint Presentations (*.pptx)|*.pptx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilePath.Text))
            {
                ExtractTextFromSlides(txtFilePath.Text);
                MessageBox.Show("Text extraction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a PowerPoint file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}