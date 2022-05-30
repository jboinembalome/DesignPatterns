// See https://aka.ms/new-console-template for more information
using Adapter.Models;

IDocument document = new HtmlDocument();
document.Content = "Hello!";
document.Draw();
document.Print();

Console.WriteLine();

document = new PdfDocument();
document.Content = "Hi!";
document.Draw();
document.Print();