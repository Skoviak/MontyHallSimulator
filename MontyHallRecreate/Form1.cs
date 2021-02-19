using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontyHallRecreate
{
    public partial class MontyHall : Form
    {
        List<Door> doors = new List<Door>();
        int wins = 0;
        int losses = 0;
        Random rnd = new Random();
        Timer timer = new Timer();

        // Simulation of the Monty Hall problem in statistics: https://en.wikipedia.org/wiki/Monty_Hall_problem
        public MontyHall()
        {
            InitializeComponent();

            RefreshDoors();

            cbxModeSelection.Items.Add("Stay");
            cbxModeSelection.Items.Add("Switch");

            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }
        private void TimerTick(object Sender, EventArgs e)
        {
            if (cbxModeSelection.SelectedIndex <= 0)
            {
                if (RunStayTest() == 1) wins += 1;
                else losses += 1;
            }
            if (cbxModeSelection.SelectedIndex == 1)
            {
                if (RunSwitchTest() == 1) wins += 1;
                else losses += 1;
            }
            wins_label.Text = "Wins: " + wins;
            losses_label.Text = "Losses: " + losses;
        }

        private int RunSwitchTest()
        {
            RefreshDoors();

            int forge_selector = rnd.Next(0, 3); // Randomize where the forge is.
            int reveal_selector = rnd.Next(0, 3); // Randomize which door is revealed.
            int selection_selector = rnd.Next(0, 3); // Randomize which door is initially selected.
            while (reveal_selector == forge_selector || reveal_selector == selection_selector) reveal_selector = rnd.Next(0, 3); // Ensure the revealed door is not the initiall door or the door with the forge.


            for (int door_number = 0; door_number < 3; door_number++)
            {
                if (door_number == forge_selector) // If the door has the cosmic forge...
                {
                    doors[door_number].isCosmicForge = true; // ...set the property.
                }
                if (door_number != selection_selector && door_number != reveal_selector) // If the door is not the initial selection or the revealed door...
                {
                    doors[door_number].isSelected = true; // ...we switch to it!
                }
            }

            foreach (Door d in doors)
            {
                if (d.isCosmicForge && d.isSelected)
                {
                    d.imagePath = "..\\img\\quill.jpg"; // TODO: Fix relative paths
                    DrawDoors();
                    return 1;
                }
                if (!d.isCosmicForge && d.isSelected)
                {
                    d.imagePath = "..\\img\\cosmichorror.jpg";
                    DrawDoors();
                    return 0;
                }
            }

            return 0;
        }

        private int RunStayTest()
        {
            RefreshDoors();

            int forge_selector = rnd.Next(0, 3); // Randomize where the forge is.
            int reveal_selector = rnd.Next(0, 3); // Randomize which door is revealed.
            int selection_selector = rnd.Next(0, 3); // Randomize which door is initially selected.
            while (reveal_selector == forge_selector || reveal_selector == selection_selector) reveal_selector = rnd.Next(0, 3); // Ensure the revealed door is not the initiall door or the door with the forge.


            for (int door_number = 0; door_number < 3; door_number++)
            {
                if (door_number == forge_selector) // If the door has the cosmic forge...
                {
                    doors[door_number].isCosmicForge = true; // ...set the property.
                }
                if (door_number != forge_selector) // If the door does not have the cosmic forge...
                {
                    // ... do nothing.
                }
                if (door_number == selection_selector) // If the door is the initial selection...
                {
                    doors[door_number].isSelected = true; // ...we stick with it!
                }
            }

            DrawDoors();

            foreach (Door d in doors)
            {
                if (d.isCosmicForge && d.isSelected)
                {
                    d.imagePath = "..\\img\\quill.jpg";
                    DrawDoors();
                    return 1;
                }
                if (!d.isCosmicForge && d.isSelected)
                {
                    d.imagePath = "..\\img\\cosmichorror.jpg";
                    DrawDoors();
                    return 0;
                }
            }

            return 0;
        }

        private void RefreshDoors()
        {
            doors.Clear();
            for (int i = 1; i <= 3; i++)
            {
                Door door = new Door();
                door.number = i;
                door.imagePath = "..\\img\\blackhole.jpg";
                doors.Add(door);
            }
            DrawDoors();
        }

        private void DrawDoors()
        {

            door_1.ImageLocation = @doors[0].imagePath;
            door_2.ImageLocation = @doors[1].imagePath;
            door_3.ImageLocation = @doors[2].imagePath;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            wins = 0;
            losses = 0;
            wins_label.Text = "Wins:";
            losses_label.Text = "Losses:";
            RefreshDoors();
        }
    }
}
