namespace Desarrollo_formularios
{
    partial class FrmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturas));
            label2 = new Label();
            label1 = new Label();
            txtPersonId = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblProductoId = new Label();
            btnAll = new Button();
            btnClear = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(414, 104);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 44;
            label2.Text = "Fecha Registro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(261, 22);
            label1.Name = "label1";
            label1.Size = new Size(266, 31);
            label1.TabIndex = 43;
            label1.Text = "VISUALIZAR FACTURAS";
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(110, 101);
            txtPersonId.Margin = new Padding(3, 4, 3, 4);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(261, 27);
            txtPersonId.TabIndex = 39;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(446, 161);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(78, 20);
            lblLastName.TabIndex = 38;
            lblLastName.Text = "Empleado";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(47, 161);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(57, 20);
            lblFirstName.TabIndex = 37;
            lblFirstName.Text = "Cliente";
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.BackColor = Color.Transparent;
            lblProductoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoId.ForeColor = Color.White;
            lblProductoId.Location = new Point(8, 104);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(96, 20);
            lblProductoId.TabIndex = 36;
            lblProductoId.Text = "Nro. Factura";
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Highlight;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(635, 284);
            btnAll.Margin = new Padding(3, 4, 3, 4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(86, 31);
            btnAll.TabIndex = 35;
            btnAll.Text = "SALIR";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(470, 284);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 34;
            btnClear.Text = "BUSCAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(110, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 28);
            comboBox1.TabIndex = 46;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(530, 158);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(530, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 48;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(310, 146);
            dataGridView1.TabIndex = 49;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPersonId);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblProductoId);
            Controls.Add(btnAll);
            Controls.Add(btnClear);
            Name = "FrmFacturas";
            Text = "FrmFacturas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private TextBox txtPersonId;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblProductoId;
        private Button btnAll;
        private Button btnClear;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
    }
}