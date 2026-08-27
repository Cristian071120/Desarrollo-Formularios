namespace Desarrollo_formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.SeaShell;
            btnIngresar.Location = new Point(217, 261);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 34);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.SeaShell;
            lblUsuario.Location = new Point(61, 162);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.SeaShell;
            lblContrasena.Location = new Point(46, 204);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(96, 21);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(156, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(257, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(156, 202);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(257, 23);
            txtContrasena.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblContrasena;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
    }
}