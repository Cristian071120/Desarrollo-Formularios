namespace Desarrollo_formularios
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dgvPersons = new DataGridView();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblProductoId = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(148, 218);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 27);
            dateTimePicker2.TabIndex = 64;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(530, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 28);
            comboBox2.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(440, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 60;
            label2.Text = "Cargo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(256, 36);
            label1.Name = "label1";
            label1.Size = new Size(314, 31);
            label1.TabIndex = 59;
            label1.Text = "ADMINISTRAR EMPLEADOS";
            // 
            // dgvPersons
            // 
            dgvPersons.BackgroundColor = SystemColors.MenuHighlight;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(31, 289);
            dgvPersons.Margin = new Padding(3, 4, 3, 4);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.RowHeadersWidth = 51;
            dgvPersons.Size = new Size(335, 128);
            dgvPersons.TabIndex = 58;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(41, 223);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(96, 20);
            lblLastName.TabIndex = 57;
            lblLastName.Text = "Fecha Retiro";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(31, 162);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 20);
            lblFirstName.TabIndex = 56;
            lblFirstName.Text = "Fecha Ingreso";
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.BackColor = Color.Transparent;
            lblProductoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoId.ForeColor = Color.White;
            lblProductoId.Location = new Point(58, 105);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(67, 20);
            lblProductoId.TabIndex = 55;
            lblProductoId.Text = "Nombre";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(630, 386);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 31);
            btnClear.TabIndex = 54;
            btnClear.Text = "GUARDAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(484, 386);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 51;
            btnUpdate.Text = "EDITAR";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 27);
            textBox1.TabIndex = 65;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(529, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(439, 162);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 66;
            label3.Text = "Documento";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(529, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 27);
            textBox3.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(439, 218);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 68;
            label4.Text = "Dirección";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(530, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(212, 27);
            textBox4.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(440, 273);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 70;
            label5.Text = "Correo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(530, 330);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(212, 27);
            textBox5.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(440, 330);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 72;
            label6.Text = "Teléfono";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPersons);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblProductoId);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private DataGridView dgvPersons;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblProductoId;
        private Button btnClear;
        private Button btnUpdate;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
    }
}