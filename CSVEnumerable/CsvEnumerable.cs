using CsvHelper;
using System.Collections;
using System.Globalization;

namespace CSVEnumerable
{
    public class CsvEnumerable<T> : IEnumerable<T>
    {
        private readonly string path;

        public CsvEnumerable(string path)
        {
            this.path = path;
        }

        public IEnumerator<T> GetEnumerator()
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())
                {
                    yield return csv.GetRecord<T>();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
