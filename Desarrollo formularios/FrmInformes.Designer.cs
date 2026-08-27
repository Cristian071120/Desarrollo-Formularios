namespace Desarrollo_formularios
{
    partial class FrmInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformes));
            label2 = new Label();
            label1 = new Label();
            dgvPersons = new DataGridView();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblProductoId = new Label();
            btnClear = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(426, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 44;
            label2.Text = "Filtrar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 23);
            label1.Name = "label1";
            label1.Size = new Size(263, 31);
            label1.TabIndex = 43;
            label1.Text = "GESTIONAR INFORMES";
            // 
            // dgvPersons
            // 
            dgvPersons.BackgroundColor = SystemColors.MenuHighlight;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(426, 156);
            dgvPersons.Margin = new Padding(3, 4, 3, 4);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.RowHeadersWidth = 51;
            dgvPersons.Size = new Size(335, 128);
            dgvPersons.TabIndex = 42;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(32, 222);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(74, 20);
            lblLastName.TabIndex = 38;
            lblLastName.Text = "Fecha Fin";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(13, 161);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(91, 20);
            lblFirstName.TabIndex = 37;
            lblFirstName.Text = "Fecha Inicio";
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.BackColor = Color.Transparent;
            lblProductoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoId.ForeColor = Color.White;
            lblProductoId.Location = new Point(40, 104);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(66, 20);
            lblProductoId.TabIndex = 36;
            lblProductoId.Text = "Informe";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(570, 350);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 34;
            btnClear.Text = "LIMPIAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.Highlight;
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(444, 350);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(86, 31);
            btnFind.TabIndex = 33;
            btnFind.Text = "BUSCAR";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(299, 350);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 31);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(171, 350);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "EDITAR";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.Highlight;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(40, 350);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 31);
            btnInsert.TabIndex = 30;
            btnInsert.Text = "CREAR";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 47;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(570, 96);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 28);
            comboBox2.TabIndex = 48;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(130, 217);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 27);
            dateTimePicker2.TabIndex = 49;
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPersons);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblProductoId);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Name = "FrmInformes";
            Text = "FrmInformes";
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private DataGridView dgvPersons;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblProductoId;
        private Button btnClear;
        private Button btnFind;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
    }
}