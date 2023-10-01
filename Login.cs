using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ATMProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
      //  public static string AccountNumber;
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tnLogin_Click(object sender, EventArgs e)
        {
            if (cmbLoginas.Text != "" || cmbLoginas.Text != "    ")
            {
                if (txtAccountNo.Text != "" || txtAccountNo.Text != "    ")
                {
                    if (txtPin.Text != "" || txtPin.Text != "    ")
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString= ConfigurationManager.ConnectionStrings["ATM"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = @"select * from ATMusers
                                        where 
                                        Account_Number like @accountnumber and Pin like @pin and Type like @type;";
                        cmd.Parameters.AddWithValue("@accountnumber", txtAccountNo.Text);
                        cmd.Parameters.AddWithValue("@pin", txtPin.Text);
                        cmd.Parameters.AddWithValue("@type", cmbLoginas.Text);

                        try
                        {
                            con.Open();
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                if (cmbLoginas.Text=="Admin")
                                {
                                    AddAccount ac = new AddAccount();
                                    this.Hide();
                                    ac.Show();
                                }
                                else
                                {
                                   // AccountNumber= txtLAccount.Text;
                                    Home h = new Home();
                                    h.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("User is Not Exit");
                            }
                            dr.Close();

                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                                con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please insert pin");
                    }
                }
                else
                {
                    MessageBox.Show("Account Field can not be Empty");
                }
            }
            else
            {
                MessageBox.Show("Please Select Login as Type");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbLoginas.Text=" ";
            txtAccountNo.Text=" ";
            txtPin.Text=" ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure....!!!", "Do you Want Exist", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ThanksPage t = new ThanksPage();
                t.Show();


            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}
