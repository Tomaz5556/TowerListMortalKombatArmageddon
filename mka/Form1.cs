namespace mka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private readonly string caminhoBanco = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "mka",
            "database.db"
        );

        private void CriarBanco()
        {
            // Cria a pasta caso não exista
            Directory.CreateDirectory(
                Path.GetDirectoryName(caminhoBanco)!
            );

            using var conexao = new Microsoft.Data.Sqlite.SqliteConnection(
                $"Data Source={caminhoBanco}"
            );

            conexao.Open();

            string sql = @"
            CREATE TABLE IF NOT EXISTS Dados (
                    Campo TEXT PRIMARY KEY,
                    Valor TEXT
                );
            ";
            using var comando = new Microsoft.Data.Sqlite.SqliteCommand(sql, conexao);
            comando.ExecuteNonQuery();
        }

        private void SalvarDados()
        {
            using var conexao = new Microsoft.Data.Sqlite.SqliteConnection(
                $"Data Source={caminhoBanco}"
            );

            conexao.Open();

            using var transacao = conexao.BeginTransaction();

            string sql = @"
                INSERT INTO Dados (Campo, Valor)
                VALUES (@Campo, @Valor)
                ON CONFLICT(Campo)
                DO UPDATE SET Valor = excluded.Valor;
            ";

            using var comando = new Microsoft.Data.Sqlite.SqliteCommand(sql, conexao, transacao);

            comando.Parameters.Add("@Campo", Microsoft.Data.Sqlite.SqliteType.Text);
            comando.Parameters.Add("@Valor", Microsoft.Data.Sqlite.SqliteType.Text);

            TextBox[] campos =
            {
                textBox127, textBox128, textBox129,
                textBox130, textBox131, textBox132,
                textBox133, textBox134, textBox135,
                textBox136, textBox137, textBox138,
                textBox139, textBox140, textBox141,
                textBox142, textBox143, textBox144
            };

            foreach (TextBox campo in campos)
            {
                comando.Parameters["@Campo"].Value = campo.Name;
                comando.Parameters["@Valor"].Value = campo.Text;

                comando.ExecuteNonQuery();
            }

            transacao.Commit();
        }

        private void CarregarDados()
        {
            using var conexao = new Microsoft.Data.Sqlite.SqliteConnection(
                $"Data Source={caminhoBanco}"
            );

            conexao.Open();

            string sql = "SELECT Campo, Valor FROM Dados;";

            using var comando = new Microsoft.Data.Sqlite.SqliteCommand(sql, conexao);

            using var leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                string nomeCampo = leitor.GetString(0);
                string valor = leitor.IsDBNull(1)
                    ? ""
                    : leitor.GetString(1);

                Control[] controles = Controls.Find(nomeCampo, true);

                if (controles.Length > 0 && controles[0] is TextBox campo)
                {
                    campo.Text = valor;
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(caminhoBanco))
            {
                CarregarDados();
            } else {
                CriarBanco();
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            try {
                SalvarDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao salvar os dados: " + ex.Message,
                    "Erro no banco de dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                e.Cancel = true;
            }
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
