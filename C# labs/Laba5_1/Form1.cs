using System;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace laba5_1
{
    public partial class Form1 : Form
    {
        List<Bride> array_man = new List<Bride>();

        List<Groom> array_woman = new List<Groom>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim().Length != 0)
            {
                Bride Man = new Bride(textBox1.Text);

                if (checkBox1.Checked)
                {
                    Man.properties |= ManProperties.SMART;
                }
                if (checkBox2.Checked)
                {
                    Man.properties |= ManProperties.BEAUT;
                }
                if (checkBox3.Checked)
                {
                    Man.properties |= ManProperties.RICH;
                }


                if (checkBox9.Checked)
                {
                    Man.wish_properties |= WomanProperties.SMART;
                }
                if (checkBox8.Checked)
                {
                    Man.wish_properties |= WomanProperties.BEAUTIFUL;
                }
                if (checkBox7.Checked)
                {
                    Man.wish_properties |= WomanProperties.HONESTY;
                }


                listMan.Items.Add(textBox1.Text);
                array_man.Add(Man);
                textBox1.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox9.Checked = false;
                checkBox8.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length != 0)
            {
                Groom Woman = new Groom(textBox2.Text);
                if (checkBox4.Checked)
                {
                    Woman.properties |= WomanProperties.SMART;
                }
                if (checkBox5.Checked)
                {
                    Woman.properties |= WomanProperties.BEAUTIFUL;
                }
                if (checkBox6.Checked)
                {
                    Woman.properties |= WomanProperties.HONESTY;
                }

                if (checkBox12.Checked)
                {
                    Woman.wish_properties |= ManProperties.SMART;
                }
                if (checkBox11.Checked)
                {
                    Woman.wish_properties |= ManProperties.BEAUT;
                }
                if (checkBox10.Checked)
                {
                    Woman.wish_properties |= ManProperties.RICH;
                }

                listWoman.Items.Add(textBox2.Text);
                array_woman.Add(Woman);
                textBox2.Clear();
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void listMan_Click(object sender, EventArgs e)
        {
            if (listMan.SelectedIndex != -1)
            {
                Bride selected = array_man[listMan.SelectedIndex];
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"фамилия: {selected.surname}\n"); ;
                sb.AppendFormat($"собственные качества: {selected.properties}\n");
                sb.AppendFormat($"желаемые качества в женщинах: {selected.wish_properties}\n");

                sb.AppendFormat("наиболее подходящие люди (сортировка): ");
                selected.rateGrooms(array_woman).ForEach((men) =>
                {
                    sb.AppendFormat(men.surname + ", ");
                });

                MessageBox.Show(sb.ToString(), "информация о мужчине");
            }
        }

        private void listWoman_Click(object sender, EventArgs e)
        {
            if (listWoman.SelectedIndex != -1)
            {
                Groom selected = array_woman[listWoman.SelectedIndex];

                selected.rateBride(array_man);

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"фамилия: {selected.surname}\n"); ;
                sb.AppendFormat($"собственные качества: {selected.properties}\n");
                sb.AppendFormat($"желаемые качества в мужчинах: {selected.wish_properties}\n");

                sb.AppendFormat($"наиболее подходящие люди (сортировка): ");
                selected.rateBride(array_man).ForEach((men) =>
                {
                    sb.AppendFormat(men.surname + ", ");
                });

                MessageBox.Show(sb.ToString(), "информация о женщине");
            }
        }

    }
}
