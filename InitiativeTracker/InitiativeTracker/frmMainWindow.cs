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
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Add(new CreatureControl());
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            List<CreatureControl> creatureList = flowLayoutPanel.Controls.Cast<CreatureControl>().ToList();
            creatureList.Sort();
            creatureList.Reverse();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.Controls.AddRange(creatureList.ToArray());
        }
    }
}