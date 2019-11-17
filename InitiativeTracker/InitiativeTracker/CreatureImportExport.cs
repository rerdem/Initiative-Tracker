using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker
{
    public class CreatureImportExport
    {
        public CreatureImportExport()
        {
        }

        public void exportToJSON(string path, List<Creature> creatureList)
        {
            int indexOfLastBackslash = path.LastIndexOf("\\");
            FileInfo file = new FileInfo(path.Substring(0, indexOfLastBackslash));
            file.Directory.Create();
            File.WriteAllText(path, JsonConvert.SerializeObject(creatureList, Formatting.Indented));
        }
    }
}