using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace InitiativeTracker
{
    public class CreatureControls : UserControl
    {
        // Create the controls.
        private TextBox nameText;
        private NumericUpDown initiativeValue;
        private Label nameLabel;
        private Label initiativeLabel;
        private Button deleteButton;
        private Panel creaturePanel;

        // Define the constructor.
        public CreatureControls()
        {
            InitializeComponent();
        }

        public int getInitiative()
        {
            return (int) initiativeValue.Value;
        }

        // Initialize the control elements.
        public void InitializeComponent()
        {
            // Initialize the controls.
            creaturePanel = new Panel();
            nameText = new TextBox();
            initiativeValue = new NumericUpDown();
            nameLabel = new Label();
            initiativeLabel = new Label();
            deleteButton = new Button();

            // Set control settings
            creaturePanel.BorderStyle = BorderStyle.FixedSingle;
            creaturePanel.Location = new Point(0, 0);
            creaturePanel.Size = new Size(400, 67);

            deleteButton.Location = new Point(3, 3);
            deleteButton.Size = new Size(58, 58);
            deleteButton.Text = "X";
            deleteButton.Click += DeleteButton_Click;

            nameLabel.Location = new Point(64, 3);
            nameLabel.Size = new Size(80, 25);
            nameLabel.Text = "Name:";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            nameText.Location = new Point(64, 28);
            nameText.Size = new Size(250, 30);
            nameText.Text = "Name";
            nameText.Font = new Font(nameText.Font.FontFamily, 16);

            initiativeLabel.Location = new Point(317, 3);
            initiativeLabel.Size = new Size(80, 25);
            initiativeLabel.Text = "Initiative:";
            initiativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            initiativeValue.Location = new Point(317, 28);
            initiativeValue.Size = new Size(50, 30);
            initiativeValue.Font = new Font(initiativeValue.Font.FontFamily, 16);
            initiativeValue.ReadOnly = true;
            initiativeValue.Minimum = -99;
            initiativeValue.Maximum = 99;
            initiativeValue.Value = 0;

            // Add the controls to the user control.
            creaturePanel.Controls.AddRange(new Control[]
            {
            deleteButton,
            nameLabel,
            nameText,
            initiativeLabel,
            initiativeValue
            });

            Controls.Add(creaturePanel);

            // Size the user control.
            Size = new Size(400, 67);


            //// Add the controls to the user control.
            //Controls.AddRange(new Control[]
            //{
            //deleteButton,
            //nameLabel,
            //nameText,
            //initiativeLabel,
            //initiativeValue
            //});

            //// Size the user control.
            //Size = new Size(400, 64);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}