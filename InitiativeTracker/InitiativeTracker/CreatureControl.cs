﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace InitiativeTracker
{
    public class CreatureControl : UserControl
    {
        private CreatureManager creatureManager;

        // Create the controls.
        private TextBox nameText;
        private CheckBox isPlayerCheckbox;
        private TextBox hpText;
        private NumericUpDown initiativeValue;
        private Label nameLabel;
        private Label hpLabel;
        private Label initiativeLabel;
        private Button deleteButton;
        private Panel creaturePanel;
        
        public int CreatureId { get; private set; }

        // Define the constructor.
        public CreatureControl(CreatureManager inputList, int inputId, bool inputIsPlayer, string inputName, string inputHP, int inputInitiative, bool inputActive)
        {
            creatureManager = inputList;
            InitializeComponent(inputId, inputIsPlayer, inputName, inputHP, inputInitiative, inputActive);
        }

        public string getName()
        {
            return nameText.Text;
        }

        public int getInitiative()
        {
            return (int) initiativeValue.Value;
        }

        // Initialize the control elements.
        public void InitializeComponent(int inputId, bool inputIsPlayer, string inputName, string inputHP, int inputInitiative, bool inputActive)
        {
            CreatureId = inputId;

           // Initialize the controls.
            creaturePanel = new Panel();
            nameText = new TextBox();
            isPlayerCheckbox = new CheckBox();
            hpText = new TextBox();
            initiativeValue = new NumericUpDown();
            nameLabel = new Label();
            hpLabel = new Label();
            initiativeLabel = new Label();
            deleteButton = new Button();

            // Set control settings
            creaturePanel.Location = new Point(0, 0);
            creaturePanel.Size = new Size(400, 67);
            if (inputActive)
            {
                creaturePanel.BorderStyle = BorderStyle.Fixed3D;
                creaturePanel.BackColor = Color.LightGreen;
            }
            else
            {
                creaturePanel.BorderStyle = BorderStyle.FixedSingle;
                creaturePanel.BackColor = DefaultBackColor;
            }
            
            nameLabel.Location = new Point(3, 3);
            nameLabel.Size = new Size(80, 25);
            nameLabel.Text = "Name:";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            isPlayerCheckbox.Location = new Point(143, 3);
            isPlayerCheckbox.Size = new Size(70, 25);
            isPlayerCheckbox.Text = "Is Player:";
            isPlayerCheckbox.Checked = inputIsPlayer;
            isPlayerCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            isPlayerCheckbox.CheckStateChanged += IsPlayer_CheckStateChanged;

            nameText.Location = new Point(3, 28);
            nameText.Size = new Size(210, 30);
            nameText.Text = inputName;
            nameText.Font = new Font(nameText.Font.FontFamily, 16);
            nameText.TextChanged += NameText_TextChanged;

            hpLabel.Location = new Point(216, 3);
            hpLabel.Size = new Size(50, 25);
            hpLabel.Text = "HP:";
            hpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            hpText.Location = new Point(216, 28);
            hpText.Size = new Size(50, 30);
            hpText.Text = inputHP;
            hpText.Font = new Font(nameText.Font.FontFamily, 16);
            hpText.TextChanged += HPText_TextChanged;

            initiativeLabel.Location = new Point(269, 3);
            initiativeLabel.Size = new Size(50, 25);
            initiativeLabel.Text = "Initiative:";
            initiativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            initiativeValue.Location = new Point(269, 28);
            initiativeValue.Size = new Size(50, 30);
            initiativeValue.Font = new Font(initiativeValue.Font.FontFamily, 16);
            //initiativeValue.ReadOnly = true;
            initiativeValue.Minimum = -99;
            initiativeValue.Maximum = 99;
            initiativeValue.Value = inputInitiative;
            initiativeValue.ValueChanged += InitiativeValue_ValueChanged;

            deleteButton.Location = new Point(332, 3);
            deleteButton.Size = new Size(58, 58);
            deleteButton.Text = "X";
            deleteButton.Font = new Font(deleteButton.Font.Name, 20, FontStyle.Bold);
            deleteButton.TabStop = false;
            deleteButton.Click += DeleteButton_Click;

            // Add the controls to the user control.
            creaturePanel.Controls.AddRange(new Control[]
            {
            nameLabel,
            isPlayerCheckbox,
            nameText,
            hpLabel,
            hpText,
            initiativeLabel,
            initiativeValue,
            deleteButton
            });

            Controls.Add(creaturePanel);

            // Size the user control.
            Size = new Size(400, 67);
        }

        private void IsPlayer_CheckStateChanged(object sender, EventArgs e)
        {
            creatureManager.updatePlayerStatus(CreatureId, isPlayerCheckbox.Checked);
        }

        private void InitiativeValue_ValueChanged(object sender, EventArgs e)
        {
            creatureManager.updateInitiative(CreatureId, (int) initiativeValue.Value);
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            creatureManager.updateName(CreatureId, nameText.Text);
        }

        private void HPText_TextChanged(object sender, EventArgs e)
        {
            creatureManager.updateHP(CreatureId, hpText.Text);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            creatureManager.remove(CreatureId);
        }
    }
}