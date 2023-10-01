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

namespace ATMProject
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        public bool uniqueUsername = false;
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure....!!!", "Do you Want LogOut", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login n = new Login();
                n.Show();


            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GGRFU8L;Initial Catalog=ATM;Integrated Security=True");
        //con.ConnectionString= ConfigurationManager.ConnectionStrings["ATM"].ConnectionString;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtAccountNo.Text==""|| txtFName.Text==""||txtLName.Text==""||txtPin.Text==""||txtLName.Text==""||txtAddress.Text==""||cobType.Text==""||txtBalance.Text==""||txtEducation.Text==""||txtOccupation.Text=="")
            {
                MessageBox.Show("please insert information");
            }
            else
            {
                try
                {
                  
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"insert into ATMusers 
                                 (Account_Number, First_Name, Last_Name,Address,Phone_No,Pin, Balance,Education,Occupation,DOB,Type) 
                                 values
                                 (@AccountNo, @FName,@LName, @Address, @Phone, @Pin, @Balance, @Education,@Occupation,@dob,@cobType);";
                    cmd.Parameters.AddWithValue("@AccountNo", txtAccountNo.Text);
                    cmd.Parameters.AddWithValue("@FName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@LName", txtLName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtLName.Text);
                    cmd.Parameters.AddWithValue("@Pin", txtPin.Text);
                    cmd.Parameters.AddWithValue("@Balance", txtBalance.Text);
                    cmd.Parameters.AddWithValue("@Education", txtEducation.Text);
                    cmd.Parameters.AddWithValue("@Occupation", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@dob", dob.Text);
                    cmd.Parameters.AddWithValue("@cobType", cobType.Text);
                    con.Open();
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        if (MessageBox.Show("User Added successfuly!! Add another User?", "Add new user?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtAccountNo.Text = "";
                            txtFName.Text = "";
                            txtLName.Text = "";
                            txtAddress.Text = "";
                            txtLName.Text = "";
                            txtPin.Text = "";
                            txtBalance.Text = "";
                            txtEducation.Text= "";
                            txtOccupation.Text = "";
                            dob.Text = "";
                            cobType.Text = "";
                        }
                        else
                        {
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("User not Added, something went wrong!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Going Wrong");//MessageBox.Show(ex.Message);
                }


            }
        }
        private void btncheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"select * from  ATMusers  where Account_Number =@AcNo;";
            cmd.Parameters.AddWithValue("@AcNo", txtAccountNo.Text);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    btnSubmit.Enabled = false;
                    uniqueUsername = false;
                    MessageBox.Show("Account_Number"+ txtAccountNo.Text+" already exist please choose different user and Account_Number");
                    txtAccountNo.Text = "";
                    txtFName.Text = "";
                    txtLName.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtPin.Text = "";
                    txtBalance.Text = "";
                    txtEducation.Text= "";
                    txtOccupation.Text = "";
                    dob.Text = "";
                    cobType.Text = "";
                }
                else
                {
                    MessageBox.Show("To Add New User Please Press OK Then...Select Submit Button !!");
                    uniqueUsername = true;
                    btnSubmit.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is Wrong");// MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
