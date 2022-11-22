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
            IEnumerator<T> innerEnumerator = GetRecordsEnumerator();
            ResetEnumerator<T> resetEnumerator = new ResetEnumerator<T>(innerEnumerator, GetRecordsEnumerator);
            return resetEnumerator;
        }

        private IEnumerator<T> GetRecordsEnumerator()
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            {
                while (csv.Read())
                {
                    yield return csv.GetRecord<T>();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
