using System.Collections;

namespace Laba8_1
{
    public partial class Form1 : Form
    {
        private BindedArrayList arrayList = new BindedArrayList();
        private delegate void Cleanup(ArrayList arrayList);
        private Dictionary<string, Cleanup> actions;


        public Form1()
        {
            InitializeComponent();
            arrayList.Bind(listBox1);
            actions = new Dictionary<string, Cleanup>
            {
                { "заменить пробелы на знак «_»", replace_space },
                { "заменить «/» на «\\»", replace_slash },
                { "заменить «/» на «//»", replace_back_slash },
                { "перевести буквы в верхний регистр.", to_upp }
            };
            comboBox1.Items.AddRange(actions.Keys.ToArray());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0) return;
            if (numericUpDown1.Value >= arrayList.Count && numericUpDown1.Value != 0) return;
            int p = (int)numericUpDown1.Value;
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                if (textBox1.Lines[i].Trim().Length == 0) continue;
                arrayList.Insert(p, textBox1.Lines[i]);
                p++;
            }
            textBox1.Text = "";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            arrayList.SetCapacity((int)numericUpDown2.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            actions[(string)comboBox1.SelectedItem](arrayList);
            arrayList.Update();
        }
    }
}
