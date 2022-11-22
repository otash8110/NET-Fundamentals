using CSVEnumerable;
using CSVEnumerable.CsvModels;

var csvItems = new CsvEnumerable<Person>("document.csv");

var enumerator = csvItems.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine($"{enumerator.Current.Name}, {enumerator.Current.Id}");
}

enumerator.Reset();

while (enumerator.MoveNext())
{
    Console.WriteLine($"{enumerator.Current.Name}, {enumerator.Current.Id}");
}