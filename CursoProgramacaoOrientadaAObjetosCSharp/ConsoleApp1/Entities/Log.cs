namespace Entities
{
    internal class Log
    {
        public string Name { get; private set; }
        public DateTime Logon { get; private set; }

        public Log(string name, DateTime log)
        {
            Name = name;
            Logon = log;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Log)) return false;
            Log other = obj as Log;
            return Name == other.Name;
        }
    }
}
