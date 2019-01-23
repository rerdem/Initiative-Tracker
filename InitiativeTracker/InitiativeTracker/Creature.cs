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
        public string Name { get; private set; }
        public int Initiative { get; private set; }

        public Creature(int id, string name, int initiative)
        {
            Id = id;
            Name = name;
            Initiative = initiative;
        }

        public void updateName(string name)
        {
            Name = name;
        }

        public void updateInitiative(int initiative)
        {
            Initiative = initiative;
        }
    }
}
