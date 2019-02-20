using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InitiativeTracker
{
    public partial class frmMainWindow : Form
    {
        private CreatureManager creatureManager;

        public frmMainWindow(CreatureManager inputCreatureManager)
        {
            creatureManager = inputCreatureManager;
            InitializeComponent();
        }

        private void refreshPanel()
        {
            foreach (CreatureControl c in flowLayoutPanel.Controls)
            {
                c.Dispose();
            }

            flowLayoutPanel.Controls.Clear();

            foreach (Creature creature in creatureManager.CreatureList)
            {
                flowLayoutPanel.Controls.Add(new CreatureControl(creatureManager, creature.Id, creature.Name, creature.HP, creature.Initiative));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            creatureManager.add();
            refreshPanel();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            creatureManager.sortByDescendingInitiative();
            refreshPanel();
        }
    }
}