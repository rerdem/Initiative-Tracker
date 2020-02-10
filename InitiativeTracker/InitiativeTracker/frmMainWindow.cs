using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InitiativeTracker
{
    public partial class frmMainWindow : Form
    {
        private CreatureManager creatureManager;
        
        public frmMainWindow(CreatureManager inputCreatureManager)
        {
            creatureManager = inputCreatureManager;
            creatureManager.CreatureRemoved += new EventHandler(creatureManager_CreatureRemoved);
            
            InitializeComponent();
            
            refreshPanel();
            refreshStatusbar();
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
                flowLayoutPanel.Controls.Add(new CreatureControl(creatureManager, creature.Id, creature.IsPlayer, creature.Name, creature.HP, creature.Initiative, creature.IsActive));
            }
        }

        private void refreshStatusbar()
        {
            if (creatureManager.InCombat)
            {
                roundLabel.Visible = true;
                roundNumberLabel.Visible = true;
                roundNumberLabel.Text = creatureManager.RoundCounter.ToString();
            }
            else
            {
                roundLabel.Visible = false;
                roundNumberLabel.Visible = false;
            }
        }

        private void addStripButton_Click(object sender, EventArgs e)
        {
            creatureManager.add();
            refreshPanel();
        }

        private void sortStripButton_Click(object sender, EventArgs e)
        {
            creatureManager.sortByDescendingInitiative();
            refreshPanel();
        }

        private void exportStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Encounter...";
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveDialog.DefaultExt = "json";
            saveDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.CheckPathExists = true;
            saveDialog.RestoreDirectory = false;
            saveDialog.FileName = "new encounter.json";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                creatureManager.exportCurrentEncounter(saveDialog.FileName);
            }
        }

        private void importStripButton_ButtonClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Import Encounter...";
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.CheckPathExists = true;
                openDialog.RestoreDirectory = false;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    creatureManager.importEncounter(openDialog.FileName);
                }
            }
            refreshPanel();
        }

        private void importOnlyCreaturesItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Import Encounter...";
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.CheckPathExists = true;
                openDialog.RestoreDirectory = false;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    creatureManager.importEncounter(openDialog.FileName, false);
                }
            }
            refreshPanel();
        }

        private void importOnlyPlayersItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = "Import Encounter...";
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openDialog.FilterIndex = 1;
                openDialog.CheckPathExists = true;
                openDialog.RestoreDirectory = false;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    creatureManager.importEncounter(openDialog.FileName, true);
                }
            }
            refreshPanel();
        }

        private void startStripButton_Click(object sender, EventArgs e)
        {
            creatureManager.startCombat();
            refreshPanel();
            refreshStatusbar();
        }

        private void stopStripButton_Click(object sender, EventArgs e)
        {
            creatureManager.stopCombat();
            refreshPanel();
            refreshStatusbar();
        }

        private void prevStripButton_Click(object sender, EventArgs e)
        {
            creatureManager.regressCombat();
            refreshPanel();
            refreshStatusbar();
        }

        private void nextStripButton_Click(object sender, EventArgs e)
        {
            creatureManager.progressCombat();
            refreshPanel();
            refreshStatusbar();
        }

        private void creatureManager_CreatureRemoved(object sender, EventArgs e)
        {
            refreshPanel();
            refreshStatusbar();
        }
    }
}