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
            btnIngresar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(301, 208);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(293, 27);
            txtContrasena.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(301, 154);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(293, 27);
            txtUsuario.TabIndex = 8;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasena.ForeColor = Color.White;
            lblContrasena.Location = new Point(206, 212);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(88, 20);
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
            lblUsuario.Location = new Point(231, 157);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Highlight;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(261, 342);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(106, 33);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Actualizar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(244, 28);
            label1.Name = "label1";
            label1.Size = new Size(334, 31);
            label1.TabIndex = 44;
            label1.Text = "ADMINISTRACIÓN USUARIOS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 258);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 265);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 45;
            label2.Text = "Nueva Contraseña";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(441, 342);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 33);
            btnClear.TabIndex = 47;
            btnClear.Text = "Salir";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // FrmSeguridad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Name = "FrmSeguridad";
            Text = "FrmSeguridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private Label lblContrasena;
        private Label lblUsuario;
        private Button btnIngresar;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnClear;
    }
}