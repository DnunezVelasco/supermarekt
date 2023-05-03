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

namespace supermarekt.View
{
    public partial class FormProvaiders : Form
    {
       
        private readonly PayModeProvaidersDAO payModeProvaidersDAO;
        private bool EditMode;
        private bool IsNew;

        internal FormProvaiders(ref PayModeProvaidersDAO payModeProvaidersDAO)
        {
            InitializeComponent();
            this.payModeProvaidersDAO = payModeProvaidersDAO;
            LoadPayModeList();


        }

        private void LoadPayModeList()
        {
            dataGridViewProvaiders.Rows.Clear();
            foreach (KeyValuePair<int, PayModelProvaiders> payModeKV in this.payModeProvaidersDAO.GetPayModelProvaidersList())
            {
                dataGridViewProvaiders.Rows.Add(payModeKV.Value.Id, payModeKV.Value.Name, payModeKV.Value.LastName, payModeKV.Value.Address, payModeKV.Value.Phone,payModeKV.Value.Email);
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
            TxtLastName.Enabled = state;
            TxtAddress.Enabled = state;
            TxtEmail.Enabled = state;
            TxtPhone.Enabled = state;


            dataGridViewProvaiders.Enabled = !state;
            BtnDelete.Enabled = !state;
            BtnClose.Enabled = !state;

            TxtName.Focus();
            TxtAddress.Focus();
            TxtEmail.Focus();
            TxtPhone.Focus();
            TxtLastName.Focus();
        }



        private bool SavePayMode()
        {
            if (!IsNameFilled())
            {
                return false;
            }
            if (IsNew == true)
            {
                PayModelProvaiders payModelProvaiders = new(null, TxtName.Name ,TxtLastName.Text,TxtAddress.Text, Int32.Parse(TxtPhone.Text),TxtEmail.Text);
                if (payModeProvaidersDAO.AddPayModelProduct(payModelProvaiders) == false)
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
                PayModelProvaiders payModelProvaiders = payModeProvaidersDAO.GetPayModelProduct(id);
                if (payModelProvaiders != null)
                {
                    if (!IsNameFilled())
                    {
                        return false;
                    }
                    payModelProvaiders.Name = TxtName.Text;
                    payModelProvaiders.LastName = TxtLastName.Text;
                    payModelProvaiders.Address = TxtAddress.Text;
                    payModelProvaiders.Phone = Int32.Parse(TxtPhone.Text);
                    payModelProvaiders.Email = TxtEmail.Text;
                   

                    payModeProvaidersDAO.UpdatePayModelProduct(id, payModelProvaiders);
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
            TxtLastName.Text = "";
            TxtPhone.Text = "";
            TxtAddress.Text = "";
          
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
            bool success = payModeProvaidersDAO.RemovePayModelProduct(id);
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

        private void dataGridViewProvaiders_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProvaiders_Click(object sender, EventArgs e)
        {
          
        }

        private void dataGridViewProvaiders_Click_1(object sender, EventArgs e)
        {
            TxtId.Text = dataGridViewProvaiders.CurrentRow.Cells[0].Value.ToString();
            TxtName.Text = dataGridViewProvaiders.CurrentRow.Cells[1].Value.ToString();
            TxtLastName.Text = dataGridViewProvaiders.CurrentRow.Cells[2].Value.ToString();
            TxtAddress.Text = dataGridViewProvaiders.CurrentRow.Cells[3].Value.ToString();
            TxtPhone.Text = dataGridViewProvaiders.CurrentRow.Cells[4].Value.ToString();
            TxtEmail.Text = dataGridViewProvaiders.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
