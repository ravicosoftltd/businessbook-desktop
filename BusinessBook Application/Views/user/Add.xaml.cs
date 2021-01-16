﻿
using BusinessBook.bll;
using BusinessBook.data;
using BusinessBook.data.dapper;
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

namespace BusinessBook.Views.user
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        string rtype;
        data.dapper.user loggedinpersond;
        public Add(string roletype)
        {
            InitializeComponent();
            this.loggedinpersond = userutils.loggedinuserd;
            this.rtype = roletype;
            //var db = new dbctx();

            var roles = new string[] { "admin", "user", "customer","vendor" };
            if (roletype == "staff")
            {
                roles = new string[] { "admin", "user" };
            }
            else if (roletype == "customer")
            {
                roles = new string[] { "customer" };
                tb_Password.IsEnabled = false;
                tb_UserName.IsEnabled = false;
            }
            else if (roletype == "vendor")
            {
                roles = new string[] { "vendor" };
                tb_Password.IsEnabled = false;
                tb_UserName.IsEnabled = false;
            }
            cb_Role.ItemsSource = roles;
        }
        private void btn_Save(object sender, RoutedEventArgs e)
        {
            if (tb_Name.Text == "")
            {
                MessageBox.Show("Please enter name", "Info");
                return;
            }
            if (cb_Role.SelectedValue == null)
            {
                MessageBox.Show("Please select role", "Info");
                return;
            }
            if ((string)cb_Role.SelectedValue == "admin" || (string)cb_Role.SelectedValue == "user") {
                if (tb_UserName.Text == "" || tb_Password.Text=="") {
                    MessageBox.Show("Enter Username or password", "Info");
                    return;
                }
            }
            data.dapper.user person = new data.dapper .user();
            person.name = tb_Name.Text;
            person.role = (string)cb_Role.SelectedValue;
            try
            {
                person.address = tb_Address.Text;
                person.phone = tb_Phone.Text;
                person.phone2 = tb_Phone2.Text;
                person.username = tb_UserName.Text;
                person.password = tb_Password.Text;

            }
            catch { }
            userrepo a = new userrepo();
            a.save(person);
            MessageBox.Show("Person Saved", "Info");
            Close();
            new Add(this.rtype).Show();
                    
            
        }
    }
}