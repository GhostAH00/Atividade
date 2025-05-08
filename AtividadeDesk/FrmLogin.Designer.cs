namespace AtividadeDesk
{
    partial class FrmLogin
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
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            txtNome = new ReaLTaiizor.Controls.AloneTextBox();
            txtSenha = new ReaLTaiizor.Controls.AloneTextBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            btnEntrar = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
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
            metroControlBox1.Location = new Point(252, -1);
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
            metroControlBox1.TabIndex = 20;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroLight";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Transparent;
            txtNome.EnabledCalc = true;
            txtNome.Font = new Font("Mongolian Baiti", 10F);
            txtNome.ForeColor = Color.FromArgb(124, 133, 142);
            txtNome.Location = new Point(70, 124);
            txtNome.MaxLength = 32767;
            txtNome.MultiLine = false;
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = false;
            txtNome.Size = new Size(229, 33);
            txtNome.TabIndex = 21;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Transparent;
            txtSenha.EnabledCalc = true;
            txtSenha.Font = new Font("Mongolian Baiti", 10F);
            txtSenha.ForeColor = Color.FromArgb(124, 133, 142);
            txtSenha.Location = new Point(70, 187);
            txtSenha.MaxLength = 32767;
            txtSenha.MultiLine = false;
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = false;
            txtSenha.Size = new Size(229, 34);
            txtSenha.TabIndex = 22;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Mongolian Baiti", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.SteelBlue;
            bigLabel1.Location = new Point(116, 45);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(118, 35);
            bigLabel1.TabIndex = 23;
            bigLabel1.Text = "LOGIN";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.Transparent;
            crownLabel1.Font = new Font("Microsoft Sans Serif", 9F);
            crownLabel1.ForeColor = Color.SteelBlue;
            crownLabel1.Location = new Point(72, 106);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(41, 15);
            crownLabel1.TabIndex = 24;
            crownLabel1.Text = "Nome";
            // 
            // crownLabel2
            // 
            crownLabel2.AutoSize = true;
            crownLabel2.BackColor = Color.Transparent;
            crownLabel2.Font = new Font("Microsoft Sans Serif", 9F);
            crownLabel2.ForeColor = Color.SteelBlue;
            crownLabel2.Location = new Point(70, 169);
            crownLabel2.Name = "crownLabel2";
            crownLabel2.Size = new Size(43, 15);
            crownLabel2.TabIndex = 25;
            crownLabel2.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.BorderColor = Color.SteelBlue;
            btnEntrar.EnteredBorderColor = Color.FromArgb(32, 34, 37);
            btnEntrar.EnteredColor = Color.SteelBlue;
            btnEntrar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEntrar.Image = null;
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.InactiveColor = Color.SteelBlue;
            btnEntrar.Location = new Point(116, 241);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.PressedBorderColor = Color.FromArgb(32, 34, 37);
            btnEntrar.PressedColor = Color.FromArgb(32, 34, 37);
            btnEntrar.Size = new Size(120, 40);
            btnEntrar.TabIndex = 26;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlignment = StringAlignment.Center;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(349, 314);
            Controls.Add(btnEntrar);
            Controls.Add(crownLabel2);
            Controls.Add(crownLabel1);
            Controls.Add(bigLabel1);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(metroControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "FrmLogin";
            Text = "formTheme1";
            TransparencyKey = Color.Fuchsia;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.AloneTextBox txtNome;
        private ReaLTaiizor.Controls.AloneTextBox txtSenha;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.Button btnEntrar;
    }
}