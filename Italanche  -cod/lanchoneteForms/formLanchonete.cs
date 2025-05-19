
using System.Data;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace lanchoneteForms
{
    public partial class formLanchonete : Form
    {
        int conn = 0;
        int contadorItens = 0;

        string connStr = "Data Source=172.16.255.252;User ID=240321_66_A_1_2024;Password=A12345678a;";

        public formLanchonete()
        {
            InitializeComponent();
            CarregarLanches();
            CarregarBebidas();
        }

        private void CarregarLanches()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT id, nome FROM Produtos";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nome = reader["nome"].ToString();
                        cmbLanche.Items.Add(nome);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os lanches: " + ex.Message);
            }
        }

        private void CarregarBebidas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT id, nome, preço FROM Bebidas";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nome = reader["nome"].ToString();
                        double preco = Convert.ToDouble(reader["preço"]);
                        cmbBeb.Items.Add($"{nome} - R${preco:N2}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar bebidas: {ex.Message}");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Horário: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void comboBoxLanche_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbLanche.SelectedItem == null)
                return;
            if (string.IsNullOrEmpty(txtQtd.Text))
            {
                txtQtd.Text = "1";
            }

            string nomeLanche = cmbLanche.SelectedItem.ToString();
            double preco = 0.0;

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                conn.Open();

                string query = "SELECT preço FROM Produtos WHERE nome = @nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nomeLanche);

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && double.TryParse(resultado.ToString(), out preco))
                    {

                        cmbPreço.Text = preco.ToString("C");


                        if (int.TryParse(txtQtd.Text, out int quantidade) && quantidade >= 0)
                        {
                            double valorTotal = preco * quantidade;
                            txtVitem.Text = valorTotal.ToString("C");
                        }
                        else
                        {
                            txtVitem.Text = preco.ToString("C");
                        }
                    }
                    else
                    {
                        cmbPreço.Text = "R$0,00";
                        txtVitem.Text = "R$0,00";
                    }

                }
            }
        }









        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            int numeroPedido = ObterProximoNumeroPedido();
            lblNumeroPedido.Text = numeroPedido.ToString();
            lblNumeroPedidoItens.Text = numeroPedido.ToString();

            btnPedidoXml.Enabled = true;
            btnPedidoTxt.Enabled = true;
            btnCancelar.Enabled = true;
            btnLancarItens.Enabled = true;
            btnResumoPedidos.Enabled = true;
            btnJson.Enabled = true;
        }

        private int ObterProximoNumeroPedido()
        {
            string caminho = "pedido.xml";
            if (!File.Exists(caminho)) return 1;

            try
            {
                var doc = XDocument.Load(caminho);
                var numeros = doc.Descendants("Pedido").Select(p => (int)p.Element("NumeroPedido"));
                return numeros.Any() ? numeros.Max() + 1 : 1;
            }
            catch
            {
                return 1;
            }
        }

        private void btnLancarItens_Click(object sender, EventArgs e)
        {
            TabPages.SelectTab(tbItem);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void radioButtonCondSim_CheckedChanged(object sender, EventArgs e)
        {
            GrbCOnd.Enabled = true;
        }

        private void radioButtonCondNao_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in GrbCOnd.Controls)
            {
                if (ctrl is CheckBox chk)
                    chk.Checked = false;
            }
            GrbCOnd.Enabled = false;
        }

        private void radioButtonBebSim_CheckedChanged(object sender, EventArgs e)
        {
            grbBeb.Enabled = true;
        }

        private void radioButtonBebNao_CheckedChanged(object sender, EventArgs e)
        {
            grbBeb.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbLanche.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um lanche primeiro!");
                    return;
                }


                string nomeLanche = cmbLanche.SelectedItem.ToString();
                double precoLanche = ObterPrecoDoBanco(nomeLanche, "Produtos");


                if (!int.TryParse(txtQtd.Text, out int quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("Quantidade inválida! Digite um número positivo.");
                    txtQtd.Text = "1";
                    return;
                }

                double totalLanche = precoLanche * quantidade;


                dataGridView1.Rows.Add(++conn, cmbLanche.SelectedItem, txtQtd.Text, cmbPreço.SelectedItem, txtVitem.Text.Substring(2));
                double valorTotal = double.Parse(lblValorTotal.Text.Replace("R$", "").Trim()) + double.Parse(txtVitem.Text.Replace("R$", "").Trim());



                if (radioButtonCondSim.Checked)
                {
                    foreach (Control ctrl in GrbCOnd.Controls)
                    {
                        if (ctrl is CheckBox cb && cb.Checked)
                        {
                            dataGridView1.Rows.Add("-> ", cb.Text, "", "", "");
                        }
                    }
                }
                if (radioButtonBebSim.Checked && cmbBeb.SelectedIndex >= 0)
                {
                    string bebidaTexto = cmbBeb.SelectedItem.ToString();
                    int i = bebidaTexto.IndexOf("$");
                    string valorBebidaStr = bebidaTexto.Substring(i + 1).Trim();

                    if (Double.TryParse(valorBebidaStr, out double number))
                    {
                        dataGridView1.Rows.Add(++conn, cmbBeb.Text, "1", "R$" + number.ToString("N2"), number.ToString("N2"));
                        valorTotal += number;
                    }
                    else
                    {
                        MessageBox.Show("Formato de valor da bebida inválido!");
                        return;
                    }
                }

                lblValorTotal.Text = valorTotal.ToString("C");
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private double ObterPrecoDoBanco(string nomeItem, string tabela)
        {
            double preco = 0;
            string query = $"SELECT preço FROM {tabela} WHERE nome = @nome";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nomeItem);
                    object result = cmd.ExecuteScalar();

                    if (result != null && !Convert.IsDBNull(result))
                    {
                        preco = Convert.ToDouble(result);
                    }
                }
            }
            return preco;
        }



        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;

            try
            {
                bool isCondimento = dataGridView1.CurrentRow.Cells["colunaItem"].Value?.ToString().Trim() == "->";
                bool isItemPrincipal = !isCondimento && dataGridView1.CurrentRow.Cells["colunaTotal"].Value != null;

                if (isCondimento)
                {

                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                else if (isItemPrincipal)
                {

                    double valorItem = double.Parse(dataGridView1.CurrentRow.Cells["colunaTotal"].Value.ToString()
                        .Replace("R$", "").Trim());

                    int rowIndex = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                    while (rowIndex < dataGridView1.Rows.Count &&
                           !dataGridView1.Rows[rowIndex].IsNewRow &&
                           dataGridView1.Rows[rowIndex].Cells["colunaItem"].Value?.ToString().Trim() == "->")
                    {
                        dataGridView1.Rows.RemoveAt(rowIndex);
                    }

                    double valorTotal = double.Parse(lblValorTotal.Text.Replace("R$", "").Trim());
                    lblValorTotal.Text = (valorTotal - valorItem).ToString("C");

                    ReordenarItens();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover item: {ex.Message}");
            }
        }

        private void ReordenarItens()
        {
            int novoNumeroItem = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["colunaItem"].Value != null)
                {
                    string valorAtual = row.Cells["colunaItem"].Value.ToString().Trim();


                    if (valorAtual != "->" && !string.IsNullOrEmpty(valorAtual))
                    {
                        row.Cells["colunaItem"].Value = novoNumeroItem++;
                    }
                }
            }
            conn = novoNumeroItem - 1;
        }

        private void btnPedidoXml_Click(object sender, EventArgs e)
        {
            string caminho = "pedido.xml";
            try
            {
                var doc = File.Exists(caminho) ? XDocument.Load(caminho) : new XDocument(new XElement("Pedidos"));

                XElement novoPedido = new XElement("Pedido",
                    new XElement("NumeroPedido", lblNumeroPedido.Text.Trim()),
                    new XElement("Cliente", textBoxCliente.Text.Trim()),
                    new XElement("DataPedido", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")),
                    new XElement("TotalPedido", lblValorTotal.Text.Replace("R$", "").Trim()),
                    new XElement("Observacao", textBoxObs.Text.Trim()),
                    new XElement("Itens", ObterItensParaXml()),
                    new XElement("Condimentos", ObterCondimentosParaXml())
                );

                doc.Root.Add(novoPedido);
                doc.Save(caminho);
                MessageBox.Show("Pedido salvo com sucesso em XML!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar XML: {ex.Message}");
            }
        }

        private List<XElement> ObterItensParaXml()
        {
            var itens = new List<XElement>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || row.Cells["colunaItem"].Value == null) continue;

                string valorItem = row.Cells["colunaItem"].Value.ToString().Trim();
                if (valorItem == "->") continue;

                itens.Add(new XElement("Item",
                    new XElement("NumeroItem", valorItem),
                    new XElement("Descricao", row.Cells["colunaDescricao"].Value?.ToString()),
                    new XElement("Quantidade", row.Cells["colunaQtd"].Value?.ToString()),
                    new XElement("PrecoUnitario", row.Cells["colunaValorUnid"].Value?.ToString()?.Replace("R$", "").Trim()),
                    new XElement("TotalItem", row.Cells["colunaTotal"].Value?.ToString()?.Replace("R$", "").Trim())
                ));
            }

            return itens;
        }

        private List<XElement> ObterCondimentosParaXml()
        {
            var condimentos = new List<XElement>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || row.Cells["colunaItem"].Value == null) continue;

                if (row.Cells["colunaItem"].Value.ToString().Trim() == "->")
                {
                    condimentos.Add(new XElement("Condimento",
                        row.Cells["colunaDescricao"].Value?.ToString()));
                }
            }

            return condimentos;
        }


        private void btnPedidoTxt_Click(object sender, EventArgs e)
        {
            string caminhoArqTxt = @"pedido_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Número do Pedido: " + lblNumeroPedido.Text.Trim());
            sb.AppendLine("Cliente: " + textBoxCliente.Text.Trim());
            sb.AppendLine("Data do Pedido: " + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("Total do Pedido: " + lblValorTotal.Text.Replace("R$", "").Trim());
            sb.AppendLine("Observação: " + textBoxObs.Text.Trim());
            sb.AppendLine("\nItens:");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var numeroItem = row.Cells["colunaItem"].Value?.ToString().Trim();
                var descricao = row.Cells["colunaDescricao"].Value?.ToString().Trim();
                var quantidade = row.Cells["colunaQtd"].Value?.ToString().Trim();
                var precoUnitario = row.Cells["colunaValorUnid"].Value?.ToString().Trim();
                var total = row.Cells["colunaTotal"].Value?.ToString().Trim();

                if (numeroItem == "->")
                {
                    sb.AppendLine("  - Condimento: " + descricao);
                }
                else
                {
                    sb.AppendLine($"  Item {numeroItem}: {descricao}");
                    sb.AppendLine($"    Quantidade: {quantidade}");
                    sb.AppendLine($"    Preço Unitário: {precoUnitario}");
                    sb.AppendLine($"    Total: {total}");
                    sb.AppendLine();
                }
            }

            File.WriteAllText(caminhoArqTxt, sb.ToString());
            MessageBox.Show("Pedido salvo com sucesso em TXT!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            conn = 0;
            dataGridView1.Rows.Clear();
            lblValorTotal.Text = 0.ToString("C");

            textBoxCliente.Clear();
            textBoxObs.Clear();
            txtQtd.Text = "1";
            txtVitem.Clear();
            cmbLanche.SelectedIndex = -1;


            cmbPreço.Text = "";
            cmbBeb.SelectedIndex = -1;


            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is CheckBox cb)
                    cb.Checked = false;
            }


            radioButtonCondNao.Checked = true;
            radioButtonBebNao.Checked = true;

            GrbCOnd.Enabled = false;
            grbBeb.Enabled = false;

            btnPedidoXml.Enabled = false;
            btnPedidoTxt.Enabled = false;
            btnCancelar.Enabled = false;
            btnLancarItens.Enabled = false;
            btnResumoPedidos.Enabled = false;

            TabPages.SelectTab(tbDp);
            lblNumeroPedido.Text = "?";
        }

        private void btnResumoPedidos_Click(object sender, EventArgs e)
        {
            TabPages.SelectTab(tbPr);

            StringBuilder resumo = new StringBuilder();


            resumo.AppendLine(
                $"{"Item".PadRight(15)}" +
                $"{"Descrição".PadRight(30)}" +
                $"{"Qtd".PadRight(10)}" +
                $"{"$Unid".PadRight(15)}" +
                $"{"Total".PadRight(15)}");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    string item = row.Cells["colunaItem"].Value?.ToString() ?? "";
                    string descricao = row.Cells["colunaDescricao"].Value?.ToString() ?? "";
                    string qtd = row.Cells["colunaQtd"].Value?.ToString() ?? "";
                    string valorUnid = row.Cells["colunaValorUnid"].Value?.ToString() ?? "";
                    string total = row.Cells["colunaTotal"].Value?.ToString() ?? "";

                    resumo.AppendLine(
                        $"{item.PadRight(15)}{descricao.PadRight(30)}{qtd.PadRight(10)}{valorUnid.PadRight(15)}{total.PadRight(15)}");
                }
            }

            lblResumo.Text += "Pedido N° ";
            lblResumo.Text += lblNumeroPedido.Text + "\n";
            lblResumo.Text += resumo.ToString();
            lblResumo.Text += "-------------------------------------" + "\n";

            MessageBox.Show("Resumo salvo");


        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            try
            {
                var pedido = new
                {
                    NumeroPedido = lblNumeroPedido.Text.Trim(),
                    Cliente = textBoxCliente.Text.Trim(),
                    DataPedido = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                    TotalPedido = lblValorTotal.Text.Replace("R$", "").Trim(),
                    Observacao = textBoxObs.Text.Trim(),
                    Itens = ObterItensDoGrid(),
                    Condimentos = ObterCondimentosDoGrid()
                };

                string json = JsonSerializer.Serialize(pedido, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });

                string caminhoArqJson = $"pedido_{pedido.NumeroPedido}_{DateTime.Now:yyyyMMddHHmmss}.json";
                File.WriteAllText(caminhoArqJson, json);

                MessageBox.Show($"Pedido salvo com sucesso em JSON!\nArquivo: {caminhoArqJson}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar JSON: {ex.Message}");
            }
        }

        private List<object> ObterItensDoGrid()
        {
            var itens = new List<object>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || row.Cells["colunaItem"].Value == null) continue;

                string valorItem = row.Cells["colunaItem"].Value.ToString().Trim();
                if (valorItem == "->") continue;

                itens.Add(new
                {
                    NumeroItem = valorItem,
                    Descricao = row.Cells["colunaDescricao"].Value?.ToString(),
                    Quantidade = row.Cells["colunaQtd"].Value?.ToString(),
                    PrecoUnitario = row.Cells["colunaValorUnid"].Value?.ToString()?.Replace("R$", "").Trim(),
                    TotalItem = row.Cells["colunaTotal"].Value?.ToString()?.Replace("R$", "").Trim()
                });
            }

            return itens;
        }

        private List<string> ObterCondimentosDoGrid()
        {
            var condimentos = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || row.Cells["colunaItem"].Value == null) continue;

                if (row.Cells["colunaItem"].Value.ToString().Trim() == "->")
                {
                    condimentos.Add(row.Cells["colunaDescricao"].Value?.ToString());
                }
            }

            return condimentos;
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQtd.Text) || !int.TryParse(txtQtd.Text, out _))
            {
                txtQtd.Text = "1";
            }

            if (cmbLanche.SelectedItem != null)
            {
                comboBoxLanche_SelectedIndexChanged(null, null);
            }
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}