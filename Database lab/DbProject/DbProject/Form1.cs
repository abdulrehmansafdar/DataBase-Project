using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace DbProject
{
    public partial class STForm : Form
    {
        private SqlConnection conn;
        private TabControl tabControl1; // Correct type declaration
        public int StudentID;

        public STForm()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=DESKTOP-54IBTRP\\SQLEXPRESS;Initial Catalog=DBLabProject;Integrated Security=True;");
            tabControl1 = new TabControl();
            tabControl1.SuspendLayout();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            if (conn.State == ConnectionState.Open)
            {
                using (SqlCommand cmd = new SqlCommand("Select * from StudentData", conn))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dt.Load(dr);
                    }

                    StudentRecord.DataSource = null;
                    StudentRecord.DataSource = dt;
                }
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            if (isValid())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO StudentData VALUES (@Name,@FatherName,@RegNo,@Adress,@Phone)", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                        cmd.Parameters.AddWithValue("@RegNo", txtRegno.Text);
                        cmd.Parameters.AddWithValue("@Adress", txtAdress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student added successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetStudentsRecord();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to open database connection.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private bool isValid()
        {
            if (txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Student name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Your button2_Click logic
            tabControl1.SelectedIndex = 1;
            if (StudentID>0)
            {
                SqlCommand cmd = new SqlCommand("Update StudentData SET Name=@Name,FatherName=@FatherName,RegNo=@RegNo,Adress=@Adress,Phone=@Phone Where StudentID=@ID", conn);
                
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@RegNo", txtRegno.Text);
                    cmd.Parameters.AddWithValue("@Adress", txtAdress.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                    MessageBox.Show("Student updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetStudentsRecord();
                
            }
            else
            {
                MessageBox.Show("Please select student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        

        private void button3_Click(object sender, EventArgs e)
        {
            // Your button3_Click logic
            tabControl1.SelectedIndex = 2;
            if (StudentID>0)
            {
                SqlCommand cmd = new SqlCommand("Delete From StudentData  Where StudentID=@ID", conn);

                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.AddWithValue("@ID", this.StudentID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Student Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
            }
            else
            {
                MessageBox.Show("Please select some student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtRegno.Clear();
            txtAdress.Clear();
            txtPhone.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your label1_Click logic
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            // Your txtPhone_TextChanged logic
        }

        private void txtRegno_TextChanged(object sender, EventArgs e)
        {
            // Your txtRegno_TextChanged logic
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Your label3_Click logic
        }

        private void StudentDataR(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(StudentRecord.SelectedRows[0].Cells[0].Value);
            txtStudentName.Text = StudentRecord.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = StudentRecord.SelectedRows[0].Cells[2].Value.ToString();
            txtRegno.Text= StudentRecord.SelectedRows[0].Cells[3].Value.ToString();
            txtAdress.Text= StudentRecord.SelectedRows[0].Cells[4].Value.ToString();
            txtPhone.Text= StudentRecord.SelectedRows[0].Cells[5].Value.ToString();
        }

        
    }
}
