// See https://aka.ms/new-console-template for more information
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing;

//Creating new Document
PdfDocument pdfDocument = new PdfDocument();

//Adding new page
PdfPageBase page = pdfDocument.Pages.Add();

//Adding some text
page.Canvas.DrawString("Hello World, test SpirePDF", new PdfFont(PdfFontFamily.Helvetica, 12),
                new PdfSolidBrush(Color.Black),
                10, 10);

pdfDocument.SaveToFile("TestSpirePDF.pdf");
pdfDocument.Close();

