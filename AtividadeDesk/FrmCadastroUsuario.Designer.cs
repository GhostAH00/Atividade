namespace AtividadeDesk
{
    partial class FrmCadastroUsuario
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            maskedTxtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtNome = new ReaLTaiizor.Controls.AloneTextBox();
            txtSenha = new ReaLTaiizor.Controls.AloneTextBox();
            CmbBoxTipo = new ReaLTaiizor.Controls.DungeonComboBox();
            btnConfirmar = new ReaLTaiizor.Controls.Button();
            btnAnexar = new ReaLTaiizor.Controls.Button();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Mongolian Baiti", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.SteelBlue;
            bigLabel1.Location = new Point(76, 44);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(356, 35);
            bigLabel1.TabIndex = 4;
            bigLabel1.Text = "CADASTRO DE LOGIN";
            // 
            // maskedTxtCPF
            // 
            maskedTxtCPF.AllowPromptAsInput = true;
            maskedTxtCPF.AnimateReadOnly = false;
            maskedTxtCPF.AsciiOnly = false;
            maskedTxtCPF.BackgroundImageLayout = ImageLayout.None;
            maskedTxtCPF.BeepOnError = false;
            maskedTxtCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            maskedTxtCPF.Depth = 0;
            maskedTxtCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maskedTxtCPF.HidePromptOnLeave = false;
            maskedTxtCPF.HideSelection = true;
            maskedTxtCPF.InsertKeyMode = InsertKeyMode.Default;
            maskedTxtCPF.LeadingIcon = null;
            maskedTxtCPF.Location = new Point(270, 101);
            maskedTxtCPF.Mask = "000.000.000-00";
            maskedTxtCPF.MaxLength = 32767;
            maskedTxtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            maskedTxtCPF.Name = "maskedTxtCPF";
            maskedTxtCPF.PasswordChar = '\0';
            maskedTxtCPF.PrefixSuffixText = null;
            maskedTxtCPF.PromptChar = '_';
            maskedTxtCPF.ReadOnly = false;
            maskedTxtCPF.RejectInputOnFirstFailure = false;
            maskedTxtCPF.ResetOnPrompt = true;
            maskedTxtCPF.ResetOnSpace = true;
            maskedTxtCPF.RightToLeft = RightToLeft.No;
            maskedTxtCPF.SelectedText = "";
            maskedTxtCPF.SelectionLength = 0;
            maskedTxtCPF.SelectionStart = 0;
            maskedTxtCPF.ShortcutsEnabled = true;
            maskedTxtCPF.Size = new Size(162, 48);
            maskedTxtCPF.SkipLiterals = true;
            maskedTxtCPF.TabIndex = 5;
            maskedTxtCPF.TabStop = false;
            maskedTxtCPF.Text = "   ,   ,   -";
            maskedTxtCPF.TextAlign = HorizontalAlignment.Left;
            maskedTxtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            maskedTxtCPF.TrailingIcon = null;
            maskedTxtCPF.UseSystemPasswordChar = false;
            maskedTxtCPF.ValidatingType = null;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Transparent;
            txtNome.EnabledCalc = true;
            txtNome.Font = new Font("Mongolian Baiti", 10F);
            txtNome.ForeColor = Color.FromArgb(124, 133, 142);
            txtNome.Location = new Point(248, 225);
            txtNome.MaxLength = 32767;
            txtNome.MultiLine = false;
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = false;
            txtNome.Size = new Size(210, 33);
            txtNome.TabIndex = 7;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Transparent;
            txtSenha.EnabledCalc = true;
            txtSenha.Font = new Font("Mongolian Baiti", 10F);
            txtSenha.ForeColor = Color.FromArgb(124, 133, 142);
            txtSenha.Location = new Point(248, 279);
            txtSenha.MaxLength = 32767;
            txtSenha.MultiLine = false;
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = false;
            txtSenha.Size = new Size(210, 34);
            txtSenha.TabIndex = 7;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // CmbBoxTipo
            // 
            CmbBoxTipo.BackColor = Color.FromArgb(246, 246, 246);
            CmbBoxTipo.ColorA = Color.SteelBlue;
            CmbBoxTipo.ColorB = Color.SteelBlue;
            CmbBoxTipo.ColorC = Color.FromArgb(242, 241, 240);
            CmbBoxTipo.ColorD = Color.FromArgb(253, 252, 252);
            CmbBoxTipo.ColorE = Color.FromArgb(239, 237, 236);
            CmbBoxTipo.ColorF = Color.FromArgb(180, 180, 180);
            CmbBoxTipo.ColorG = Color.FromArgb(119, 119, 118);
            CmbBoxTipo.ColorH = Color.FromArgb(224, 222, 220);
            CmbBoxTipo.ColorI = Color.FromArgb(250, 249, 249);
            CmbBoxTipo.DrawMode = DrawMode.OwnerDrawFixed;
            CmbBoxTipo.DropDownHeight = 100;
            CmbBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbBoxTipo.Font = new Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbBoxTipo.ForeColor = Color.FromArgb(76, 76, 97);
            CmbBoxTipo.FormattingEnabled = true;
            CmbBoxTipo.HoverSelectionColor = Color.Empty;
            CmbBoxTipo.IntegralHeight = false;
            CmbBoxTipo.ItemHeight = 20;
            CmbBoxTipo.Items.AddRange(new object[] { "Administrador", "Funcionário ", "Visitante" });
            CmbBoxTipo.Location = new Point(248, 178);
            CmbBoxTipo.Name = "CmbBoxTipo";
            CmbBoxTipo.Size = new Size(210, 26);
            CmbBoxTipo.StartIndex = 0;
            CmbBoxTipo.TabIndex = 12;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.Transparent;
            btnConfirmar.BorderColor = Color.SteelBlue;
            btnConfirmar.EnteredBorderColor = Color.FromArgb(32, 34, 37);
            btnConfirmar.EnteredColor = Color.SteelBlue;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 12F);
            btnConfirmar.Image = null;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.InactiveColor = Color.SteelBlue;
            btnConfirmar.Location = new Point(287, 335);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.PressedBorderColor = Color.FromArgb(32, 34, 37);
            btnConfirmar.PressedColor = Color.FromArgb(32, 34, 37);
            btnConfirmar.Size = new Size(120, 40);
            btnConfirmar.TabIndex = 15;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextAlignment = StringAlignment.Center;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAnexar
            // 
            btnAnexar.BackColor = Color.Transparent;
            btnAnexar.BorderColor = Color.SteelBlue;
            btnAnexar.EnteredBorderColor = Color.FromArgb(32, 34, 37);
            btnAnexar.EnteredColor = Color.SteelBlue;
            btnAnexar.Font = new Font("Microsoft Sans Serif", 12F);
            btnAnexar.Image = null;
            btnAnexar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnexar.InactiveColor = Color.SteelBlue;
            btnAnexar.Location = new Point(66, 335);
            btnAnexar.Name = "btnAnexar";
            btnAnexar.PressedBorderColor = Color.FromArgb(32, 34, 37);
            btnAnexar.PressedColor = Color.FromArgb(32, 34, 37);
            btnAnexar.Size = new Size(120, 40);
            btnAnexar.TabIndex = 15;
            btnAnexar.Text = "Anexar";
            btnAnexar.TextAlignment = StringAlignment.Center;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Location = new Point(45, 101);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(167, 212);
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 16;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            metroControlBox1.Location = new Point(412, -2);
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
            metroControlBox1.TabIndex = 19;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroLight";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.Transparent;
            crownLabel1.Font = new Font("Microsoft Sans Serif", 9F);
            crownLabel1.ForeColor = Color.SteelBlue;
            crownLabel1.Location = new Point(248, 207);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(41, 15);
            crownLabel1.TabIndex = 20;
            crownLabel1.Text = "Nome";
            crownLabel1.Click += crownLabel1_Click;
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.BackColor = Color.Transparent;
            crownLabel2.Font = new Font("Microsoft Sans Serif", 9F);
            crownLabel2.ForeColor = Color.SteelBlue;
            crownLabel2.Location = new Point(248, 261);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(43, 15);
            crownLabel2.TabIndex = 21;
            crownLabel2.Text = "Senha";
            // 
            // crownLabel3
            // 
            crownLabel3.AutoSize = true;
            crownLabel3.BackColor = Color.Transparent;
            crownLabel3.Font = new Font("Microsoft Sans Serif", 9F);
            crownLabel3.ForeColor = Color.SteelBlue;
            crownLabel3.Location = new Point(248, 160);
            crownLabel3.Name = "crownLabel3";
            crownLabel3.Size = new Size(31, 15);
            crownLabel3.TabIndex = 22;
            crownLabel3.Text = "Tipo";
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 420);
            Controls.Add(crownLabel3);
            Controls.Add(crownLabel2);
            Controls.Add(crownLabel1);
            Controls.Add(metroControlBox1);
            Controls.Add(hopePictureBox1);
            Controls.Add(btnAnexar);
            Controls.Add(btnConfirmar);
            Controls.Add(CmbBoxTipo);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(maskedTxtCPF);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formTheme1";
            TransparencyKey = Color.Blue;
            Load += FrmCadastroUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox maskedTxtCPF;
        private ReaLTaiizor.Controls.AloneTextBox txtNome;
        private ReaLTaiizor.Controls.AloneTextBox txtSenha;
        private ReaLTaiizor.Controls.DungeonComboBox CmbBoxTipo;
        private ReaLTaiizor.Controls.Button btnConfirmar;
        private ReaLTaiizor.Controls.Button btnAnexar;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
    }
}
