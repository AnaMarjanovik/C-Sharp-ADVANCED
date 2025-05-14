
using Task1.Entity;

Document document = new Document("My name is Ana.");
WebPage webPage = new WebPage("This is a html content.");


Console.WriteLine("Word 'Ana' is in the document: " + document.Search("Ana"));
Console.WriteLine("Word 'programing' is in the Web Page: " + webPage.Search("progrmaing"));

