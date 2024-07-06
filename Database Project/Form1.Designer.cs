namespace Database_Project;
partial class Form1 : Form
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtInvoiceNo = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtDateRaised = new TextBox();
        label3 = new Label();
        txtDatePaid = new TextBox();
        label4 = new Label();
        txtCreditCardNo = new TextBox();
        label5 = new Label();
        txtHoldersName = new TextBox();
        label6 = new Label();
        txtExpiryDate = new TextBox();
        label7 = new Label();
        txtRegistrationNo = new TextBox();
        label8 = new Label();
        txtPMethodNo = new TextBox();
        btnInsert = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnRetrieve = new Button();
        btnBackup = new Button();
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // txtInvoiceNo
        // 
        txtInvoiceNo.Location = new Point(181, 33);
        txtInvoiceNo.Margin = new Padding(4, 3, 4, 3);
        txtInvoiceNo.Name = "txtInvoiceNo";
        txtInvoiceNo.Size = new Size(116, 23);
        txtInvoiceNo.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(36, 37);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(70, 15);
        label1.TabIndex = 1;
        label1.Text = "Invoice No :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(36, 84);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(68, 15);
        label2.TabIndex = 2;
        label2.Text = "Date Raised";
        // 
        // txtDateRaised
        // 
        txtDateRaised.Location = new Point(181, 84);
        txtDateRaised.Margin = new Padding(4, 3, 4, 3);
        txtDateRaised.Name = "txtDateRaised";
        txtDateRaised.Size = new Size(116, 23);
        txtDateRaised.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(36, 127);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 4;
        label3.Text = "Date Paid :";
        // 
        // txtDatePaid
        // 
        txtDatePaid.Location = new Point(181, 123);
        txtDatePaid.Margin = new Padding(4, 3, 4, 3);
        txtDatePaid.Name = "txtDatePaid";
        txtDatePaid.Size = new Size(116, 23);
        txtDatePaid.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(36, 173);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(83, 15);
        label4.TabIndex = 6;
        label4.Text = "Credit Card # :";
        // 
        // txtCreditCardNo
        // 
        txtCreditCardNo.Location = new Point(181, 170);
        txtCreditCardNo.Margin = new Padding(4, 3, 4, 3);
        txtCreditCardNo.Name = "txtCreditCardNo";
        txtCreditCardNo.Size = new Size(116, 23);
        txtCreditCardNo.TabIndex = 7;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(36, 219);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(86, 15);
        label5.TabIndex = 8;
        label5.Text = "Holders Name:";
        // 
        // txtHoldersName
        // 
        txtHoldersName.Location = new Point(181, 216);
        txtHoldersName.Margin = new Padding(4, 3, 4, 3);
        txtHoldersName.Name = "txtHoldersName";
        txtHoldersName.Size = new Size(116, 23);
        txtHoldersName.TabIndex = 9;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(36, 264);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(72, 15);
        label6.TabIndex = 10;
        label6.Text = "Expiry Date :";
        // 
        // txtExpiryDate
        // 
        txtExpiryDate.Location = new Point(181, 261);
        txtExpiryDate.Margin = new Padding(4, 3, 4, 3);
        txtExpiryDate.Name = "txtExpiryDate";
        txtExpiryDate.Size = new Size(116, 23);
        txtExpiryDate.TabIndex = 11;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(36, 310);
        label7.Margin = new Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(92, 15);
        label7.TabIndex = 12;
        label7.Text = "Registration No:";
        // 
        // txtRegistrationNo
        // 
        txtRegistrationNo.Location = new Point(181, 307);
        txtRegistrationNo.Margin = new Padding(4, 3, 4, 3);
        txtRegistrationNo.Name = "txtRegistrationNo";
        txtRegistrationNo.Size = new Size(116, 23);
        txtRegistrationNo.TabIndex = 13;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(36, 353);
        label8.Margin = new Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new Size(87, 15);
        label8.TabIndex = 14;
        label8.Text = "Pay Method # :";
        // 
        // txtPMethodNo
        // 
        txtPMethodNo.Location = new Point(181, 350);
        txtPMethodNo.Margin = new Padding(4, 3, 4, 3);
        txtPMethodNo.Name = "txtPMethodNo";
        txtPMethodNo.Size = new Size(116, 23);
        txtPMethodNo.TabIndex = 15;
        // 
        // btnInsert
        // 
        btnInsert.Location = new Point(40, 396);
        btnInsert.Margin = new Padding(4, 3, 4, 3);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(88, 27);
        btnInsert.TabIndex = 16;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        btnInsert.Click += btnInsert_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(149, 396);
        btnUpdate.Margin = new Padding(4, 3, 4, 3);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(88, 27);
        btnUpdate.TabIndex = 17;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(258, 396);
        btnDelete.Margin = new Padding(4, 3, 4, 3);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(88, 27);
        btnDelete.TabIndex = 18;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnRetrieve
        // 
        btnRetrieve.Location = new Point(40, 448);
        btnRetrieve.Margin = new Padding(4, 3, 4, 3);
        btnRetrieve.Name = "btnRetrieve";
        btnRetrieve.Size = new Size(88, 27);
        btnRetrieve.TabIndex = 19;
        btnRetrieve.Text = "Retrieve";
        btnRetrieve.UseVisualStyleBackColor = true;
        btnRetrieve.Click += btnRetrieve_Click;
        // 
        // btnBackup
        // 
        btnBackup.Location = new Point(149, 448);
        btnBackup.Margin = new Padding(4, 3, 4, 3);
        btnBackup.Name = "btnBackup";
        btnBackup.Size = new Size(88, 27);
        btnBackup.TabIndex = 20;
        btnBackup.Text = "Backup";
        btnBackup.UseVisualStyleBackColor = true;
        btnBackup.Click += btnBackup_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(368, 33);
        dataGridView1.Margin = new Padding(4, 3, 4, 3);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(527, 441);
        dataGridView1.TabIndex = 21;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(922, 507);
        Controls.Add(dataGridView1);
        Controls.Add(btnBackup);
        Controls.Add(btnRetrieve);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(txtPMethodNo);
        Controls.Add(label8);
        Controls.Add(txtRegistrationNo);
        Controls.Add(label7);
        Controls.Add(txtExpiryDate);
        Controls.Add(label6);
        Controls.Add(txtHoldersName);
        Controls.Add(label5);
        Controls.Add(txtCreditCardNo);
        Controls.Add(label4);
        Controls.Add(txtDatePaid);
        Controls.Add(label3);
        Controls.Add(txtDateRaised);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtInvoiceNo);
        Margin = new Padding(4, 3, 4, 3);
        Name = "Form1";
        Text = "Management System";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }


    private TextBox txtInvoiceNo;
    private Label label1;
    private Label label2;
    private TextBox txtDateRaised;
    private Label label3;
    private TextBox txtDatePaid;
    private Label label4;
    private TextBox txtCreditCardNo;
    private Label label5;
    private TextBox txtHoldersName;
    private Label label6;
    private TextBox txtExpiryDate;
    private Label label7;
    private TextBox txtRegistrationNo;
    private Label label8;
    private TextBox txtPMethodNo;
    private Button btnInsert;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnRetrieve;
    private Button btnBackup;
    private DataGridView dataGridView1;
}
