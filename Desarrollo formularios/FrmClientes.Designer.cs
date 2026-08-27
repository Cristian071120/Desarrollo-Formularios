namespace Desarrollo_formularios
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnClear = new Button();
            btnAll = new Button();
            lblPersonId = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtPersonId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dgvPersons = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.Highlight;
            btnInsert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(55, 504);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 31);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(197, 504);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(349, 504);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.Highlight;
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(498, 504);
            btnFind.Margin = new Padding(3, 4, 3, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(86, 31);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(641, 504);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Highlight;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(786, 504);
            btnAll.Margin = new Padding(3, 4, 3, 4);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(86, 31);
            btnAll.TabIndex = 5;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.BackColor = Color.Transparent;
            lblPersonId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonId.ForeColor = Color.White;
            lblPersonId.Location = new Point(171, 105);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(71, 20);
            lblPersonId.TabIndex = 6;
            lblPersonId.Text = "PersonId";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(160, 162);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(82, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(162, 220);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(80, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "LastName";
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(248, 102);
            txtPersonId.Margin = new Padding(3, 4, 3, 4);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(452, 27);
            txtPersonId.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(251, 159);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(449, 27);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(251, 220);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(449, 27);
            txtLastName.TabIndex = 11;
            // 
            // dgvPersons
            // 
            dgvPersons.BackgroundColor = SystemColors.MenuHighlight;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(93, 310);
            dgvPersons.Margin = new Padding(3, 4, 3, 4);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.RowHeadersWidth = 51;
            dgvPersons.Size = new Size(704, 150);
            dgvPersons.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(337, 34);
            label1.Name = "label1";
            label1.Size = new Size(277, 31);
            label1.TabIndex = 13;
            label1.Text = "REGISTRAR/VISUALIZAR";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(dgvPersons);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtPersonId);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblPersonId);
            Controls.Add(btnAll);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnFind;
        private Button btnClear;
        private Button btnAll;
        private Label lblPersonId;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtPersonId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridView dgvPersons;
        private Label label1;
    }
}