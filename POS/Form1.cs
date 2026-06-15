using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public static int totalPrice = 0;

        private void addMenu(string menuName, int price)
        {
            bool found = false;
            foreach(ListViewItem item in listView1.Items)
            {
                if (item.Text == menuName)
                {
                    int qty = int.Parse(item.SubItems[1].Text);
                    qty++;
                    item.SubItems[1].Text = qty.ToString();
                    item.SubItems[2].Text = (qty * price).ToString();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                ListViewItem item = new ListViewItem(menuName);
                item.SubItems.Add("1");
                item.SubItems.Add(price.ToString());

                listView1.Items.Add(item);
            }

            totalPrice += price;
            lblTotal.Text = "총 금액 : " + totalPrice.ToString("N0") + "원";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            addMenu("아메리카노", 2500);
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            addMenu("카페라떼", 3000);
        }

        private void btnCake_Click(object sender, EventArgs e)
        {
            addMenu("케이크", 10000);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int price = int.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                totalPrice -= price;
                lblTotal.Text = "총 금액 : " + totalPrice.ToString("N0") + "원";
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        public void ClearList()
        {
            listView1.Items.Clear();
            totalPrice = 0;
            lblTotal.Text = "총 금액 : " + totalPrice.ToString("N0") + "원";
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void mnuNewOrder_Click(object sender, EventArgs e)
        {
            ClearList();
        }

        private void mnuSales_Click(object sender, EventArgs e)
        {
            //파일 읽기
            string fileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            StreamReader sr = new StreamReader(fileName);
            string line;
            int price = 0;
            while ((line = sr.ReadLine()) != null)
            {
                price += int.Parse(line);
            }

            MessageBox.Show("현재까지의 매출금액 : " + price.ToString("N0") + "원입니다.",
                "현재매출확인",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }
    }
}
