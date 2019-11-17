﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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
                flowLayoutPanel.Controls.Add(new CreatureControl(creatureManager, creature.Id, creature.IsPlayer, creature.Name, creature.HP, creature.Initiative));
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
            saveDialog.Title = "Save encounter...";
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveDialog.DefaultExt = "json";
            saveDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;
            saveDialog.CheckPathExists = true;
            saveDialog.FileName = "new encounter.json";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                creatureManager.exportCurrentEncounter(saveDialog.FileName);
            }
        }
    }
}