namespace ConsultaPermissoes.Apresentacao {
    partial class frmSelecionarPermissoes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            FontAwesome.Sharp.IconPictureBox iconPictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecionarPermissoes));
            this.PANEI1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.gpbPermissao = new System.Windows.Forms.GroupBox();
            this.txtDesPermissao = new System.Windows.Forms.TextBox();
            this.lblAgrupador = new System.Windows.Forms.Label();
            this.txtCodPermissao = new System.Windows.Forms.TextBox();
            this.lblcodAgrupador = new System.Windows.Forms.Label();
            this.rdoPermissao = new System.Windows.Forms.RadioButton();
            this.gpbUsuario = new System.Windows.Forms.GroupBox();
            this.txtDesUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoUsuario = new System.Windows.Forms.RadioButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgvPermissao = new System.Windows.Forms.DataGridView();
            this.CodUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(iconPictureBox1)).BeginInit();
            this.PANEI1.SuspendLayout();
            this.gpbPermissao.SuspendLayout();
            this.gpbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissao)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(16)))));
            iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileText;
            iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 22;
            iconPictureBox1.Location = new System.Drawing.Point(6, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new System.Drawing.Size(24, 22);
            iconPictureBox1.TabIndex = 128;
            iconPictureBox1.TabStop = false;
            // 
            // PANEI1
            // 
            this.PANEI1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(16)))));
            this.PANEI1.Controls.Add(iconPictureBox1);
            this.PANEI1.Controls.Add(this.btnMinimizar);
            this.PANEI1.Controls.Add(this.btnMaximizar);
            this.PANEI1.Controls.Add(this.btnFechar);
            this.PANEI1.Controls.Add(this.label1);
            this.PANEI1.Location = new System.Drawing.Point(0, 0);
            this.PANEI1.Name = "PANEI1";
            this.PANEI1.Size = new System.Drawing.Size(921, 32);
            this.PANEI1.TabIndex = 6;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(823, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 28);
            this.btnMinimizar.TabIndex = 124;
            this.btnMinimizar.Text = "";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(857, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 28);
            this.btnMaximizar.TabIndex = 125;
            this.btnMaximizar.Text = "";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(186)))), ((int)(((byte)(16)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(888, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(28, 28);
            this.btnFechar.TabIndex = 68;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Permissões";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnSair.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 24;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(814, 723);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 35);
            this.btnSair.TabIndex = 151;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbPermissao
            // 
            this.gpbPermissao.Controls.Add(this.txtDesPermissao);
            this.gpbPermissao.Controls.Add(this.lblAgrupador);
            this.gpbPermissao.Controls.Add(this.txtCodPermissao);
            this.gpbPermissao.Controls.Add(this.lblcodAgrupador);
            this.gpbPermissao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPermissao.Location = new System.Drawing.Point(273, 38);
            this.gpbPermissao.Name = "gpbPermissao";
            this.gpbPermissao.Size = new System.Drawing.Size(252, 61);
            this.gpbPermissao.TabIndex = 168;
            this.gpbPermissao.TabStop = false;
            // 
            // txtDesPermissao
            // 
            this.txtDesPermissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesPermissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesPermissao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesPermissao.Location = new System.Drawing.Point(93, 33);
            this.txtDesPermissao.Name = "txtDesPermissao";
            this.txtDesPermissao.Size = new System.Drawing.Size(152, 22);
            this.txtDesPermissao.TabIndex = 173;
            this.txtDesPermissao.TextChanged += new System.EventHandler(this.txtDesPermissao_TextChanged);
            // 
            // lblAgrupador
            // 
            this.lblAgrupador.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgrupador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblAgrupador.Location = new System.Drawing.Point(97, 14);
            this.lblAgrupador.Name = "lblAgrupador";
            this.lblAgrupador.Size = new System.Drawing.Size(61, 18);
            this.lblAgrupador.TabIndex = 174;
            this.lblAgrupador.Text = "Descrição:";
            this.lblAgrupador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgrupador.UseMnemonic = false;
            // 
            // txtCodPermissao
            // 
            this.txtCodPermissao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodPermissao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPermissao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPermissao.Location = new System.Drawing.Point(6, 33);
            this.txtCodPermissao.Name = "txtCodPermissao";
            this.txtCodPermissao.Size = new System.Drawing.Size(81, 22);
            this.txtCodPermissao.TabIndex = 170;
            this.txtCodPermissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPermissao_KeyPress);
            // 
            // lblcodAgrupador
            // 
            this.lblcodAgrupador.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodAgrupador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.lblcodAgrupador.Location = new System.Drawing.Point(11, 17);
            this.lblcodAgrupador.Name = "lblcodAgrupador";
            this.lblcodAgrupador.Size = new System.Drawing.Size(40, 13);
            this.lblcodAgrupador.TabIndex = 171;
            this.lblcodAgrupador.Text = "Cód.:";
            this.lblcodAgrupador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoPermissao
            // 
            this.rdoPermissao.AutoSize = true;
            this.rdoPermissao.Checked = true;
            this.rdoPermissao.Location = new System.Drawing.Point(279, 38);
            this.rdoPermissao.Name = "rdoPermissao";
            this.rdoPermissao.Size = new System.Drawing.Size(73, 17);
            this.rdoPermissao.TabIndex = 171;
            this.rdoPermissao.TabStop = true;
            this.rdoPermissao.Text = "Permissão";
            this.rdoPermissao.UseVisualStyleBackColor = true;
            this.rdoPermissao.CheckedChanged += new System.EventHandler(this.rdoPermissao_CheckedChanged);
            // 
            // gpbUsuario
            // 
            this.gpbUsuario.Controls.Add(this.txtDesUsuario);
            this.gpbUsuario.Controls.Add(this.label2);
            this.gpbUsuario.Controls.Add(this.txtCodUsuario);
            this.gpbUsuario.Controls.Add(this.label3);
            this.gpbUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbUsuario.Location = new System.Drawing.Point(6, 38);
            this.gpbUsuario.Name = "gpbUsuario";
            this.gpbUsuario.Size = new System.Drawing.Size(253, 61);
            this.gpbUsuario.TabIndex = 169;
            this.gpbUsuario.TabStop = false;
            // 
            // txtDesUsuario
            // 
            this.txtDesUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesUsuario.Location = new System.Drawing.Point(93, 33);
            this.txtDesUsuario.Name = "txtDesUsuario";
            this.txtDesUsuario.Size = new System.Drawing.Size(152, 22);
            this.txtDesUsuario.TabIndex = 173;
            this.txtDesUsuario.TextChanged += new System.EventHandler(this.txtDesUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 174;
            this.label2.Text = "Login:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(6, 33);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(81, 22);
            this.txtCodUsuario.TabIndex = 170;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = "Cód.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoUsuario
            // 
            this.rdoUsuario.AutoSize = true;
            this.rdoUsuario.Location = new System.Drawing.Point(12, 35);
            this.rdoUsuario.Name = "rdoUsuario";
            this.rdoUsuario.Size = new System.Drawing.Size(61, 17);
            this.rdoUsuario.TabIndex = 171;
            this.rdoUsuario.Text = "Usuário";
            this.rdoUsuario.UseVisualStyleBackColor = true;
            this.rdoUsuario.CheckedChanged += new System.EventHandler(this.rdoUsuario_CheckedChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(63)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(540, 65);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 34);
            this.iconButton1.TabIndex = 170;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dgvPermissao
            // 
            this.dgvPermissao.BackgroundColor = System.Drawing.Color.White;
            this.dgvPermissao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodUsuario,
            this.Usuario,
            this.Permissao,
            this.Descricao});
            this.dgvPermissao.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPermissao.Location = new System.Drawing.Point(6, 102);
            this.dgvPermissao.Name = "dgvPermissao";
            this.dgvPermissao.Size = new System.Drawing.Size(908, 615);
            this.dgvPermissao.TabIndex = 171;
            this.dgvPermissao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermissao_CellContentClick);
            // 
            // CodUsuario
            // 
            this.CodUsuario.DataPropertyName = "usu_usuario_IN";
            this.CodUsuario.HeaderText = "Código";
            this.CodUsuario.Name = "CodUsuario";
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "usu_login_VC";
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            // 
            // Permissao
            // 
            this.Permissao.DataPropertyName = "per_permissao_IN";
            this.Permissao.HeaderText = "Permissao";
            this.Permissao.Name = "Permissao";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "per_resumido_VC";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 560;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // copToolStripMenuItem
            // 
            this.copToolStripMenuItem.Name = "copToolStripMenuItem";
            this.copToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.copToolStripMenuItem.Text = "Copiar";
            this.copToolStripMenuItem.Click += new System.EventHandler(this.copToolStripMenuItem_Click);
            // 
            // frmSelecionarPermissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 770);
            this.Controls.Add(this.rdoUsuario);
            this.Controls.Add(this.rdoPermissao);
            this.Controls.Add(this.dgvPermissao);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.gpbUsuario);
            this.Controls.Add(this.gpbPermissao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.PANEI1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelecionarPermissoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarMotivo";
            this.Load += new System.EventHandler(this.frmSelecionarPermissoes_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSelecionarPermissoes_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(iconPictureBox1)).EndInit();
            this.PANEI1.ResumeLayout(false);
            this.PANEI1.PerformLayout();
            this.gpbPermissao.ResumeLayout(false);
            this.gpbPermissao.PerformLayout();
            this.gpbUsuario.ResumeLayout(false);
            this.gpbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissao)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PANEI1;
        internal System.Windows.Forms.Button btnMinimizar;
        internal System.Windows.Forms.Button btnMaximizar;
        internal System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSair;
        private System.Windows.Forms.GroupBox gpbPermissao;
        internal System.Windows.Forms.TextBox txtDesPermissao;
        internal System.Windows.Forms.Label lblAgrupador;
        internal System.Windows.Forms.TextBox txtCodPermissao;
        internal System.Windows.Forms.Label lblcodAgrupador;
        private System.Windows.Forms.GroupBox gpbUsuario;
        internal System.Windows.Forms.TextBox txtDesUsuario;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtCodUsuario;
        internal System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.RadioButton rdoPermissao;
        private System.Windows.Forms.RadioButton rdoUsuario;
        private System.Windows.Forms.DataGridView dgvPermissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copToolStripMenuItem;
    }
}