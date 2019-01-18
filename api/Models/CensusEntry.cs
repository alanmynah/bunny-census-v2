using System;

namespace api.Models
{
    public class CensusEntry
    {
        public int Id { get; set; }
        public Bunny Bunny { get; set; }
        public int BunnyId { get; set; }
        private DateTime Timestamp { get; set; }

        public CensusEntry()
        {
            Timestamp = DateTime.Now;
        }
    }
}