using BlApi;
using BO;
using Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Sales : Form
    {
        IBl _ibl = Factory.Get();

        public Sales()
        {
            InitializeComponent();
            salesGrid.DataSource = _ibl.Sale.ReadAll();
            saleIdInput.ReadOnly = true;
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            int salesId;
            int productId;
            int amountNeeded;
            double priceAfterDiscount;
            bool clubCustomer;
            DateTime beginningDate;
            DateTime endingDate;

            if (!int.TryParse(saleIdInput.Text, out salesId))
                wrongSaleDetails.SetError(saleIdInput, "Invalid sale ID");
            else
            {
                if (!int.TryParse(saleProductIdInput.Text, out productId))
                    wrongSaleDetails.SetError(saleProductIdInput, "Invalid prodcut code");
                else
                {
                    if (!int.TryParse(amountNeededInput.Text, out amountNeeded))
                        wrongSaleDetails.SetError(amountNeededInput, "Invalid amount");
                    else
                    {
                        if (!double.TryParse(priceAfterDiscountInput.Text, out priceAfterDiscount))
                            wrongSaleDetails.SetError(priceAfterDiscountInput, "Invalid price");
                        else
                        {
                            clubCustomer = clubCustomerCheckBox.Checked;
                            beginningDate = beginningDateInput.Value;
                            endingDate = endingDateInput.Value;
                            if (endingDate < beginningDate)
                                wrongSaleDetails.SetError(endingDateInput, "Ending date should be later than beginning date");
                            else
                            {
                                try
                                {
                                    _ibl.Sale.Create(new Sale(salesId, productId, amountNeeded, priceAfterDiscount, clubCustomer, beginningDate, endingDate));
                                    salesGrid.DataSource = _ibl.Sale.ReadAll();
                                }
                                catch (ProductIdNotFoundException pidnf)
                                {
                                    wrongSaleDetails.SetError(saleProductIdInput, pidnf.Message);
                                }
                                catch (Exception ex)
                                {
                                    wrongSaleDetails.SetError(addSaleButton, ex.Message);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void salesGrid_selectionChanged(object sender, EventArgs e)
        {
            if (salesGrid.CurrentRow?.DataBoundItem is BO.Sale selectedSale)
            {
                saleIdInput.Text = selectedSale.Id.ToString();
                saleProductIdInput.Text = selectedSale.ProductId.ToString();
                amountNeededInput.Value = selectedSale.AmountNeeded;
                priceAfterDiscountInput.Text = selectedSale.PriceAfterDiscount.ToString();
                beginningDateInput.Value = selectedSale.SaleBeginningDate;
                endingDateInput.Value = selectedSale.SaleEndingDate;
                clubCustomerCheckBox.Checked = selectedSale.ClubCustomerSale;
            }
        }

        private void deleteSaleButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(saleIdInput.Text, out int saleId))
            {
                wrongSaleDetails.SetError(saleIdInput, "Invalid ID");
            }
            else
                _ibl.Sale.Delete(saleId);
            salesGrid.DataSource = Factory.Get().Sale.ReadAll();
        }

        private void updateSaleButton_Click(object sender, EventArgs e)
        {
            int salesId;
            int productId;
            int amountNeeded;
            double priceAfterDiscount;
            bool clubCustomer;
            DateTime beginningDate;
            DateTime endingDate;

            if (!int.TryParse(saleIdInput.Text, out salesId))
                wrongSaleDetails.SetError(saleIdInput, "Invalid sale ID");
            else
            {
                if (!int.TryParse(saleProductIdInput.Text, out productId))
                    wrongSaleDetails.SetError(saleProductIdInput, "Invalid prodcut code");
                else
                {
                    if (!int.TryParse(amountNeededInput.Text, out amountNeeded))
                        wrongSaleDetails.SetError(amountNeededInput, "Invalid amount");
                    else
                    {
                        if (!double.TryParse(priceAfterDiscountInput.Text, out priceAfterDiscount))
                            wrongSaleDetails.SetError(priceAfterDiscountInput, "Invalid price");
                        else
                        {
                            clubCustomer = clubCustomerCheckBox.Checked;
                            beginningDate = beginningDateInput.Value;
                            endingDate = endingDateInput.Value;
                            if (endingDate < beginningDate)
                                wrongSaleDetails.SetError(endingDateInput, "Ending date should be later than beginning date");
                            else
                            {
                                try
                                {
                                    _ibl.Sale.Update(new Sale(salesId, productId, amountNeeded, priceAfterDiscount, clubCustomer, beginningDate, endingDate));
                                    salesGrid.DataSource = _ibl.Sale.ReadAll();
                                }
                                catch (ProductIdNotFoundException pidnf)
                                {
                                    wrongSaleDetails.SetError(saleProductIdInput, pidnf.Message);
                                }
                                catch (Exception ex)
                                {
                                    wrongSaleDetails.SetError(addSaleButton, ex.Message);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
