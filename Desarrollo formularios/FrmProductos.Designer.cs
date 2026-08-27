namespace Desarrollo_formularios
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            label1 = new Label();
            dgvPersons = new DataGridView();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtPersonId = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblProductoId = new Label();
            btnClear = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            btnAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(258, 21);
            label1.Name = "label1";
            label1.Size = new Size(315, 31);
            label1.TabIndex = 27;
            label1.Text = "ADMINISTRAR PRODUCTOS";
            // 
            // dgvPersons
            // 
            dgvPersons.BackgroundColor = SystemColors.MenuHighlight;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(417, 102);
            dgvPersons.Margin = new Padding(3, 4, 3, 4);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.RowHeadersWidth = 51;
            dgvPersons.Size = new Size(386, 193);
            dgvPersons.TabIndex = 26;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(115, 217);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(258, 27);
            txtLastName.TabIndex = 25;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(115, 156);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(258, 27);
            txtFirstName.TabIndex = 24;
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(112, 99);
            txtPersonId.Margin = new Padding(3, 4, 3, 4);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(261, 27);
            txtPersonId.TabIndex = 23;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(26, 217);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(52, 20);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Precio";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(24, 159);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 20);
            lblFirstName.TabIndex = 21;
            lblFirstName.Text = "Nombre";
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.BackColor = Color.Transparent;
            lblProductoId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoId.ForeColor = Color.White;
            lblProductoId.Location = new Point(19, 102);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(87, 20);
            lblProductoId.TabIndex = 20;
            lblProductoId.Text = "ProductoId";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(572, 395);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.Highlight;
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(437, 395);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(86, 31);
            btnFind.TabIndex = 17;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(305, 395);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(175, 395);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.Highlight;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(42, 395);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 31);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 272);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 272);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 28;
            label2.Text = "Cantidad";
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Highlight;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(705, 395);
            btnAll.Margin = new Padding(3, 4, 3, 4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(86, 31);
            btnAll.TabIndex = 19;
            btnAll.Text = "ALL";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(836, 520);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPersons);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPersonId);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblProductoId);
            Controls.Add(btnAll);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Name = "FrmProductos";
            Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPersons;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtPersonId;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblProductoId;
        private Button btnClear;
        private Button btnFind;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox textBox1;
        private Label label2;
        private Button btnAll;
    }
}