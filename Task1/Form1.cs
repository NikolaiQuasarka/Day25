using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Task1
{
    public partial class Form1 : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["DbPath"].ConnectionString;
        public Form1()
        {
            InitializeComponent();

            string query = "SELECT * FROM Note";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
                da.Fill(ds, "Note");
                dataGridView1.DataSource = ds.Tables["Note"];
            }
        }
        DataSet ds = new DataSet();

        private void buttonAddConsultation_Click(object sender, EventArgs e)
        {
            if (TimeOnly.TryParse(textBox1.Text, out TimeOnly time) && !string.IsNullOrEmpty(textBoxFullName.Text))
            {
                DateTime date = dateTimePicker1.Value; date = date.Date + time.ToTimeSpan();
                if (ds.Tables["Note"] != null)
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        conn.Open();
                        string query = "SELECT * FROM Note";
                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
                        DataRow dr = ds.Tables["Note"].NewRow();

                        
                        dr[0] = DBNull.Value;
                        dr[1] = textBoxFullName.Text;
                        dr[2] = textBoxSubj.Text;
                        dr[3] = date.ToString("yyyy-MM-dd HH:mm:ss");
            
                        ds.Tables["Note"].Rows.Add(dr);
                        da.Update(ds, "Note");

                        SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('Note')", conn);
                        int lastId = (int)Convert.ToInt32(cmd.ExecuteScalar());

                        dr[0] = lastId; 
                    }
            }
        }

        /*private void UpdateStudents()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                string query = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
                da.Fill(ds, "Student");
                comboBoxFio.DataSource = ds.Tables["Student"];
                comboBoxFio.DisplayMember = "FullName";
                comboBoxFio.ValueMember = "IdStudent";
            }
        }*/

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {              
                using (SqlConnection conn = new SqlConnection(connection)) {
                    string query = "SELECT * FROM Note";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(da);
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    da.Update(ds, "Note");
                }
                
            }
        }
    }
}
