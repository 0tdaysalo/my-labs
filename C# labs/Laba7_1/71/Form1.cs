using System;
using System.Windows.Forms;
using _71.lib;

namespace _71
{
    public partial class Form1 : Form
    {
        public Game game = new Game();
        public Form1()
        {
            InitializeComponent();
            update_money();
            dataGridView1.DataSource = game.objects;
        }

        public void update_money()
        {
            money_label.Text = game.Money.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Money += 1000;
            update_money();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.buy_WatchTower();
            update_money();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.reduce_hp(dataGridView1.SelectedRows[0].Index);
            if (game.objects[dataGridView1.SelectedRows[0].Index].HP == 0)
            {
                game.objects.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.add_hp(dataGridView1.SelectedRows[0].Index);
            dataGridView1.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.upgrate(dataGridView1.SelectedRows[0].Index);
            update_money();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (((WatchTower)game.objects[dataGridView1.SelectedRows[0].Index]).isEnemyFound())
            {
                MessageBox.Show("враг найден");
            }
            else
            {
                MessageBox.Show("враг не найден");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ((GuardTower)game.objects[dataGridView1.SelectedRows[0].Index]).KillEnemy();
        }
    }
}
