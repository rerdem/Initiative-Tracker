using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    
    public class Creature
    {
        public int Id { get; }
        public bool IsPlayer { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }
        public int Initiative { get; set; }
        public bool IsActive { get; set; }

        public Creature(int id, bool player, string name, string hp, int initiative, bool active)
        {
            Id = id;
            IsPlayer = player;
            Name = name;
            HP = hp;
            Initiative = initiative;
            IsActive = active;
        }
    }
}
