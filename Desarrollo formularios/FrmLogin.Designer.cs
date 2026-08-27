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
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(223, 301);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 33);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.ImageAlign = ContentAlignment.BottomLeft;
            lblUsuario.Location = new Point(59, 173);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.White;
            lblContrasena.Location = new Point(59, 227);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(88, 20);
            lblContrasena.TabIndex = 2;
            lblContrasena.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(154, 169);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(293, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(154, 223);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(293, 27);
            txtContrasena.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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