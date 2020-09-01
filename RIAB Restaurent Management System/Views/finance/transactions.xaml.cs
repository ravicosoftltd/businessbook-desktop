﻿
using RIAB_Restaurent_Management_System.bll;
using RIAB_Restaurent_Management_System.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RIAB_Restaurent_Management_System.Views.finance
{
    /// <summary>
    /// Interaction logic for transactions.xaml
    /// </summary>
    public partial class transactions : Window
    {
        public transactions()
        {
            InitializeComponent();
            var db = new dbctx();
            foreach (var item in db.financetransaction.ToList())
            {
                dg.Items.Add(item);
            }

            var allaccount = db.financeaccount.ToList();
            fromaccount_combobox.ItemsSource = allaccount;
            fromaccount_combobox.DisplayMemberPath = "name";
            fromaccount_combobox.SelectedValuePath = "id";
            
            toaccount_combobox.ItemsSource = allaccount;
            toaccount_combobox.DisplayMemberPath = "name";
            toaccount_combobox.SelectedValuePath = "id";
        }
        private void save(object sender, RoutedEventArgs e)
        {
            try
            {
                if (fromaccount_combobox.SelectedItem == null || toaccount_combobox.SelectedItem == null)
                {
                    MessageBox.Show("Please select account");
                }
                if (tb_amount.Text == "")
                {
                    MessageBox.Show("Please enter amount");
                }

                var amount = Convert.ToDouble(tb_amount.Text);
                var fromaccount = (int)fromaccount_combobox.SelectedValue;
                var toaccount = (int)toaccount_combobox.SelectedValue;
                financeutils.insertexpence(fromaccount, toaccount, amount);

                MessageBox.Show("Operation Successfull");
                Close();
                new expences().Show();
            }
            catch
            {
                MessageBox.Show("Operation Successfull");
            }


        }
    }
}
