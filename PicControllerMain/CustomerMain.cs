﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PicControllerMain.ParamsEntity;

namespace PicControllerMain
{
    public partial class CustomerMain : Form
    {
        public CustomerMain()
        {
            InitializeComponent();
            LoadCustomerList();
        }

        /// <summary>
        /// 加载客户数据集合
        /// </summary>
        public void LoadCustomerList()
        {
            DataController controller = new DataController();
            CustomerSearchParams param = new CustomerSearchParams()
            {
                ParamsCustomerName = txtCustomerName.Text.Trim(),
                ParamsPhone = txtPhone.Text.Trim(),
                ParamsAddress = txtAddress.Text.Trim()
            };
            IQueryable list = controller.LoadCustomerList(param);
            foreach (dynamic customer in list)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(customer.CustomerID);
                item.SubItems.Add(customer.CustomerName);
                item.SubItems.Add(customer.CustomerPhone);
                item.SubItems.Add(customer.EnteredDate);
                item.SubItems.Add(customer.Address);
                
                lvCustomerList.Items.Add(item);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCustomerList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        /// <summary>
        /// 打开新建客户窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerEdit edit = new CustomerEdit();
            edit.Show();
        }
    }
}
