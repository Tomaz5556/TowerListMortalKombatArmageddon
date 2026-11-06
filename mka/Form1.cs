namespace mka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PintarColuna(TableLayoutPanel table, int col, bool preenchido)
        {
            Color colorcol = preenchido ? Color.Green : Color.White;

            for (int row = 0; row < 8; row++)
            {
                Control? controle = table.GetControlFromPosition(col, row);

                if (controle != null)
                {
                    controle.BackColor = colorcol;
                }
            }
        }

        private void textBox127_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 0, !string.IsNullOrWhiteSpace(textBox127.Text));
        }

        private void textBox128_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 1, !string.IsNullOrWhiteSpace(textBox128.Text));
        }

        private void textBox129_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 2, !string.IsNullOrWhiteSpace(textBox129.Text));
        }

        private void textBox130_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 3, !string.IsNullOrWhiteSpace(textBox130.Text));
        }

        private void textBox131_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 4, !string.IsNullOrWhiteSpace(textBox131.Text));
        }

        private void textBox132_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 5, !string.IsNullOrWhiteSpace(textBox132.Text));
        }

        private void textBox133_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 6, !string.IsNullOrWhiteSpace(textBox133.Text));
        }

        private void textBox134_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 7, !string.IsNullOrWhiteSpace(textBox134.Text));
        }

        private void textBox135_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel2, 8, !string.IsNullOrWhiteSpace(textBox135.Text));
        }

        private void textBox136_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 0, !string.IsNullOrWhiteSpace(textBox136.Text));
        }

        private void textBox137_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 1, !string.IsNullOrWhiteSpace(textBox137.Text));
        }

        private void textBox138_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 2, !string.IsNullOrWhiteSpace(textBox138.Text));
        }

        private void textBox139_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 3, !string.IsNullOrWhiteSpace(textBox139.Text));
        }

        private void textBox140_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 4, !string.IsNullOrWhiteSpace(textBox140.Text));
        }

        private void textBox141_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 5, !string.IsNullOrWhiteSpace(textBox141.Text));
        }

        private void textBox142_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 6, !string.IsNullOrWhiteSpace(textBox142.Text));
        }

        private void textBox143_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 7, !string.IsNullOrWhiteSpace(textBox143.Text));
        }

        private void textBox144_TextChanged(object sender, EventArgs e)
        {
            PintarColuna(tableLayoutPanel3, 8, !string.IsNullOrWhiteSpace(textBox144.Text));
        }
    }
}
