namespace Desarrollo_formularios
{
    partial class FrmSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeguridad));
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            lblUsuario = new Label();
            btnActualizar = new Button();
            label1 = new Label();
            btnSalir = new Button();
            btnInsert = new Button();
            btnDelete = new Button();
            dgvUsuarios = new DataGridView();
            btnAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(133, 158);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(257, 23);
            txtContrasena.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(133, 118);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(257, 23);
            txtUsuario.TabIndex = 8;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.White;
            lblContrasena.Location = new Point(50, 161);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(69, 15);
            lblContrasena.TabIndex = 7;
            lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.ImageAlign = ContentAlignment.BottomLeft;
            lblUsuario.Location = new Point(72, 120);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(49, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(297, 257);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(93, 25);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 21);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 44;
            label1.Text = "ADMINISTRACIÓN USUARIOS";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Highlight;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(514, 255);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 25);
            btnSalir.TabIndex = 47;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.Highlight;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(95, 258);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 48;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(195, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 49;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = SystemColors.MenuHighlight;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(417, 102);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(236, 101);
            dgvUsuarios.TabIndex = 50;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Highlight;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(417, 257);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(75, 23);
            btnAll.TabIndex = 51;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // FrmSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnAll);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(btnActualizar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmSeguridad";
            Text = "FrmSeguridad";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private Label lblUsuario;
        private Button btnActualizar;
        private Label label1;
        private Button btnSalir;
        private Button btnInsert;
        private Button btnDelete;
        private DataGridView dgvUsuarios;
        private Button btnAll;
    }
}