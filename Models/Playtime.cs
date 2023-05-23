using System;

namespace TamagotchiAPI.Models
{
    public class Playtime
    {
        public int Id { get; set; }
        public DateTime When { get; set; } = DateTime.UtcNow;
        public int PetId { get; set; }
        public Pet Pet{ get; set; }
    }
}