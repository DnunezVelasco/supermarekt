using supermarekt.Properties;
using Supermarker.Business;
using Supermarker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace supermarekt.View
{
    public partial class FormProducts : Form
    {
        private readonly PayModeProductsDAO payModeProductsDAO;
        private bool EditMode;
        private bool IsNew;

        internal FormProducts(ref PayModeProductsDAO payModeProductsDAO)
        {
            InitializeComponent();
            this.payModeProductsDAO = payModeProductsDAO;
            LoadPayModeList();
         

        }

        private void LoadPayModeList()
        {
            dataGridViewProducts.Rows.Clear();
            foreach (KeyValuePair<int, PayModelProducts> payModeKV in this.payModeProductsDAO.GetPayModelProductList())
            {
                dataGridViewProducts.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name, payModeKV.Value.Price, payModeKV.Value.Stock, payModeKV.Value.Category_id);
            }
        }

        private void ActivateControls(bool state)
        {

            if (EditMode == true)
            {
                BtnNew.Text = "Save";
                BtnNew.Image = Resources.save;
                BtnEdit.Text = "Cancel";
                BtnEdit.Image = Resources.cancel;
            }
            else
            {
                BtnNew.Text = "New";
                BtnNew.Image = Resources._new;
                BtnEdit.Text = "Edit";
                BtnEdit.Image = Resources.edit;
            }

            TxtName.Enabled = state;
            TxtPrice.Enabled = state;
            TxtStock.Enabled = state;
            TxtCategory_id.Enabled = state;
           

            dataGridViewProducts.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;
          
            TxtPrice.Focus();
            TxtStock.Focus();
            TxtCategory_id.Focus();
            TxtName.Focus();
        }
        private bool SavePayMode()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                PayModelProducts payModelProducts = new(null, TxtName.Text, Int32.Parse(TxtPrice.Text), Int32.Parse(TxtStock.Text), TxtCategory_id.Text);
                if (payModeProductsDAO.AddPayModelProduct(payModelProducts) == false)
                {
                    MessageBox.Show("Error to save", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Pay mode save susessfuly", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadPayModeList();
            }
            else
            {
                int id = Int32.Parse(TxtId.Text);
                PayModelProducts payModelProducts = payModeProductsDAO.GetPayModelProduct(id);
                if (payModelProducts != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    payModelProducts.Name = TxtName.Text;
                    payModelProducts.Price = Int32.Parse(TxtPrice.Text);
                    payModelProducts.Stock = Int32.Parse(TxtStock.Text);
                    payModelProducts.Category_id = TxtCategory_id.Text;

                    payModeProductsDAO.UpdatePayModelProduct(id, payModelProducts);
                    LoadPayModeList();
                    return true;
                }
                return false;
            }
            return true;
        }


        private bool IsNameFilled()
        {
            if ((TxtName.Text).Trim().Length == 0)
            {
                MessageBox.Show("The Pay mode name is required", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TxtName.Focus();
                return false;
            }
            return true;
        }















        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (EditMode == false)
            {
                EditMode = true;
                IsNew = true;
            }
            else
            {
                if (SavePayMode() == false)
                {
                    return;
                };
                IsNew = false;
                EditMode = false;

            }
            TxtId.Text = "";
            TxtName.Text = "";
            TxtPrice.Text = "";
            TxtStock.Text = "";
            TxtCategory_id.Text = "";
            ActivateControls(EditMode);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            {
                if (EditMode == true)
                {
                    EditMode = false;
                }
                else
                {
                    if (TxtName.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Select one register of the list", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        return;
                    };
                    EditMode = true;
                    IsNew = false;

                }
                ActivateControls(EditMode);



            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            {
                if (TxtId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Select one register of the list", "Alert",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                int id = Int32.Parse(TxtId.Text);
                DeleteData(id);
                ActivateControls(false);
            }


        }

        private bool DeleteData(int id)
        {
            bool success = payModeProductsDAO.RemovePayModelProduct(id);
            if (success)
            {
                MessageBox.Show("Pay mode deleted successfully", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadPayModeList();
            }
            else
            {
                MessageBox.Show("Error deleting pay mode", "Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return success;
        }

        private void dataGridViewProducts_Click(object sender, EventArgs e)
        {
            TxtId.Text = dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            TxtPrice.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            TxtStock.Text = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();
            TxtCategory_id.Text = dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
           
        }

        public void TxtCategory_id_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        public void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
