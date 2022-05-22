// See https://aka.ms/new-console-template for more information
using Builder.Commons;
using Builder.Models;

CarBundleBuilder? builder = null;

// Create the builder according to the choice of the user.
var validChoice = false;
while (!validChoice)
{
    Console.WriteLine("Do you want build HTML (1) or PDF (2) bundle?");
    var choice = Console.ReadLine();

    builder = choice switch
    {
        "1" => new HtmlCarBundleBuilder(),
        "2" => new PdfCarBundleBuilder(),
        _ => null,
    };

    if (builder != null)
        validChoice = true;
    else
    {
        validChoice = false;
        Console.WriteLine($"Error: The choice {choice} is not valid. \n");
    }
}

Vendor vendor = new(builder!);

Bundle? bundle = vendor.Build("Jimmy");
bundle?.Print();
