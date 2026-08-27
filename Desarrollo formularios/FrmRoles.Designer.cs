namespace Desarrollo_formularios
{
    partial class FrmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoles));
            label1 = new Label();
            txtPersonId = new TextBox();
            lblFirstName = new Label();
            lblProductoId = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(288, 22);
            label1.Name = "label1";
            label1.Size = new Size(224, 31);
            label1.TabIndex = 43;
            label1.Text = "ROLES EMPLEADOS";
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(518, 132);
            txtPersonId.Margin = new Padding(3, 4, 3, 4);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(252, 27);
            txtPersonId.TabIndex = 39;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(30, 134);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(105, 20);
            lblFirstName.TabIndex = 37;
            lblFirstName.Text = "Lista de Roles";
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.BackColor = Color.Transparent;
            lblProductoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoId.ForeColor = Color.White;
            lblProductoId.Location = new Point(425, 135);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(90, 20);
            lblProductoId.TabIndex = 36;
            lblProductoId.Text = "Descripción";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(449, 353);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 34;
            btnClear.Text = "Salir";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(245, 353);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Editar";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 46;
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(txtPersonId);
            Controls.Add(lblFirstName);
            Controls.Add(lblProductoId);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Name = "FrmRoles";
            Text = "FrmRoles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPersonId;
        private Label lblFirstName;
        private Label lblProductoId;
        private Button btnClear;
        private Button btnUpdate;
        private ComboBox comboBox1;
    }
}