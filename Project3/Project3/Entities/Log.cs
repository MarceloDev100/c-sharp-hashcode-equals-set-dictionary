namespace Project3.Entities
{
    class Log
    {
        public string Username { get; private set; }
        public string Instant { get; private set; }

        public Log(string username, DateTime instant)
        {
            Username = username;
            Instant = instant.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Log))
            {
                return false;
            }

            Log other = obj as Log;
            return Username.Equals(other.Username);
        }

        public override string ToString()
        {
            return $"{Username} {Instant} ";
        }
    }
}
