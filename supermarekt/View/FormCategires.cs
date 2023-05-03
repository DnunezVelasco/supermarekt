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
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace supermarekt.View
{
    public partial  class FormCategires : Form
    {
        private readonly PayModeCaetegoriesDAO payModeCaetegoriesDAO;
        private bool EditMode;
        private bool IsNew;
        internal FormCategires(ref PayModeCaetegoriesDAO payModeCaetegoriesDAO)
        {
            InitializeComponent();

            this.payModeCaetegoriesDAO = payModeCaetegoriesDAO;
            LoadPayModeList();
            EditMode = false;
            IsNew = false;
           
        }

       

        public void LoadPayModeList()
        {
            DataGridViewCategories.Rows.Clear();
            foreach (KeyValuePair<int, PayModelCategories> payModeKV in this.payModeCaetegoriesDAO.GetPayModelCategoriesList())
            {
                DataGridViewCategories.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name);
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

            TxtName.Focus();
        }
        private bool SavePayMode()
        {
            comboBox1.Items.Add(TxtName.Text);
            comboBox1.SelectedIndex = 0;

           

            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                PayModelCategories payModelCategories = new(null, TxtName.Text);
                if (payModeCaetegoriesDAO.AddPayModelProduct(payModelCategories) == false)
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
                PayModelCategories payModelCategories = payModeCaetegoriesDAO.GetPayModelProduct(id);
                if (payModelCategories != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    payModelCategories.Name = TxtName.Text;
                    payModeCaetegoriesDAO.UpdatePayModelProduct(id, payModelCategories);
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







        private void DataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = DataGridViewCategories.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = DataGridViewCategories.CurrentRow.Cells[1].Value.ToString();





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
            bool success = payModeCaetegoriesDAO.RemovePayModelProduct(id);
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

        private void BtnNew_Click(object sender, EventArgs e)
        {
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
                ActivateControls(EditMode);


             
            }


        

        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewCategories_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     




            string nombre = TxtName.Text; // obtenemos el valor del textbox
            comboBox1.Items.Add(TxtName.Text);
            Preuba formDestino = new Preuba(nombre); // creamos el formulario destino y le pasamos el nombre como parámetro
            formDestino.Show(); // mostramos el formulario destino


        }

        private void DataGridViewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void DataGridViewCategories_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
