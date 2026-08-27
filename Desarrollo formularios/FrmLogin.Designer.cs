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
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(367, 247);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(223, 151);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(223, 191);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(67, 15);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(306, 148);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(257, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(306, 188);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(257, 23);
            txtContrasena.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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