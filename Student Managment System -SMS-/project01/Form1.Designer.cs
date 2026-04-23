namespace project01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox Search;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            StudentID = new TextBox();
            StudentName = new TextBox();
            Search = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnShowAll = new Button();
            lblID = new Label();
            lblName = new Label();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LavenderBlush;
            dataGridView1.Location = new Point(150, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(420, 250);
            dataGridView1.TabIndex = 10;
            // 
            // StudentID
            // 
            StudentID.Location = new Point(150, 40);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(120, 23);
            StudentID.TabIndex = 3;
            // 
            // StudentName
            // 
            StudentName.Location = new Point(280, 40);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(150, 23);
            StudentName.TabIndex = 4;
            // 
            // Search
            // 
            Search.Location = new Point(450, 40);
            Search.Name = "Search";
            Search.Size = new Size(120, 23);
            Search.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleTurquoise;
            btnAdd.Location = new Point(150, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(260, 90);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(370, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.LightGray;
            btnShowAll.Location = new Point(480, 90);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(150, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(65, 15);
            lblID.TabIndex = 0;
            lblID.Text = "Student ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(280, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(86, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Student Name:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(450, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search:";
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblSearch);
            Controls.Add(StudentID);
            Controls.Add(StudentName);
            Controls.Add(Search);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnShowAll);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Student System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}