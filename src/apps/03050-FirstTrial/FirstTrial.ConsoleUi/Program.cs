// See https://aka.ms/new-console-template for more information
using FirstTrial.ConsoleUi;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var reportGenerator = new ReportGenerator();

reportGenerator.Name = "SimpleValues";
reportGenerator.Title = "Simple Values";
reportGenerator.Description = "In this report, we want to generate a document displaying data of a customer (customer’s name, company, job title, address etc.). The template has one (default) data source representing a 'Customer' .NET object.";
reportGenerator.HelpTopicPage = "Examples_SimpleValueTemplating";
var reportDocumentFileName = reportGenerator.GenerateReport();

// Show it.
var process = new Process();

process.StartInfo = new ProcessStartInfo(reportDocumentFileName)
{
    UseShellExecute = true
};

process.Start();
