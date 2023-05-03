using supermarekt.View;
using Supermarker.Business;
using Supermarker.Model;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace supermarekt
{
    public partial class MainForm : Form
    {



        internal PayModeDAO payModeDAO;
        internal PayModeProductsDAO payModeProductsDAO;
        internal PayModeCaetegoriesDAO payModeCaetegoriesDAO;
        internal PayModeProvaidersDAO payModeProvaidersDAO;


        public MainForm()
        {
            payModeDAO = new PayModeDAO();
            payModeProductsDAO = new PayModeProductsDAO();
            payModeCaetegoriesDAO = new PayModeCaetegoriesDAO();
            payModeProvaidersDAO= new PayModeProvaidersDAO();   


            InitializeComponent();
            payModeDAO.AddPayMode(new Supermarker.Model.PayMode(null, "Cash"));
            payModeProductsDAO.AddPayModelProduct(new Supermarker.Model.PayModelProducts(null, "Cash", 0, 0,"abarrotes"));
            payModeCaetegoriesDAO.AddPayModelProduct(new Supermarker.Model.PayModelCategories(null, "bebidas"));
            payModeProvaidersDAO.AddPayModelProduct(new Supermarker.Model.PayModelProvaiders(null, "david","pepe","sd",0,"asdasd@gmail"));



        }



        private void aaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supermarkert V 0.1", "About us");

        }

        private void ProductsMenuItem_Click(object sender, EventArgs e)
        {
            FormProducts formPayModee = new FormProducts(ref payModeProductsDAO);

            formPayModee.MdiParent = this;
            formPayModee.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModeForm formPayMode = new PayModeForm(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();

        }

        private void CategoriesMenuItem_Click(object sender, EventArgs e)
        {
            
            FormCategires formPayMode = new FormCategires(ref payModeCaetegoriesDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();



        }

        private void ProvidersMenuItem_Click(object sender, EventArgs e)
        {

            FormProvaiders formPayMode = new FormProvaiders(ref payModeProvaidersDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();


        }

        private void SellMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

