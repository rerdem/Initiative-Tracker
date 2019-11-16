using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    
    class Creature
    {
        public int Id { get; }
        public bool IsPlayer { get; private set; }
        public string Name { get; private set; }
        public string HP { get; private set; }
        public int Initiative { get; private set; }

        public Creature(int id, bool player, string name, string hp, int initiative)
        {
            Id = id;
            IsPlayer = player;
            Name = name;
            HP = hp;
            Initiative = initiative;
        }

        public void updatePlayerStatus(bool isPlayer)
        {
            IsPlayer = isPlayer;
        }

        public void updateName(string name)
        {
            Name = name;
        }

        public void updateHP(string hp)
        {
            HP = hp;
        }

        public void updateInitiative(int initiative)
        {
            Initiative = initiative;
        }
    }
}
