namespace Entities
{
    internal class Log
    {
        public string Name { get; private set; }
        public HashSet<DateTime> Logon {  get; private set; } = new HashSet<DateTime>();

        public Log(string name, DateTime log)
        {
            Name = name;
            Logon.Add(log);
        }
        public Log(string name)
        {
            Name = name;
        }
        public void AddLog(DateTime log)
        {
            Logon.Add(log);
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
