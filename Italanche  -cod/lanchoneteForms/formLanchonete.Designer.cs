namespace lanchoneteForms
{
    partial class formLanchonete
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLanchonete));
            groupBoxAcoes = new GroupBox();
            btnJson = new Button();
            btnFechar = new Button();
            btnResumoPedidos = new Button();
            btnCancelar = new Button();
            btnPedidoTxt = new Button();
            btnPedidoXml = new Button();
            btnNovoPedido = new Button();
            TabPages = new TabControl();
            tbDp = new TabPage();
            btnLancarItens = new Button();
            lblHora = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelData = new Label();
            textBoxObs = new TextBox();
            lblObs = new Label();
            textBoxCliente = new TextBox();
            lblCliente = new Label();
            lblNumeroPedido = new Label();
            lblPedido = new Label();
            tbItem = new TabPage();
            lblValorTotal = new Label();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            colunaItem = new DataGridViewTextBoxColumn();
            colunaDescricao = new DataGridViewTextBoxColumn();
            colunaQtd = new DataGridViewTextBoxColumn();
            colunaValorUnid = new DataGridViewTextBoxColumn();
            colunaTotal = new DataGridViewTextBoxColumn();
            lblNumeroPedidoItens = new Label();
            lblPedidoItens = new Label();
            groupBoxEscolha = new GroupBox();
            lblBarrinha = new Label();
            groupBox1 = new GroupBox();
            lblCodimentos = new Label();
            radioButtonCondNao = new RadioButton();
            radioButtonCondSim = new RadioButton();
            groupBox2 = new GroupBox();
            radioButtonBebNao = new RadioButton();
            radioButtonBebSim = new RadioButton();
            lblBebidas = new Label();
            grbBeb = new GroupBox();
            cmbBeb = new ComboBox();
            lblBebida = new Label();
            btnRemover = new Button();
            btnAdicionar = new Button();
            GrbCOnd = new GroupBox();
            checkBoxMolhoIngles = new CheckBox();
            checkBoxBatataPalha = new CheckBox();
            lblOpcoes = new Label();
            checkBoxPimenta = new CheckBox();
            checkBoxCatchup = new CheckBox();
            checkBoxMaionese = new CheckBox();
            checkBoxMostarda = new CheckBox();
            cmbPreço = new ComboBox();
            txtVitem = new TextBox();
            lblValorItem = new Label();
            txtQtd = new TextBox();
            lblQuantidade = new Label();
            lblPreco = new Label();
            cmbLanche = new ComboBox();
            lblLanche = new Label();
            tbPr = new TabPage();
            lblResumo = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            vScrollBar1 = new VScrollBar();
            groupBoxAcoes.SuspendLayout();
            TabPages.SuspendLayout();
            tbDp.SuspendLayout();
            tbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxEscolha.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grbBeb.SuspendLayout();
            GrbCOnd.SuspendLayout();
            tbPr.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAcoes
            // 
            groupBoxAcoes.BackColor = Color.Transparent;
            groupBoxAcoes.Controls.Add(btnJson);
            groupBoxAcoes.Controls.Add(btnFechar);
            groupBoxAcoes.Controls.Add(btnResumoPedidos);
            groupBoxAcoes.Controls.Add(btnCancelar);
            groupBoxAcoes.Controls.Add(btnPedidoTxt);
            groupBoxAcoes.Controls.Add(btnPedidoXml);
            groupBoxAcoes.Controls.Add(btnNovoPedido);
            groupBoxAcoes.ForeColor = SystemColors.Control;
            groupBoxAcoes.Location = new Point(12, 12);
            groupBoxAcoes.Name = "groupBoxAcoes";
            groupBoxAcoes.Size = new Size(1153, 126);
            groupBoxAcoes.TabIndex = 0;
            groupBoxAcoes.TabStop = false;
            groupBoxAcoes.Text = "Ações";
            // 
            // btnJson
            // 
            btnJson.BackColor = Color.DarkOrange;
            btnJson.Cursor = Cursors.Hand;
            btnJson.Enabled = false;
            btnJson.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnJson.Location = new Point(852, 27);
            btnJson.Name = "btnJson";
            btnJson.Size = new Size(143, 74);
            btnJson.TabIndex = 6;
            btnJson.Text = "Salvar Pedido Json";
            btnJson.UseVisualStyleBackColor = false;
            btnJson.Click += btnJson_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.DarkOrange;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnFechar.Location = new Point(1011, 22);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(123, 74);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnResumoPedidos
            // 
            btnResumoPedidos.BackColor = Color.DarkOrange;
            btnResumoPedidos.Cursor = Cursors.Hand;
            btnResumoPedidos.Enabled = false;
            btnResumoPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnResumoPedidos.Location = new Point(691, 27);
            btnResumoPedidos.Name = "btnResumoPedidos";
            btnResumoPedidos.Size = new Size(143, 74);
            btnResumoPedidos.TabIndex = 4;
            btnResumoPedidos.Text = "Resumo dos Pedidos";
            btnResumoPedidos.UseVisualStyleBackColor = false;
            btnResumoPedidos.Click += btnResumoPedidos_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkOrange;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnCancelar.Location = new Point(525, 27);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 74);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPedidoTxt
            // 
            btnPedidoTxt.BackColor = Color.DarkOrange;
            btnPedidoTxt.Cursor = Cursors.Hand;
            btnPedidoTxt.Enabled = false;
            btnPedidoTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnPedidoTxt.Location = new Point(359, 27);
            btnPedidoTxt.Name = "btnPedidoTxt";
            btnPedidoTxt.Size = new Size(143, 74);
            btnPedidoTxt.TabIndex = 2;
            btnPedidoTxt.Text = "Gravar Pedido TXT";
            btnPedidoTxt.UseVisualStyleBackColor = false;
            btnPedidoTxt.Click += btnPedidoTxt_Click;
            // 
            // btnPedidoXml
            // 
            btnPedidoXml.BackColor = Color.DarkOrange;
            btnPedidoXml.Cursor = Cursors.Hand;
            btnPedidoXml.Enabled = false;
            btnPedidoXml.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnPedidoXml.Location = new Point(189, 27);
            btnPedidoXml.Name = "btnPedidoXml";
            btnPedidoXml.Size = new Size(143, 74);
            btnPedidoXml.TabIndex = 1;
            btnPedidoXml.Text = "Gravar Pedido XML";
            btnPedidoXml.UseVisualStyleBackColor = false;
            btnPedidoXml.Click += btnPedidoXml_Click;
            // 
            // btnNovoPedido
            // 
            btnNovoPedido.BackColor = Color.DarkOrange;
            btnNovoPedido.Cursor = Cursors.Hand;
            btnNovoPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline);
            btnNovoPedido.Location = new Point(21, 27);
            btnNovoPedido.Name = "btnNovoPedido";
            btnNovoPedido.Size = new Size(143, 74);
            btnNovoPedido.TabIndex = 0;
            btnNovoPedido.Text = "Novo Pedido";
            btnNovoPedido.UseVisualStyleBackColor = false;
            btnNovoPedido.Click += btnNovoPedido_Click;
            // 
            // TabPages
            // 
            TabPages.Controls.Add(tbDp);
            TabPages.Controls.Add(tbItem);
            TabPages.Controls.Add(tbPr);
            TabPages.Location = new Point(12, 150);
            TabPages.Name = "TabPages";
            TabPages.SelectedIndex = 0;
            TabPages.Size = new Size(1003, 434);
            TabPages.TabIndex = 1;
            // 
            // tbDp
            // 
            tbDp.BackColor = Color.Transparent;
            tbDp.Controls.Add(btnLancarItens);
            tbDp.Controls.Add(lblHora);
            tbDp.Controls.Add(dateTimePicker1);
            tbDp.Controls.Add(labelData);
            tbDp.Controls.Add(textBoxObs);
            tbDp.Controls.Add(lblObs);
            tbDp.Controls.Add(textBoxCliente);
            tbDp.Controls.Add(lblCliente);
            tbDp.Controls.Add(lblNumeroPedido);
            tbDp.Controls.Add(lblPedido);
            tbDp.ForeColor = SystemColors.ControlLight;
            tbDp.Location = new Point(4, 24);
            tbDp.Name = "tbDp";
            tbDp.Padding = new Padding(3);
            tbDp.Size = new Size(995, 406);
            tbDp.TabIndex = 0;
            tbDp.Text = "Dados do Pedido";
            // 
            // btnLancarItens
            // 
            btnLancarItens.BackColor = Color.DarkOrange;
            btnLancarItens.Cursor = Cursors.Hand;
            btnLancarItens.Enabled = false;
            btnLancarItens.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLancarItens.ForeColor = SystemColors.Control;
            btnLancarItens.Location = new Point(754, 304);
            btnLancarItens.Name = "btnLancarItens";
            btnLancarItens.Size = new Size(218, 84);
            btnLancarItens.TabIndex = 6;
            btnLancarItens.Text = "Lançar Itens ⇉";
            btnLancarItens.UseVisualStyleBackColor = false;
            btnLancarItens.Click += btnLancarItens_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ActiveCaptionText;
            lblHora.Location = new Point(26, 330);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(109, 32);
            lblHora.TabIndex = 8;
            lblHora.Text = "Horário:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(186, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.BackColor = Color.Transparent;
            labelData.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelData.ForeColor = SystemColors.ActiveCaptionText;
            labelData.Location = new Point(26, 224);
            labelData.Name = "labelData";
            labelData.Size = new Size(74, 32);
            labelData.TabIndex = 6;
            labelData.Text = "Data:";
            // 
            // textBoxObs
            // 
            textBoxObs.Location = new Point(186, 141);
            textBoxObs.Multiline = true;
            textBoxObs.Name = "textBoxObs";
            textBoxObs.Size = new Size(247, 55);
            textBoxObs.TabIndex = 5;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.BackColor = Color.Transparent;
            lblObs.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblObs.ForeColor = SystemColors.ActiveCaptionText;
            lblObs.Location = new Point(26, 141);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(65, 32);
            lblObs.TabIndex = 4;
            lblObs.Text = "Obs:";
            // 
            // textBoxCliente
            // 
            textBoxCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCliente.Location = new Point(186, 92);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(247, 23);
            textBoxCliente.TabIndex = 3;
            textBoxCliente.TextChanged += textBoxCliente_TextChanged;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCliente.ForeColor = SystemColors.ActiveCaptionText;
            lblCliente.Location = new Point(26, 81);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(100, 32);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // lblNumeroPedido
            // 
            lblNumeroPedido.BorderStyle = BorderStyle.Fixed3D;
            lblNumeroPedido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroPedido.ForeColor = SystemColors.ActiveCaptionText;
            lblNumeroPedido.Location = new Point(186, 26);
            lblNumeroPedido.Name = "lblNumeroPedido";
            lblNumeroPedido.Size = new Size(51, 30);
            lblNumeroPedido.TabIndex = 1;
            lblNumeroPedido.Text = "?";
            lblNumeroPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.BackColor = Color.Transparent;
            lblPedido.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedido.ForeColor = SystemColors.ActiveCaptionText;
            lblPedido.Location = new Point(26, 27);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(122, 30);
            lblPedido.TabIndex = 0;
            lblPedido.Text = "Pedido N°:";
            // 
            // tbItem
            // 
            tbItem.BackColor = Color.Transparent;
            tbItem.Controls.Add(lblValorTotal);
            tbItem.Controls.Add(lblTotal);
            tbItem.Controls.Add(dataGridView1);
            tbItem.Controls.Add(lblNumeroPedidoItens);
            tbItem.Controls.Add(lblPedidoItens);
            tbItem.Controls.Add(groupBoxEscolha);
            tbItem.Location = new Point(4, 24);
            tbItem.Name = "tbItem";
            tbItem.Padding = new Padding(3);
            tbItem.Size = new Size(995, 406);
            tbItem.TabIndex = 1;
            tbItem.Text = "Itens";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.BackColor = Color.DarkOrange;
            lblValorTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorTotal.ForeColor = SystemColors.Control;
            lblValorTotal.Location = new Point(848, 376);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(72, 25);
            lblValorTotal.TabIndex = 5;
            lblValorTotal.Text = "R$ 0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.DarkOrange;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.Control;
            lblTotal.Location = new Point(786, 376);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colunaItem, colunaDescricao, colunaQtd, colunaValorUnid, colunaTotal });
            dataGridView1.Location = new Point(486, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(494, 303);
            dataGridView1.TabIndex = 3;
            // 
            // colunaItem
            // 
            colunaItem.HeaderText = "Item";
            colunaItem.MinimumWidth = 8;
            colunaItem.Name = "colunaItem";
            colunaItem.Width = 50;
            // 
            // colunaDescricao
            // 
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.MinimumWidth = 8;
            colunaDescricao.Name = "colunaDescricao";
            colunaDescricao.Width = 200;
            // 
            // colunaQtd
            // 
            colunaQtd.HeaderText = "Qtd";
            colunaQtd.MinimumWidth = 8;
            colunaQtd.Name = "colunaQtd";
            colunaQtd.Width = 50;
            // 
            // colunaValorUnid
            // 
            colunaValorUnid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colunaValorUnid.HeaderText = "$Unid";
            colunaValorUnid.MinimumWidth = 8;
            colunaValorUnid.Name = "colunaValorUnid";
            // 
            // colunaTotal
            // 
            colunaTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colunaTotal.HeaderText = "Total";
            colunaTotal.MinimumWidth = 8;
            colunaTotal.Name = "colunaTotal";
            // 
            // lblNumeroPedidoItens
            // 
            lblNumeroPedidoItens.AutoSize = true;
            lblNumeroPedidoItens.BackColor = Color.White;
            lblNumeroPedidoItens.Location = new Point(560, 38);
            lblNumeroPedidoItens.Name = "lblNumeroPedidoItens";
            lblNumeroPedidoItens.Size = new Size(12, 15);
            lblNumeroPedidoItens.TabIndex = 2;
            lblNumeroPedidoItens.Text = "?";
            // 
            // lblPedidoItens
            // 
            lblPedidoItens.AutoSize = true;
            lblPedidoItens.BackColor = Color.White;
            lblPedidoItens.Location = new Point(486, 38);
            lblPedidoItens.Name = "lblPedidoItens";
            lblPedidoItens.Size = new Size(64, 15);
            lblPedidoItens.TabIndex = 1;
            lblPedidoItens.Text = "Pedido N°:";
            // 
            // groupBoxEscolha
            // 
            groupBoxEscolha.Controls.Add(lblBarrinha);
            groupBoxEscolha.Controls.Add(groupBox1);
            groupBoxEscolha.Controls.Add(groupBox2);
            groupBoxEscolha.Controls.Add(grbBeb);
            groupBoxEscolha.Controls.Add(btnRemover);
            groupBoxEscolha.Controls.Add(btnAdicionar);
            groupBoxEscolha.Controls.Add(GrbCOnd);
            groupBoxEscolha.Controls.Add(cmbPreço);
            groupBoxEscolha.Controls.Add(txtVitem);
            groupBoxEscolha.Controls.Add(lblValorItem);
            groupBoxEscolha.Controls.Add(txtQtd);
            groupBoxEscolha.Controls.Add(lblQuantidade);
            groupBoxEscolha.Controls.Add(lblPreco);
            groupBoxEscolha.Controls.Add(cmbLanche);
            groupBoxEscolha.Controls.Add(lblLanche);
            groupBoxEscolha.ForeColor = SystemColors.ActiveCaptionText;
            groupBoxEscolha.Location = new Point(17, 26);
            groupBoxEscolha.Name = "groupBoxEscolha";
            groupBoxEscolha.Size = new Size(452, 376);
            groupBoxEscolha.TabIndex = 0;
            groupBoxEscolha.TabStop = false;
            groupBoxEscolha.Text = "Escolha";
            // 
            // lblBarrinha
            // 
            lblBarrinha.Location = new Point(1, 77);
            lblBarrinha.Name = "lblBarrinha";
            lblBarrinha.Size = new Size(442, 19);
            lblBarrinha.TabIndex = 7;
            lblBarrinha.Text = "_______________________________________________________________________________________________________________________________________";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCodimentos);
            groupBox1.Controls.Add(radioButtonCondNao);
            groupBox1.Controls.Add(radioButtonCondSim);
            groupBox1.Location = new Point(5, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 100);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // lblCodimentos
            // 
            lblCodimentos.AutoSize = true;
            lblCodimentos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodimentos.Location = new Point(8, 20);
            lblCodimentos.Name = "lblCodimentos";
            lblCodimentos.Size = new Size(145, 30);
            lblCodimentos.TabIndex = 8;
            lblCodimentos.Text = "Condimentos?";
            // 
            // radioButtonCondNao
            // 
            radioButtonCondNao.AutoSize = true;
            radioButtonCondNao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonCondNao.Location = new Point(78, 50);
            radioButtonCondNao.Name = "radioButtonCondNao";
            radioButtonCondNao.Size = new Size(57, 25);
            radioButtonCondNao.TabIndex = 10;
            radioButtonCondNao.TabStop = true;
            radioButtonCondNao.Text = "Não";
            radioButtonCondNao.UseVisualStyleBackColor = true;
            radioButtonCondNao.CheckedChanged += radioButtonCondNao_CheckedChanged;
            // 
            // radioButtonCondSim
            // 
            radioButtonCondSim.AutoSize = true;
            radioButtonCondSim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonCondSim.Location = new Point(15, 50);
            radioButtonCondSim.Name = "radioButtonCondSim";
            radioButtonCondSim.Size = new Size(55, 25);
            radioButtonCondSim.TabIndex = 9;
            radioButtonCondSim.TabStop = true;
            radioButtonCondSim.Text = "Sim";
            radioButtonCondSim.UseVisualStyleBackColor = true;
            radioButtonCondSim.CheckedChanged += radioButtonCondSim_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonBebNao);
            groupBox2.Controls.Add(radioButtonBebSim);
            groupBox2.Controls.Add(lblBebidas);
            groupBox2.Location = new Point(248, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // radioButtonBebNao
            // 
            radioButtonBebNao.AutoSize = true;
            radioButtonBebNao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonBebNao.Location = new Point(77, 50);
            radioButtonBebNao.Name = "radioButtonBebNao";
            radioButtonBebNao.Size = new Size(57, 25);
            radioButtonBebNao.TabIndex = 20;
            radioButtonBebNao.TabStop = true;
            radioButtonBebNao.Text = "Não";
            radioButtonBebNao.UseVisualStyleBackColor = true;
            radioButtonBebNao.CheckedChanged += radioButtonBebNao_CheckedChanged;
            // 
            // radioButtonBebSim
            // 
            radioButtonBebSim.AutoSize = true;
            radioButtonBebSim.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonBebSim.Location = new Point(14, 50);
            radioButtonBebSim.Name = "radioButtonBebSim";
            radioButtonBebSim.Size = new Size(55, 25);
            radioButtonBebSim.TabIndex = 19;
            radioButtonBebSim.TabStop = true;
            radioButtonBebSim.Text = "Sim";
            radioButtonBebSim.UseVisualStyleBackColor = true;
            radioButtonBebSim.CheckedChanged += radioButtonBebSim_CheckedChanged;
            // 
            // lblBebidas
            // 
            lblBebidas.AutoSize = true;
            lblBebidas.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBebidas.Location = new Point(8, 20);
            lblBebidas.Name = "lblBebidas";
            lblBebidas.Size = new Size(85, 30);
            lblBebidas.TabIndex = 18;
            lblBebidas.Text = "Bebidas";
            // 
            // grbBeb
            // 
            grbBeb.Controls.Add(cmbBeb);
            grbBeb.Controls.Add(lblBebida);
            grbBeb.Enabled = false;
            grbBeb.Location = new Point(256, 210);
            grbBeb.Name = "grbBeb";
            grbBeb.Size = new Size(187, 73);
            grbBeb.TabIndex = 26;
            grbBeb.TabStop = false;
            // 
            // cmbBeb
            // 
            cmbBeb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBeb.FormattingEnabled = true;
            cmbBeb.Location = new Point(17, 42);
            cmbBeb.Name = "cmbBeb";
            cmbBeb.Size = new Size(157, 23);
            cmbBeb.TabIndex = 22;
            // 
            // lblBebida
            // 
            lblBebida.AutoSize = true;
            lblBebida.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBebida.Location = new Point(6, 11);
            lblBebida.Name = "lblBebida";
            lblBebida.Size = new Size(76, 30);
            lblBebida.TabIndex = 21;
            lblBebida.Text = "Bebida";
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.DarkOrange;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.Location = new Point(272, 326);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(151, 32);
            btnRemover.TabIndex = 24;
            btnRemover.Text = "← Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.DarkOrange;
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Location = new Point(272, 289);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(151, 32);
            btnAdicionar.TabIndex = 23;
            btnAdicionar.Text = "Adicionar →";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // GrbCOnd
            // 
            GrbCOnd.Controls.Add(checkBoxMolhoIngles);
            GrbCOnd.Controls.Add(checkBoxBatataPalha);
            GrbCOnd.Controls.Add(lblOpcoes);
            GrbCOnd.Controls.Add(checkBoxPimenta);
            GrbCOnd.Controls.Add(checkBoxCatchup);
            GrbCOnd.Controls.Add(checkBoxMaionese);
            GrbCOnd.Controls.Add(checkBoxMostarda);
            GrbCOnd.Enabled = false;
            GrbCOnd.Location = new Point(5, 210);
            GrbCOnd.Margin = new Padding(3, 2, 3, 2);
            GrbCOnd.Name = "GrbCOnd";
            GrbCOnd.Padding = new Padding(3, 2, 3, 2);
            GrbCOnd.Size = new Size(245, 148);
            GrbCOnd.TabIndex = 18;
            GrbCOnd.TabStop = false;
            // 
            // checkBoxMolhoIngles
            // 
            checkBoxMolhoIngles.AutoSize = true;
            checkBoxMolhoIngles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMolhoIngles.Location = new Point(109, 74);
            checkBoxMolhoIngles.Name = "checkBoxMolhoIngles";
            checkBoxMolhoIngles.Size = new Size(119, 25);
            checkBoxMolhoIngles.TabIndex = 16;
            checkBoxMolhoIngles.Text = "Molho Inglês";
            checkBoxMolhoIngles.UseVisualStyleBackColor = true;
            // 
            // checkBoxBatataPalha
            // 
            checkBoxBatataPalha.AutoSize = true;
            checkBoxBatataPalha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxBatataPalha.Location = new Point(109, 103);
            checkBoxBatataPalha.Name = "checkBoxBatataPalha";
            checkBoxBatataPalha.Size = new Size(113, 25);
            checkBoxBatataPalha.TabIndex = 17;
            checkBoxBatataPalha.Text = "Batata Palha";
            checkBoxBatataPalha.UseVisualStyleBackColor = true;
            // 
            // lblOpcoes
            // 
            lblOpcoes.AutoSize = true;
            lblOpcoes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOpcoes.Location = new Point(5, 11);
            lblOpcoes.Name = "lblOpcoes";
            lblOpcoes.Size = new Size(83, 30);
            lblOpcoes.TabIndex = 11;
            lblOpcoes.Text = "Opções";
            // 
            // checkBoxPimenta
            // 
            checkBoxPimenta.AutoSize = true;
            checkBoxPimenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPimenta.Location = new Point(109, 49);
            checkBoxPimenta.Name = "checkBoxPimenta";
            checkBoxPimenta.Size = new Size(86, 25);
            checkBoxPimenta.TabIndex = 15;
            checkBoxPimenta.Text = "Pimenta";
            checkBoxPimenta.UseVisualStyleBackColor = true;
            // 
            // checkBoxCatchup
            // 
            checkBoxCatchup.AutoSize = true;
            checkBoxCatchup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxCatchup.Location = new Point(8, 49);
            checkBoxCatchup.Name = "checkBoxCatchup";
            checkBoxCatchup.Size = new Size(86, 25);
            checkBoxCatchup.TabIndex = 12;
            checkBoxCatchup.Text = "Catchup";
            checkBoxCatchup.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaionese
            // 
            checkBoxMaionese.AutoSize = true;
            checkBoxMaionese.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMaionese.Location = new Point(8, 103);
            checkBoxMaionese.Name = "checkBoxMaionese";
            checkBoxMaionese.Size = new Size(96, 25);
            checkBoxMaionese.TabIndex = 14;
            checkBoxMaionese.Text = "Maionese";
            checkBoxMaionese.UseVisualStyleBackColor = true;
            // 
            // checkBoxMostarda
            // 
            checkBoxMostarda.AutoSize = true;
            checkBoxMostarda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxMostarda.Location = new Point(8, 74);
            checkBoxMostarda.Name = "checkBoxMostarda";
            checkBoxMostarda.Size = new Size(95, 25);
            checkBoxMostarda.TabIndex = 13;
            checkBoxMostarda.Text = "Mostarda";
            checkBoxMostarda.UseVisualStyleBackColor = true;
            // 
            // cmbPreço
            // 
            cmbPreço.DropDownStyle = ComboBoxStyle.Simple;
            cmbPreço.Enabled = false;
            cmbPreço.FormattingEnabled = true;
            cmbPreço.Items.AddRange(new object[] { "23,90  ", "R$25,50  ", "R$24,80  ", "R$27,90  ", "R$22,70  ", "R$24,30  ", "R$21,50" });
            cmbPreço.Location = new Point(159, 49);
            cmbPreço.Name = "cmbPreço";
            cmbPreço.Size = new Size(88, 22);
            cmbPreço.TabIndex = 25;
            cmbPreço.SelectedIndexChanged += comboBoxLanche_SelectedIndexChanged;
            // 
            // txtVitem
            // 
            txtVitem.Enabled = false;
            txtVitem.Location = new Point(345, 49);
            txtVitem.Multiline = true;
            txtVitem.Name = "txtVitem";
            txtVitem.Size = new Size(97, 21);
            txtVitem.TabIndex = 7;
            // 
            // lblValorItem
            // 
            lblValorItem.AutoSize = true;
            lblValorItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorItem.Location = new Point(321, 18);
            lblValorItem.Name = "lblValorItem";
            lblValorItem.Size = new Size(112, 30);
            lblValorItem.TabIndex = 6;
            lblValorItem.Text = "Valor Item:";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(256, 49);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(84, 23);
            txtQtd.TabIndex = 5;
            txtQtd.TextChanged += txtQtd_TextChanged;
            txtQtd.KeyPress += txtQtd_KeyPress;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(256, 18);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(53, 30);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Qtd:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(159, 18);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(70, 30);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço:";
            // 
            // cmbLanche
            // 
            cmbLanche.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanche.FormattingEnabled = true;
            cmbLanche.Location = new Point(5, 49);
            cmbLanche.Name = "cmbLanche";
            cmbLanche.Size = new Size(148, 23);
            cmbLanche.TabIndex = 1;
            cmbLanche.SelectedIndexChanged += comboBoxLanche_SelectedIndexChanged;
            // 
            // lblLanche
            // 
            lblLanche.AutoSize = true;
            lblLanche.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLanche.Location = new Point(5, 18);
            lblLanche.Name = "lblLanche";
            lblLanche.Size = new Size(84, 30);
            lblLanche.TabIndex = 0;
            lblLanche.Text = "Lanche:";
            // 
            // tbPr
            // 
            tbPr.BackColor = Color.DarkOrange;
            tbPr.Controls.Add(lblResumo);
            tbPr.Location = new Point(4, 24);
            tbPr.Name = "tbPr";
            tbPr.Size = new Size(995, 406);
            tbPr.TabIndex = 2;
            tbPr.Text = "Resumo dos Pedidos";
            // 
            // lblResumo
            // 
            lblResumo.AccessibleRole = AccessibleRole.ScrollBar;
            lblResumo.Location = new Point(145, 16);
            lblResumo.Multiline = true;
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(685, 378);
            lblResumo.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1107, 155);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(8, 8);
            vScrollBar1.TabIndex = 2;
            // 
            // formLanchonete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1189, 607);
            Controls.Add(vScrollBar1);
            Controls.Add(TabPages);
            Controls.Add(groupBoxAcoes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formLanchonete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItaLanches";
            groupBoxAcoes.ResumeLayout(false);
            TabPages.ResumeLayout(false);
            tbDp.ResumeLayout(false);
            tbDp.PerformLayout();
            tbItem.ResumeLayout(false);
            tbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxEscolha.ResumeLayout(false);
            groupBoxEscolha.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grbBeb.ResumeLayout(false);
            grbBeb.PerformLayout();
            GrbCOnd.ResumeLayout(false);
            GrbCOnd.PerformLayout();
            tbPr.ResumeLayout(false);
            tbPr.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAcoes;
        private Button btnCancelar;
        private Button btnPedidoTxt;
        private Button btnPedidoXml;
        private Button btnNovoPedido;
        private Button btnFechar;
        private Button btnResumoPedidos;
        private TabControl TabPages;
        private TabPage tbDp;
        private TabPage tbItem;
        private TextBox textBoxCliente;
        private Label lblCliente;
        private Label lblNumeroPedido;
        private Label lblPedido;
        private TabPage tbPr;
        private Label labelData;
        private TextBox textBoxObs;
        private Label lblObs;
        private Label lblHora;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private Button btnLancarItens;
        private GroupBox groupBoxEscolha;
        private ComboBox cmbLanche;
        private Label lblLanche;
        private Label lblPreco;
        private Label lblQuantidade;
        private TextBox txtVitem;
        private Label lblValorItem;
        private TextBox txtQtd;
        private Label lblCodimentos;
        private Label lblOpcoes;
        private RadioButton radioButtonCondNao;
        private RadioButton radioButtonCondSim;
        private RadioButton radioButtonBebNao;
        private RadioButton radioButtonBebSim;
        private Label lblBebidas;
        private CheckBox checkBoxBatataPalha;
        private CheckBox checkBoxMolhoIngles;
        private CheckBox checkBoxPimenta;
        private CheckBox checkBoxMaionese;
        private CheckBox checkBoxMostarda;
        private CheckBox checkBoxCatchup;
        private Button btnAdicionar;
        private ComboBox cmbBeb;
        private Label lblBebida;
        private Button btnRemover;
        private Label lblNumeroPedidoItens;
        private Label lblPedidoItens;
        private DataGridView dataGridView1;
        private Label lblValorTotal;
        private Label lblTotal;
        private ComboBox cmbPreço;
        private GroupBox GrbCOnd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbBeb;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn colunaItem;
        private DataGridViewTextBoxColumn colunaDescricao;
        private DataGridViewTextBoxColumn colunaQtd;
        private DataGridViewTextBoxColumn colunaValorUnid;
        private DataGridViewTextBoxColumn colunaTotal;
        private Label lblBarrinha;
        private Button btnJson;
        private TextBox lblResumo;
        private VScrollBar vScrollBar1;
    }
}
