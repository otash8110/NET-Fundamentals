using CSVEnumerable;
using CSVEnumerable.CsvModels;

var csvItems = new CsvEnumerable<Person>("document.csv");

foreach (var item in csvItems)
{
    Console.WriteLine($"{item.Name}, {item.Id}");
}