namespace Aula213
{
    class PrintService<Type>
    {
        private Type[] _values = new Type[10];
        private int _count = 0;

        public void AddValue(Type value)
        {
            if (_count == 10) throw new InvalidOperationException("PrintService is full");
            else
            {
                _values[_count] = value;
                _count++;
            }
        }

        public object First()
        {
            if (_count != 0) return _values[0];
            else throw new InvalidOperationException("PrintService is emptry");
        }

        public void Print()
        {
            if (_count != 0)
            {
                Console.Write($"[");
                for (int i = 0; i < _count - 1; i++) Console.Write($"{_values[i]}, ");
                Console.WriteLine($"{_values[_count - 1]}]");
            }
            else throw new InvalidOperationException("PrintService is empty");
        }
    }
}
