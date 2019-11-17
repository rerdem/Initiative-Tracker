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
        private CreatureImportExport ImportExport { get; }

        internal List<Creature> CreatureList { get => creatureList; }

        public CreatureManager()
        {
            creatureList = new List<Creature>();
            idCounter = 0;
            ImportExport = new CreatureImportExport();
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
            creatureList.ElementAt(index).IsPlayer = isPlayer;
        }

        public void updateName(int id, string name)
        {
            int index = creatureList.FindIndex(c => c.Id == id);
            creatureList.ElementAt(index).Name = name;
        }

        public void updateHP(int id, string hp)
        {
            int index = creatureList.FindIndex(c => c.Id == id);
            creatureList.ElementAt(index).HP = hp;
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
            creatureList.ElementAt(index).Initiative = initiative;
        }

        public void remove(int id)
        {
            creatureList.RemoveAt(creatureList.FindIndex(c => c.Id == id));
        }

        public void sortByDescendingInitiative()
        {
            creatureList = creatureList.OrderByDescending(c => c.Initiative).ToList();
        }

        public void exportCurrentEncounter(string path)
        {
            ImportExport.exportToJSON(path, creatureList);
        }

        /// <summary>
        /// replaces current creature list with full imported list from JSON file
        /// </summary>
        /// <param name="path">JSON file path</param>
        public void importEncounter(string path)
        {
            List<Creature> importedCreatureList = ImportExport.importFromJson(path);

            creatureList.Clear();

            foreach (Creature c in importedCreatureList)
            {
                //Debug.WriteLine(c.IsPlayer);
                add(c.IsPlayer, c.Name, c.HP, c.Initiative);
            }
        }

        /// <summary>
        /// adds the imported entities from the JSON file to the current creature list
        /// </summary>
        /// <param name="path">JSON file path</param>
        /// <param name="importPlayers">true imports only player characters, false imports only creatures (analogous to isPlayer property of Creatures)</param>
        public void importEncounter(string path, bool importPlayers)
        {
            List<Creature> importedCreatureList = ImportExport.importFromJson(path);

            foreach (Creature c in importedCreatureList)
            {
                if (c.IsPlayer == importPlayers)
                {
                    add(c.IsPlayer, c.Name, c.HP, c.Initiative);
                }
            }
        }
    }
}
