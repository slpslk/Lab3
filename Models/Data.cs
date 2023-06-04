using System;

namespace Lab1_3.Models
{
    public class PlayerData
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Nickname { get; set; }
        public int Level { get; set; }
        public string Clan { get; set; }
        public string Country { get; set; }
    }
}