
namespace WindowsFormsApp1
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTBPassword = new System.Windows.Forms.MaskedTextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.cBNewUser = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.openDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.closingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shifrdeshifrDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet1 = new WindowsFormsApp1.usersDataSet1();
            this.userTableAdapter = new WindowsFormsApp1.usersDataSet1TableAdapters.userTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLogin
            // 
            this.tBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBLogin.Location = new System.Drawing.Point(12, 38);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(353, 29);
            this.tBLogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // mTBPassword
            // 
            this.mTBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mTBPassword.Location = new System.Drawing.Point(12, 106);
            this.mTBPassword.Name = "mTBPassword";
            this.mTBPassword.PasswordChar = '*';
            this.mTBPassword.Size = new System.Drawing.Size(353, 29);
            this.mTBPassword.TabIndex = 4;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLogin.Location = new System.Drawing.Point(12, 238);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(170, 36);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Войти";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // bRegister
            // 
            this.bRegister.BackColor = System.Drawing.Color.PowderBlue;
            this.bRegister.Enabled = false;
            this.bRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRegister.Location = new System.Drawing.Point(195, 238);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(170, 36);
            this.bRegister.TabIndex = 6;
            this.bRegister.Text = "Регистрация";
            this.bRegister.UseVisualStyleBackColor = false;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // cBNewUser
            // 
            this.cBNewUser.AutoSize = true;
            this.cBNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBNewUser.Location = new System.Drawing.Point(12, 150);
            this.cBNewUser.Name = "cBNewUser";
            this.cBNewUser.Size = new System.Drawing.Size(191, 24);
            this.cBNewUser.TabIndex = 7;
            this.cBNewUser.Text = "Новый пользователь";
            this.cBNewUser.UseVisualStyleBackColor = true;
            this.cBNewUser.CheckedChanged += new System.EventHandler(this.cBNewUser_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.blockDataGridViewCheckBoxColumn,
            this.openDataGridViewCheckBoxColumn,
            this.closingDataGridViewCheckBoxColumn,
            this.shifrdeshifrDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // blockDataGridViewCheckBoxColumn
            // 
            this.blockDataGridViewCheckBoxColumn.DataPropertyName = "block";
            this.blockDataGridViewCheckBoxColumn.HeaderText = "block";
            this.blockDataGridViewCheckBoxColumn.Name = "blockDataGridViewCheckBoxColumn";
            // 
            // openDataGridViewCheckBoxColumn
            // 
            this.openDataGridViewCheckBoxColumn.DataPropertyName = "open";
            this.openDataGridViewCheckBoxColumn.HeaderText = "open";
            this.openDataGridViewCheckBoxColumn.Name = "openDataGridViewCheckBoxColumn";
            // 
            // closingDataGridViewCheckBoxColumn
            // 
            this.closingDataGridViewCheckBoxColumn.DataPropertyName = "closing";
            this.closingDataGridViewCheckBoxColumn.HeaderText = "closing";
            this.closingDataGridViewCheckBoxColumn.Name = "closingDataGridViewCheckBoxColumn";
            // 
            // shifrdeshifrDataGridViewCheckBoxColumn
            // 
            this.shifrdeshifrDataGridViewCheckBoxColumn.DataPropertyName = "shifr_deshifr";
            this.shifrdeshifrDataGridViewCheckBoxColumn.HeaderText = "shifr_deshifr";
            this.shifrdeshifrDataGridViewCheckBoxColumn.Name = "shifrdeshifrDataGridViewCheckBoxColumn";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.usersDataSet1;
            // 
            // usersDataSet1
            // 
            this.usersDataSet1.DataSetName = "usersDataSet1";
            this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Полное имя";
            this.label4.Visible = false;
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBName.Location = new System.Drawing.Point(12, 203);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(353, 29);
            this.tBName.TabIndex = 11;
            this.tBName.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 289);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBNewUser);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.mTBPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mTBPassword;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.CheckBox cBNewUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private usersDataSet1 usersDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private usersDataSet1TableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn blockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn openDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn closingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn shifrdeshifrDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBName;
    }
}