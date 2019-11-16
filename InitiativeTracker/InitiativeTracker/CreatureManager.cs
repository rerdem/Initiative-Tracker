using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    public class CreatureManager
    {
        private List<Creature> creatureList;
        private int idCounter;

        internal List<Creature> CreatureList { get => creatureList; }

        public CreatureManager()
        {
            creatureList = new List<Creature>();
            idCounter = 0;
        }

        public void add()
        {
            creatureList.Add(new Creature(idCounter, false, "Name", "0", 0));
            idCounter++;
        }

        public void add(bool isPlayer, string name, string hp, int initiative)
        {
            if (initiative > 99)
            {
                initiative = 99;
            }

            if (initiative < -99)
            {
                initiative = -99;
            }

            creatureList.Add(new Creature(idCounter, isPlayer, name, hp, initiative));
            idCounter++;
        }

        public void updatePlayerStatus(int id, bool isPlayer)
        {
            int index = creatureList.FindIndex(c => c.Id == id);
            creatureList.ElementAt(index).updatePlayerStatus(isPlayer);
        }

        public void updateName(int id, string name)
        {
            int index = creatureList.FindIndex(c => c.Id == id);
            creatureList.ElementAt(index).updateName(name);
        }

        public void updateHP(int id, string hp)
        {
            int index = creatureList.FindIndex(c => c.Id == id);
            creatureList.ElementAt(index).updateHP(hp);
        }

        public void updateInitiative(int id, int initiative)
        {
            if (initiative > 99)
            {
                initiative = 99;
            }

            if (initiative < -99)
            {
                initiative = -99;
            }

            int index = creatureList.FindIndex(c => c.Id == id);
            creatureList.ElementAt(index).updateInitiative(initiative);
        }

        public void remove(int id)
        {
            creatureList.RemoveAt(creatureList.FindIndex(c => c.Id == id));
        }

        public void sortByDescendingInitiative()
        {
            creatureList = creatureList.OrderByDescending(c => c.Initiative).ToList();
        }
    }
}
