﻿using ProductosSite.Services;
using System;
using System.Data;
using System.Web.UI;

namespace ProductosSite
{
    public partial class Home1 : System.Web.UI.Page
    {
        private ProductService _service = new ProductService();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoProductos.aspx");
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            if(!Page.IsValid)
            {
                return;
            }

            int codeNum = -1;

            this.lblMessage.Text = string.Empty;

            if (string.IsNullOrEmpty(txtCode.Text) ||
                !int.TryParse(txtCode.Text, out codeNum))
            {
                this.lblMessage.Text = "Debe ingresar un codigo de producto numerico";
                ResetFields();
                return;
            }

            DataRow drProduct;

            try
            {
                drProduct = _service.GetProduct(codeNum);
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
                ResetFields();
                return;
            }

            txtCategory.Text = drProduct["categoria"].ToString();
            txtCostPrice.Text = drProduct["preciocosto"].ToString();
            txtIva.Text = drProduct["iva"].ToString();
            txtMargin.Text = drProduct["margen"].ToString();
            txtName.Text = drProduct["nombre"].ToString();
            lblGrossPrice.Text = drProduct["preciobruto"].ToString();
            lblSellPrice.Text = drProduct["precioventa"].ToString();
        }

        private void SetGrossAndSellPrices()
        {
            Page.Validate();
            if (!Page.IsValid)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtCostPrice.Text) ||
                string.IsNullOrEmpty(txtMargin.Text) ||
                string.IsNullOrEmpty(txtIva.Text))
            {
                return;
            }

            decimal costPrice = decimal.Parse(txtCostPrice.Text);
            decimal margin = decimal.Parse(txtMargin.Text);
            decimal iva = decimal.Parse(txtIva.Text);

            decimal grossPrice = costPrice + (costPrice * margin);
            decimal sellPrice = grossPrice + (grossPrice * iva);

            lblGrossPrice.Text = grossPrice.ToString("#.##");
            lblSellPrice.Text = sellPrice.ToString("#.##");
        }

        private void ResetFields()
        {
            txtCategory.Text = string.Empty;
            txtCostPrice.Text = string.Empty;
            txtIva.Text = string.Empty;
            txtMargin.Text = string.Empty;
            txtName.Text = string.Empty;
            lblGrossPrice.Text = string.Empty;
            lblSellPrice.Text = string.Empty;
        }

        protected void txtCostPrice_TextChanged(object sender, EventArgs e)
        {
            SetGrossAndSellPrices();
        }

        protected void txtMargin_TextChanged(object sender, EventArgs e)
        {
            SetGrossAndSellPrices();
        }

        protected void txtIva_TextChanged(object sender, EventArgs e)
        {
            SetGrossAndSellPrices();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            int codeNum = -1;

            this.lblMessage.Text = string.Empty;

            if (string.IsNullOrEmpty(txtCode.Text) ||
                !int.TryParse(txtCode.Text, out codeNum))
            {
                this.lblMessage.Text = "Debe ingresar un codigo de producto numerico";
                return;
            }

            var resp = _service.InsertProduct(
                codeNum,
                txtName.Text,
                txtCategory.Text,
                decimal.Parse(txtCostPrice.Text),
                double.Parse(txtMargin.Text),
                double.Parse(txtIva.Text),
                decimal.Parse(lblGrossPrice.Text),
                decimal.Parse(lblSellPrice.Text));

            if (resp)
            {
                this.lblMessage.Text = "Producto "+ codeNum +" cargado correctamente";
            }
            else
            {
                this.lblMessage.Text = "Ocurrio un error, verifique los tipos datos y que el codigo no se encuentre cargado.";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ResetFields();

            if (!Page.IsValid)
            {
                return;
            }

            pnlDialog.Visible = true;
            lblMessage.Text = string.Empty;
            lblDialog.Text = "Desea eleminar este registro? (si/no)";
        }

        protected void ConfirmDeleteProduct(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            int codeNum = -1;

            this.lblMessage.Text = string.Empty;

            if (string.IsNullOrEmpty(txtCode.Text) ||
                !int.TryParse(txtCode.Text, out codeNum))
            {
                this.lblMessage.Text = "Debe ingresar un codigo de producto numerico";
                ResetFields();
                return;
            }

            var resp = _service.DeleteProduct(codeNum);

            if (resp)
            {
                this.lblMessage.Text = "Producto "+ codeNum +" borrado correctamente";
                txtCode.Text = string.Empty;
            }
            else
            {
                this.lblMessage.Text = "Ocurrio un error, verifique que el codigo exista.";
            }

            pnlDialog.Visible = false;
        }
  
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            int codeNum = -1;

            this.lblMessage.Text = string.Empty;

            if (string.IsNullOrEmpty(txtCode.Text) ||
                !int.TryParse(txtCode.Text, out codeNum))
            {
                this.lblMessage.Text = "Debe ingresar un codigo de producto numerico";
                return;
            }

            var resp = _service.UpdateProduct(
                codeNum,
                txtName.Text,
                txtCategory.Text,
                decimal.Parse(txtCostPrice.Text),
                double.Parse(txtMargin.Text),
                double.Parse(txtIva.Text),
                decimal.Parse(lblGrossPrice.Text),
                decimal.Parse(lblSellPrice.Text));

            if (resp)
            {
                this.lblMessage.Text = "Producto "+ codeNum +" actualizado correctamente";
            }
            else
            {
                this.lblMessage.Text = "Ocurrio un error, verifique los tipos datos y que el codigo no se encuentre cargado.";
            }
        }

        protected void btnCancelDialog_Click(object sender, EventArgs e)
        {
            pnlDialog.Visible = false;
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            
            Page.ClientScript.RegisterStartupScript(this.GetType(), "myCloseScript", "window.open('https://www.google.com', '_self', '');", true);
        }
    }
}