namespace Desarrollo_formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.MdiParent = this;
            empleados.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias categorias = new FrmCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new FrmAyuda();
            ayuda.MdiParent = this;
            ayuda.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcerca_de acerca_De = new FrmAcerca_de();
            acerca_De.MdiParent = this;
            acerca_De.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturas facturas = new FrmFacturas();
            facturas.MdiParent = this;
            facturas.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformes informes = new FrmInformes();
            informes.MdiParent = this;
            informes.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles roles = new FrmRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSeguridad seguridad = new FrmSeguridad();
            seguridad.MdiParent = this;
            seguridad.Show();
        }
    }
}
