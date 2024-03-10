using System.Data;
using System.Data.SqlClient;
namespace _21520604_csdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string connectString = @"Data Source=BAOBAO\SQLEXPRESS;Initial Catalog=quanlysinhvien;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(connectString);
                sqlCon.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM SinhVien", sqlCon);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Gán dữ liệu cho DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
