using System.Collections;

namespace CSVEnumerable
{
    public class ResetEnumerator<T>: IEnumerator<T>
    {
        private IEnumerator<T> Enumerator;

        private Func<IEnumerator<T>> ResetFunction;

        public T Current => Enumerator.Current;

        public ResetEnumerator(IEnumerator<T> enumerator, Func<IEnumerator<T>> resetFunction)
        {
            Enumerator = enumerator;
            ResetFunction = resetFunction;
        }

        object IEnumerator.Current => Enumerator.Current;

        public void Dispose()
        {
            Enumerator.Dispose();
        }

        public bool MoveNext()
        {
            return Enumerator.MoveNext();
        }

        public void Reset()
        {
            Enumerator = ResetFunction();
        }
    }
}
