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
            btnInsert.ForeColor = Color.SeaShell;
            btnInsert.Location = new Point(53, 388);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 32);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.SeaShell;
            btnUpdate.Location = new Point(177, 388);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.SeaShell;
            btnDelete.Location = new Point(310, 388);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = SystemColors.Highlight;
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.SeaShell;
            btnFind.Location = new Point(441, 388);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 32);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.SeaShell;
            btnClear.Location = new Point(566, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 32);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = SystemColors.Highlight;
            btnAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAll.ForeColor = Color.SeaShell;
            btnAll.Location = new Point(693, 388);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(75, 32);
            btnAll.TabIndex = 5;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.BackColor = Color.Transparent;
            lblPersonId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonId.ForeColor = Color.SeaShell;
            lblPersonId.Location = new Point(163, 96);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(62, 17);
            lblPersonId.TabIndex = 6;
            lblPersonId.Text = "PersonId";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.SeaShell;
            lblFirstName.Location = new Point(157, 139);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(71, 17);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.SeaShell;
            lblLastName.Location = new Point(159, 185);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(69, 17);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "LastName";
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(231, 90);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(396, 23);
            txtPersonId.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(234, 133);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(393, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(234, 179);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(393, 23);
            txtLastName.TabIndex = 11;
            // 
            // dgvPersons
            // 
            dgvPersons.BackgroundColor = Color.SteelBlue;
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(86, 226);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.Size = new Size(632, 138);
            dgvPersons.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(300, 24);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 13;
            label1.Text = "REGISTRAR CLIENTES";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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