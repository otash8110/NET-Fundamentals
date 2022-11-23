using System.Collections;

namespace CSVEnumerable
{
    public class CsvEnumerator<T>: IEnumerator<T>
    {
        private IEnumerator<T> enumerator;

        private Func<IEnumerator<T>> resetFunction;

        public T Current => enumerator.Current;

        public CsvEnumerator(IEnumerator<T> enumerator, Func<IEnumerator<T>> resetFunction)
        {
            this.enumerator = enumerator;
            this.resetFunction = resetFunction;
        }

        object IEnumerator.Current => enumerator.Current;

        public void Dispose()
        {
            enumerator.Dispose();
        }

        public bool MoveNext()
        {
            return enumerator.MoveNext();
        }

        public void Reset()
        {
            enumerator = resetFunction();
        }
    }
}
