namespace Kontrolna_robota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Army armiya = new Army();

            dataGridView1.Rows.Clear();

            for (int tr = 0; tr < this.numericUpDown1.Value; tr++)
            {
                Trolles T = new Trolles();
                armiya.AddUnit(T);
                dataGridView1.Rows.Add("���� � ������ ����", T.PrintCost(), T.PrintSpeed());
            }

            for (int dr = 0; dr < this.numericUpDown2.Value; dr++)
            {
                Dragon D = new Dragon();
                armiya.AddUnit(D);
                dataGridView1.Rows.Add("������", D.PrintCost(), D.PrintSpeed());
            }

            for (int gn = 0; gn < this.numericUpDown3.Value; gn++)
            {
                Gnome G = new Gnome();
                armiya.AddUnit(G);
                dataGridView1.Rows.Add("����� ������ �� ������� �������", G.PrintCost(), G.PrintSpeed());
            }

            dataGridView1.Rows.Add("�������", armiya.PrintTotalCost(), armiya.PrintTotalSpeed());

        }

    }
}