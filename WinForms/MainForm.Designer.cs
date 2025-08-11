namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtWebsite = new TextBox();
            btnEdit = new Button();
            btnRemove = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contactDataGrid = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)contactDataGrid).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(41, 41, 41);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(647, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.FromArgb(41, 41, 41);
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.ForeColor = SystemColors.ButtonFace;
            btnUndo.Location = new Point(647, 45);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(131, 50);
            btnUndo.TabIndex = 1;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.BackColor = Color.FromArgb(41, 41, 41);
            btnRedo.FlatStyle = FlatStyle.Flat;
            btnRedo.ForeColor = SystemColors.ButtonFace;
            btnRedo.Location = new Point(784, 45);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(131, 50);
            btnRedo.TabIndex = 2;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = false;
            btnRedo.Click += btnRedo_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.ForeColor = SystemColors.InactiveBorder;
            txtName.Location = new Point(181, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(419, 35);
            txtName.TabIndex = 4;
            txtName.Text = "Name";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(64, 64, 64);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.ForeColor = SystemColors.InactiveBorder;
            txtAddress.Location = new Point(181, 84);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(419, 35);
            txtAddress.TabIndex = 5;
            txtAddress.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = SystemColors.InactiveBorder;
            txtEmail.Location = new Point(181, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(419, 35);
            txtEmail.TabIndex = 6;
            txtEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(64, 64, 64);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = SystemColors.InactiveBorder;
            txtPhone.Location = new Point(181, 166);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(419, 35);
            txtPhone.TabIndex = 7;
            txtPhone.Text = "Phone";
            // 
            // txtWebsite
            // 
            txtWebsite.BackColor = Color.FromArgb(64, 64, 64);
            txtWebsite.BorderStyle = BorderStyle.FixedSingle;
            txtWebsite.ForeColor = SystemColors.InactiveBorder;
            txtWebsite.Location = new Point(181, 207);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(419, 35);
            txtWebsite.TabIndex = 8;
            txtWebsite.Text = "Website";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(41, 41, 41);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(784, 132);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 50);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(41, 41, 41);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.ForeColor = SystemColors.ButtonFace;
            btnRemove.Location = new Point(921, 132);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 50);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(44, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(44, 86);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 12;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(44, 127);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 13;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(44, 168);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 14;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveBorder;
            label5.Location = new Point(44, 209);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 15;
            label5.Text = "Website";
            // 
            // contactDataGrid
            // 
            contactDataGrid.AllowUserToResizeRows = false;
            contactDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            contactDataGrid.BackgroundColor = Color.FromArgb(64, 64, 64);
            contactDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            contactDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            contactDataGrid.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            contactDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            contactDataGrid.EnableHeadersVisualStyles = false;
            contactDataGrid.GridColor = Color.Black;
            contactDataGrid.Location = new Point(44, 300);
            contactDataGrid.Name = "contactDataGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            contactDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            contactDataGrid.RowHeadersVisible = false;
            contactDataGrid.RowHeadersWidth = 72;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            contactDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            contactDataGrid.Size = new Size(1435, 532);
            contactDataGrid.TabIndex = 16;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 41, 43);
            ClientSize = new Size(1508, 894);
            Controls.Add(contactDataGrid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(txtWebsite);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnAdd);
            Name = "MainForm";
            Text = "Contact List";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)contactDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUndo;
        private Button btnRedo;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtWebsite;
        private Button btnEdit;
        private Button btnRemove;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView contactDataGrid;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
