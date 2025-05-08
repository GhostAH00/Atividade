namespace AtividadeDesk
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DgvRegistro = new ReaLTaiizor.Controls.PoisonDataGridView();
            clnId = new DataGridViewTextBoxColumn();
            ClnIdUsuario = new DataGridViewTextBoxColumn();
            clnEntrada = new DataGridViewTextBoxColumn();
            clnSaida = new DataGridViewTextBoxColumn();
            clnOperacao = new DataGridViewTextBoxColumn();
            clnHorario = new DataGridViewTextBoxColumn();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            txtNomeFiltro = new ReaLTaiizor.Controls.AloneTextBox();
            btnFiltrar = new ReaLTaiizor.Controls.AirButton();
            dtpDataFiltro = new ReaLTaiizor.Controls.PoisonDateTime();
            cmbTipoOperacaoFiltro = new ReaLTaiizor.Controls.DungeonComboBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            ((System.ComponentModel.ISupportInitialize)DgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // DgvRegistro
            // 
            DgvRegistro.AllowUserToAddRows = false;
            DgvRegistro.AllowUserToDeleteRows = false;
            DgvRegistro.AllowUserToResizeRows = false;
            DgvRegistro.BackgroundColor = Color.CadetBlue;
            DgvRegistro.BorderStyle = BorderStyle.None;
            DgvRegistro.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DgvRegistro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRegistro.Columns.AddRange(new DataGridViewColumn[] { clnId, ClnIdUsuario, clnEntrada, clnSaida, clnOperacao, clnHorario });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            DgvRegistro.EnableHeadersVisualStyles = false;
            DgvRegistro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            DgvRegistro.GridColor = SystemColors.MenuHighlight;
            DgvRegistro.HighLightPercentage = 0.3F;
            DgvRegistro.Location = new Point(59, 205);
            DgvRegistro.Name = "DgvRegistro";
            DgvRegistro.ReadOnly = true;
            DgvRegistro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvRegistro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvRegistro.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRegistro.Size = new Size(685, 300);
            DgvRegistro.TabIndex = 0;
            DgvRegistro.CellContentClick += DgvRegistro_CellContentClick;
            // 
            // clnId
            // 
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 70;
            // 
            // ClnIdUsuario
            // 
            ClnIdUsuario.HeaderText = "Nome";
            ClnIdUsuario.Name = "ClnIdUsuario";
            ClnIdUsuario.ReadOnly = true;
            ClnIdUsuario.Width = 80;
            // 
            // clnEntrada
            // 
            clnEntrada.HeaderText = "Entrada";
            clnEntrada.Name = "clnEntrada";
            clnEntrada.ReadOnly = true;
            clnEntrada.Width = 120;
            // 
            // clnSaida
            // 
            clnSaida.HeaderText = "Saida";
            clnSaida.Name = "clnSaida";
            clnSaida.ReadOnly = true;
            clnSaida.Width = 120;
            // 
            // clnOperacao
            // 
            clnOperacao.HeaderText = "Operação";
            clnOperacao.Name = "clnOperacao";
            clnOperacao.ReadOnly = true;
            // 
            // clnHorario
            // 
            clnHorario.HeaderText = "Horario";
            clnHorario.Name = "clnHorario";
            clnHorario.ReadOnly = true;
            clnHorario.Width = 150;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Mongolian Baiti", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.SteelBlue;
            bigLabel1.Location = new Point(239, 27);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(313, 35);
            bigLabel1.TabIndex = 24;
            bigLabel1.Text = "ULTIMOS ACESSOS";
            // 
            // metroControlBox1
            // 
            metroControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox1.CloseHoverForeColor = Color.White;
            metroControlBox1.CloseNormalForeColor = Color.Gray;
            metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox1.DisabledForeColor = Color.DimGray;
            metroControlBox1.IsDerivedStyle = true;
            metroControlBox1.Location = new Point(700, -2);
            metroControlBox1.MaximizeBox = true;
            metroControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroControlBox1.MinimizeBox = true;
            metroControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroControlBox1.Name = "metroControlBox1";
            metroControlBox1.Size = new Size(100, 25);
            metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox1.StyleManager = null;
            metroControlBox1.TabIndex = 25;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroLight";
            // 
            // txtNomeFiltro
            // 
            txtNomeFiltro.BackColor = Color.Transparent;
            txtNomeFiltro.EnabledCalc = true;
            txtNomeFiltro.Font = new Font("Segoe UI", 9F);
            txtNomeFiltro.ForeColor = Color.FromArgb(124, 133, 142);
            txtNomeFiltro.Location = new Point(59, 158);
            txtNomeFiltro.MaxLength = 32767;
            txtNomeFiltro.MultiLine = false;
            txtNomeFiltro.Name = "txtNomeFiltro";
            txtNomeFiltro.ReadOnly = false;
            txtNomeFiltro.Size = new Size(685, 29);
            txtNomeFiltro.TabIndex = 26;
            txtNomeFiltro.TextAlign = HorizontalAlignment.Left;
            txtNomeFiltro.UseSystemPasswordChar = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnFiltrar.Font = new Font("Segoe UI", 9F);
            btnFiltrar.Image = null;
            btnFiltrar.Location = new Point(59, 89);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NoRounding = false;
            btnFiltrar.Size = new Size(100, 29);
            btnFiltrar.TabIndex = 28;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Transparent = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpDataFiltro
            // 
            dtpDataFiltro.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpDataFiltro.Location = new Point(424, 89);
            dtpDataFiltro.MinimumSize = new Size(0, 29);
            dtpDataFiltro.Name = "dtpDataFiltro";
            dtpDataFiltro.Size = new Size(320, 29);
            dtpDataFiltro.TabIndex = 29;
            dtpDataFiltro.ValueChanged += dtpDataFiltro_ValueChanged;
            // 
            // cmbTipoOperacaoFiltro
            // 
            cmbTipoOperacaoFiltro.BackColor = Color.FromArgb(246, 246, 246);
            cmbTipoOperacaoFiltro.ColorA = Color.SteelBlue;
            cmbTipoOperacaoFiltro.ColorB = Color.SteelBlue;
            cmbTipoOperacaoFiltro.ColorC = Color.FromArgb(242, 241, 240);
            cmbTipoOperacaoFiltro.ColorD = Color.FromArgb(253, 252, 252);
            cmbTipoOperacaoFiltro.ColorE = Color.FromArgb(239, 237, 236);
            cmbTipoOperacaoFiltro.ColorF = Color.FromArgb(180, 180, 180);
            cmbTipoOperacaoFiltro.ColorG = Color.FromArgb(119, 119, 118);
            cmbTipoOperacaoFiltro.ColorH = Color.FromArgb(224, 222, 220);
            cmbTipoOperacaoFiltro.ColorI = Color.FromArgb(250, 249, 249);
            cmbTipoOperacaoFiltro.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTipoOperacaoFiltro.DropDownHeight = 100;
            cmbTipoOperacaoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoOperacaoFiltro.Font = new Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoOperacaoFiltro.ForeColor = Color.FromArgb(76, 76, 97);
            cmbTipoOperacaoFiltro.FormattingEnabled = true;
            cmbTipoOperacaoFiltro.HoverSelectionColor = Color.Empty;
            cmbTipoOperacaoFiltro.IntegralHeight = false;
            cmbTipoOperacaoFiltro.ItemHeight = 20;
            cmbTipoOperacaoFiltro.Items.AddRange(new object[] { "Entrada", "Saída" });
            cmbTipoOperacaoFiltro.Location = new Point(186, 92);
            cmbTipoOperacaoFiltro.Name = "cmbTipoOperacaoFiltro";
            cmbTipoOperacaoFiltro.Size = new Size(210, 26);
            cmbTipoOperacaoFiltro.StartIndex = 0;
            cmbTipoOperacaoFiltro.TabIndex = 30;
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.Transparent;
            crownLabel1.Font = new Font("Microsoft Sans Serif", 9F);
            crownLabel1.ForeColor = Color.SteelBlue;
            crownLabel1.Location = new Point(59, 140);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(41, 15);
            crownLabel1.TabIndex = 31;
            crownLabel1.Text = "Nome";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 554);
            Controls.Add(crownLabel1);
            Controls.Add(cmbTipoOperacaoFiltro);
            Controls.Add(dtpDataFiltro);
            Controls.Add(btnFiltrar);
            Controls.Add(txtNomeFiltro);
            Controls.Add(metroControlBox1);
            Controls.Add(bigLabel1);
            Controls.Add(DgvRegistro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistro";
            Text = "FrmRegistro";
            TransparencyKey = Color.Fuchsia;
            Load += FrmRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)DgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView DgvRegistro;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn ClnIdUsuario;
        private DataGridViewTextBoxColumn clnEntrada;
        private DataGridViewTextBoxColumn clnSaida;
        private DataGridViewTextBoxColumn clnOperacao;
        private DataGridViewTextBoxColumn clnHorario;
        private ReaLTaiizor.Controls.AloneTextBox txtNomeFiltro;
        private ReaLTaiizor.Controls.AirButton btnFiltrar;
        private ReaLTaiizor.Controls.PoisonDateTime dtpDataFiltro;
        private ReaLTaiizor.Controls.DungeonComboBox cmbTipoOperacaoFiltro;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
    }
}