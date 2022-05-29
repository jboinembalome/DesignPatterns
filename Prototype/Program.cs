// See https://aka.ms/new-console-template for more information
using Prototype.Models.Bundles;
using Prototype.Models.Clients;
using Prototype.Models.Documents;

// Create a bundle with three empty documents (our prototypes)
EmptyBundle emptyBundle = EmptyBundle.Instance(); // Using the singleton pattern here
emptyBundle.Add(new PurchaseOrderDocument());
emptyBundle.Add(new AssignmentCertificateDocument());
emptyBundle.Add(new ApplicationRegistrationDocument());

// Create a list of clients
var clients = new Client[]
{
    new()
    {
        Id = 1,
        FirstName = "Jimmy",
        LastName = "Boinembalome",
        Birthday = new DateTime(1994, 10, 14)
    },
    new()
    {
        Id = 2,
        FirstName = "Gwendoline",
        LastName = "Boinembalome",
        Birthday = new DateTime(1989, 4, 26)
    }
};

// Create a bundle for each client that will populate our documents
// with the client's information and then display them
foreach (var client in clients)
{
    ClientBundle clientBundle = new(client);
    clientBundle.DisplayDocuments();
}