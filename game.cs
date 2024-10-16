using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr1
{
    public partial class game : Form
    {
        private int palochki = 15;
        private bool player1Turn = true;
        private Button[] stickButtons;
        public game()
        {
            InitializeComponent();
            SozdaniePalochek();
        }
        private void SozdaniePalochek()
        {
            stickButtons = new Button[palochki];
            for (int i = 0; i < palochki; i++)
            {
                Button stick = new Button
                {
                    Size = new Size(20, 100),
                    BackColor = Color.Brown,
                    Location = new Point(10 + i * 30, 100)
                };
                this.Controls.Add(stick);
                stickButtons[i] = stick;
            }
        }
        private void Obnovlenie()
        {
            label1.Text = $"Палочек осталось: {palochki}";
        }
        private void TakeSticks(int count)
        {
            if (count > 0 && count <= 3 && count <= palochki)
            {
                palochki = palochki - count;
                Obnovlenie();
                player1Turn = !player1Turn;
                label2.Text = $"Ход игрока {(player1Turn ? 1 : 2)}";

                for (int i = 0; i < count; i++)
                {
                    this.Controls.Remove(stickButtons[palochki]);
                    stickButtons[palochki] = null;
                }

                if (palochki == 0)
                {
                    MessageBox.Show($"Игрок {(player1Turn ? 2 : 1)} проиграл!");
                }
            }
            else
            {
                MessageBox.Show("Неверное количество палочек!");
            }
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TakeSticks(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TakeSticks(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TakeSticks(3);
        }
    }
}
