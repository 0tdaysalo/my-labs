namespace _6_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint n, m;
            if (uint.TryParse(textBox1.Text, out n) && uint.TryParse(textBox2.Text, out m))
            {
               
                dataGridView1.Columns.Clear();

                for (int i = 0; i < m; i++)
                {
                    var col = new DataGridViewTextBoxColumn();
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns.Add(col);
                }

                for (int i = 0; i < m; i++)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);
                    for (int j = 1; j < m; j++)
                    {
                        row.Cells[j].Value = i * j;                 
                    }
                    dataGridView1.Rows.Add(row);
                }

            }
        }
    }
}
