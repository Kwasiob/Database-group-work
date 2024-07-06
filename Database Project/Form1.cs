using System.Configuration;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Database_Project
{
    public partial class  Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

private void btnInsert_Click(object sender, EventArgs e)
{
    int invoiceNo;
    if (!int.TryParse(txtInvoiceNo.Text, out invoiceNo))
    {
        MessageBox.Show("Invoice No must be a valid integer.");
        return;
    }

    DateTime dateRaised;
    if (!DateTime.TryParse(txtDateRaised.Text, out dateRaised))
    {
        MessageBox.Show("Date Raised must be a valid date.");
        return;
    }

    DateTime datePaid;
    if (!DateTime.TryParse(txtDatePaid.Text, out datePaid))
    {
        // Date Paid can be nullable, handle accordingly
        datePaid = DateTime.MinValue; // or another default value
    }

    string creditCardNo = txtCreditCardNo.Text;
    string holdersName = txtHoldersName.Text;

    DateTime expiryDate;
    if (!DateTime.TryParse(txtExpiryDate.Text, out expiryDate))
    {
        MessageBox.Show("Expiry Date must be a valid date.");
        return;
    }

    int registrationNo;
    if (!int.TryParse(txtRegistrationNo.Text, out registrationNo))
    {
        MessageBox.Show("Registration No must be a valid integer.");
        return;
    }

    int pMethodNo;
    if (!int.TryParse(txtPMethodNo.Text, out pMethodNo))
    {
        MessageBox.Show("Payment Method No must be a valid integer.");
        return;
    }

    InsertInvoice(invoiceNo, dateRaised, datePaid, creditCardNo, holdersName, expiryDate, registrationNo, pMethodNo);
}


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int invoiceNo = int.Parse(txtInvoiceNo.Text);
            DateTime dateRaised = DateTime.Parse(txtDateRaised.Text);
            DateTime datePaid = DateTime.Parse(txtDatePaid.Text);
            string creditCardNo = txtCreditCardNo.Text;
            string holdersName = txtHoldersName.Text;
            DateTime expiryDate = DateTime.Parse(txtExpiryDate.Text);
            int registrationNo = int.Parse(txtRegistrationNo.Text);
            int pMethodNo = int.Parse(txtPMethodNo.Text);

            UpdateInvoice(invoiceNo, dateRaised, datePaid, creditCardNo, holdersName, expiryDate, registrationNo, pMethodNo);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int invoiceNo = int.Parse(txtInvoiceNo.Text);
            DeleteInvoice(invoiceNo);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            RetrieveInvoices();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupDatabase();
        }

        private void InsertInvoice(int invoiceNo, DateTime dateRaised, DateTime datePaid, string creditCardNo, string holdersName, DateTime expiryDate, int registrationNo, int pMethodNo)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("insert_invoice", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_invoiceNo", OracleDbType.Int32).Value = invoiceNo;
                        cmd.Parameters.Add("p_dateRaised", OracleDbType.Date).Value = dateRaised;
                        cmd.Parameters.Add("p_datePaid", OracleDbType.Date).Value = datePaid;
                        cmd.Parameters.Add("p_creditCardNo", OracleDbType.Varchar2).Value = creditCardNo;
                        cmd.Parameters.Add("p_holdersName", OracleDbType.Varchar2).Value = holdersName;
                        cmd.Parameters.Add("p_expiryDate", OracleDbType.Date).Value = expiryDate;
                        cmd.Parameters.Add("p_registrationNo", OracleDbType.Int32).Value = registrationNo;
                        cmd.Parameters.Add("p_pMethodNo", OracleDbType.Int32).Value = pMethodNo;

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Invoice inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting invoice: " + ex.Message);
            }
        }

        private void UpdateInvoice(int invoiceNo, DateTime dateRaised, DateTime datePaid, string creditCardNo, string holdersName, DateTime expiryDate, int registrationNo, int pMethodNo)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("update_invoice", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_invoiceNo", OracleDbType.Int32).Value = invoiceNo;
                        cmd.Parameters.Add("p_dateRaised", OracleDbType.Date).Value = dateRaised;
                        cmd.Parameters.Add("p_datePaid", OracleDbType.Date).Value = datePaid;
                        cmd.Parameters.Add("p_creditCardNo", OracleDbType.Varchar2).Value = creditCardNo;
                        cmd.Parameters.Add("p_holdersName", OracleDbType.Varchar2).Value = holdersName;
                        cmd.Parameters.Add("p_expiryDate", OracleDbType.Date).Value = expiryDate;
                        cmd.Parameters.Add("p_registrationNo", OracleDbType.Int32).Value = registrationNo;
                        cmd.Parameters.Add("p_pMethodNo", OracleDbType.Int32).Value = pMethodNo;

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Invoice updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating invoice: " + ex.Message);
            }
        }

        private void DeleteInvoice(int invoiceNo)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("delete_invoice", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_invoiceNo", OracleDbType.Int32).Value = invoiceNo;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Invoice deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting invoice: " + ex.Message);
            }
        }

        private void RetrieveInvoices()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleDataAdapter adapter = new OracleDataAdapter("SELECT * FROM Invoice", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving invoices: " + ex.Message);
            }
        }

        private void BackupDatabase()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("backup_database", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Database backup initiated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error backing up database: " + ex.Message);
            }
        }

    }
}
