using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace HubronSystemClone
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {

        public static SqlConnection Get_DB_Connection()

        {

            string cn_String = Properties.Settings.Default.connection_String;

            SqlConnection cn_connection = new SqlConnection(cn_String);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();


            return cn_connection;

        }
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
