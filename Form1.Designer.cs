namespace Desarrollo_formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            facturasToolStripMenuItem = new ToolStripMenuItem();
            informesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem1 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem1 = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, tablasToolStripMenuItem, facturaciónToolStripMenuItem, seguridadToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.BackColor = Color.Transparent;
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archivoToolStripMenuItem.ForeColor = SystemColors.Highlight;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(62, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackColor = Color.Transparent;
            salirToolStripMenuItem.ForeColor = SystemColors.Highlight;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(98, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.BackColor = Color.Transparent;
            tablasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, categoriasToolStripMenuItem });
            tablasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tablasToolStripMenuItem.ForeColor = SystemColors.Highlight;
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(52, 20);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.Transparent;
            clientesToolStripMenuItem.ForeColor = SystemColors.Highlight;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.BackColor = Color.Transparent;
            productosToolStripMenuItem.ForeColor = SystemColors.Highlight;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.BackColor = Color.Transparent;
            categoriasToolStripMenuItem.ForeColor = SystemColors.Highlight;
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(180, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.BackColor = Color.Transparent;
            facturaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturasToolStripMenuItem, informesToolStripMenuItem });
            facturaciónToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            facturaciónToolStripMenuItem.ForeColor = SystemColors.Highlight;
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(83, 20);
            facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.BackColor = Color.Transparent;
            facturasToolStripMenuItem.ForeColor = SystemColors.Highlight;
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new Size(180, 22);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // informesToolStripMenuItem
            // 
            informesToolStripMenuItem.BackColor = Color.Transparent;
            informesToolStripMenuItem.ForeColor = SystemColors.Highlight;
            informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            informesToolStripMenuItem.Size = new Size(180, 22);
            informesToolStripMenuItem.Text = "Informes";
            informesToolStripMenuItem.Click += informesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.BackColor = Color.Transparent;
            seguridadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, rolesToolStripMenuItem, seguridadToolStripMenuItem1 });
            seguridadToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seguridadToolStripMenuItem.ForeColor = SystemColors.Highlight;
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(75, 20);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.BackColor = Color.Transparent;
            empleadosToolStripMenuItem.ForeColor = SystemColors.Highlight;
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(180, 22);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.BackColor = Color.Transparent;
            rolesToolStripMenuItem.ForeColor = SystemColors.Highlight;
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(180, 22);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem1
            // 
            seguridadToolStripMenuItem1.BackColor = Color.Transparent;
            seguridadToolStripMenuItem1.ForeColor = SystemColors.Highlight;
            seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            seguridadToolStripMenuItem1.Size = new Size(180, 22);
            seguridadToolStripMenuItem1.Text = "Seguridad";
            seguridadToolStripMenuItem1.Click += seguridadToolStripMenuItem1_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.BackColor = Color.Transparent;
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ayudaToolStripMenuItem1, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ayudaToolStripMenuItem.ForeColor = SystemColors.Highlight;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaToolStripMenuItem1
            // 
            ayudaToolStripMenuItem1.BackColor = Color.Transparent;
            ayudaToolStripMenuItem1.ForeColor = SystemColors.Highlight;
            ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            ayudaToolStripMenuItem1.Size = new Size(180, 22);
            ayudaToolStripMenuItem1.Text = "Ayuda";
            ayudaToolStripMenuItem1.Click += ayudaToolStripMenuItem1_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.BackColor = Color.Transparent;
            acercaDeToolStripMenuItem.ForeColor = SystemColors.Highlight;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private ToolStripMenuItem facturasToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem rolesToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem1;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem1;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
