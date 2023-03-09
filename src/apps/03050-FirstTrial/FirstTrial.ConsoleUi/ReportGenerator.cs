using Docentric.Documents.ObjectModel;
using Docentric.Documents.Reporting;
using FirstTrial.Models;
// using FirstTrial.ConsoleUi.Models;
using System.Reflection;

namespace FirstTrial.ConsoleUi
{
    internal class ReportGenerator
    {
        public string Name { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string HelpTopicPage { get; set; } = default!;
        public string DirectoryPath { get; set; } = default!;
        public SaveOptions SaveOptions { get; set; }
        public string TemplateFileName
        {
            get
            {
                var tempPath = Path.Combine(ApplicationPath, "FirstTemplate.docx");
                return tempPath;
            }
        }
        protected string ApplicationPath
        {
            get
            {
                return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            }
        }
        public ReportGenerator()
        {
            SaveOptions = SaveOptions.Word;
        }
        protected string OutputDocumentFileExtension
        {
            get
            {
                if (SaveOptions is WordSaveOptions) return ".docx";
                else if (SaveOptions is PdfSaveOptions) return ".pdf";
                else if (SaveOptions is XpsSaveOptions) return ".xps";
                else throw new Exception("Unsupported 'SaveOptions' object.");
            }
        }

        public string GenerateReport()
        {
            // Get the customer object with the Id = 15.
            var customer = new Customer() { 
                Id = 1, FirstName = "Vivek", LastName = "Koppula", 
                JobTitle = "Developer", Company = "Yoo Enterprises",
                Address = new Address { City = "Pune", Country = "India", PostalCode = "411111" }
            };

            // Create a temporary file for the generated report document.
            var reportDocumentFileName = Path.Combine(ApplicationPath, "GeneratedReport_" + Guid.NewGuid().ToString() + OutputDocumentFileExtension);

            using (Stream reportDocumentStream = File.Create(reportDocumentFileName))
            {
                // Open the report template file.
                using (Stream reportTemplateStream = GetReportTemplate())
                {
                    // Generate the report document using 'DocumentGenerator'.
                    var documentGenerator = new DocumentGenerator(customer);
                    var documentGenerationResult = documentGenerator.GenerateDocument(reportTemplateStream, reportDocumentStream, SaveOptions);
                    if (documentGenerationResult.HasErrors)
                    {
                        foreach (Error error in documentGenerationResult.Errors)
                            Console.Out.WriteLine(error.Message);
                    }

                    Console.WriteLine($"File created at {reportDocumentFileName}");
                    Console.WriteLine("Take a look at that !!!");

                }
            }

            return reportDocumentFileName!;
        }

        protected Stream GetReportTemplate()
        {
            if (!File.Exists(TemplateFileName))
            {
                throw new Exception(string.Format("Report template '{0}' is not found", TemplateFileName));
            }
            return File.Open(TemplateFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }
    }
}
