using Lab04_04.ProductOrderData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_04
{
    public partial class FormProduct : Form
    {
        private ProductContextDB context;
        private int orderMonth;
        private int deliveryMonth;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            context = new ProductContextDB();
            List<Invoice> listInvoice = context.Invoices.ToList();
            List<Invoice> listData = GetOrder();
            BindGrid(listData);
        }

        private void BindGrid(List<Invoice> listInvoice)
        {
            int stt = 1;
            dgv_orderinfo.Rows.Clear();
            foreach (var item in listInvoice)
            {
                int index = dgv_orderinfo.Rows.Add();
                dgv_orderinfo.Rows[index].Cells[0].Value = stt++;
                dgv_orderinfo.Rows[index].Cells[1].Value = item.InvoiceNo;
                dgv_orderinfo.Rows[index].Cells[2].Value = item.OrderDate;
                dgv_orderinfo.Rows[index].Cells[3].Value = item.DeliveryDate;
                decimal sum = context.Orders.Where(detail => detail.InvoiceNo == item.InvoiceNo).Sum(detail => detail.Price * detail.Quantity);
                dgv_orderinfo.Rows[index].Cells[4].Value = sum;
            }
            txt_amount.Text = dgv_orderinfo.Rows.Count.ToString();

        }
        private List<Invoice> GetOrder()
        {
            DateTime orderDate = dtp_orderdate.Value;
            DateTime deliveryDate = dtp_deliverydate.Value;
            var listInvoice = context.Invoices.Where(x => x.OrderDate >= orderDate && x.DeliveryDate <= deliveryDate);
            return listInvoice.ToList();
        }
        private List<Invoice> GetAllInMonth()
        {
            var listInvoice = context.Invoices.Where(x => x.OrderDate.Month >= orderMonth && x.DeliveryDate.Month <= deliveryMonth);
            return listInvoice.ToList();
        }
        private void dtp_orderdate_ValueChanged(object sender, EventArgs e)
        {
            orderMonth = dtp_orderdate.Value.Month;
            deliveryMonth = dtp_deliverydate.Value.Month;
            List<Invoice> listInvoice = context.Invoices.ToList();
            List<Invoice> listData;
            if (cb_showall.Checked)
                listData = GetAllInMonth();
            else
                listData = GetOrder();
            BindGrid(listData);
            txt_amount.Text = dgv_orderinfo.Rows.Count.ToString();
        }
    }
}
