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
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(48, 378);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(172, 378);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(305, 378);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(436, 378);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(561, 378);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(688, 378);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(75, 23);
            btnAll.TabIndex = 5;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Location = new Point(109, 34);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(53, 15);
            lblPersonId.TabIndex = 6;
            lblPersonId.Text = "PersonId";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(109, 72);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(61, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(109, 115);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "LastName";
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(172, 26);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.Size = new Size(396, 23);
            txtPersonId.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(175, 69);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(393, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(175, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(393, 23);
            txtLastName.TabIndex = 11;
            // 
            // dgvPersons
            // 
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(81, 163);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.Size = new Size(616, 182);
            dgvPersons.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form2";
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
    }
}