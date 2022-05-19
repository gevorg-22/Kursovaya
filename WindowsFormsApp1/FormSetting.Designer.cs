
namespace WindowsFormsApp1
{
    partial class FormSetting
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
            this.pAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bPassword = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pUser = new System.Windows.Forms.Panel();
            this.bEditName = new System.Windows.Forms.Button();
            this.bUserSave = new System.Windows.Forms.Button();
            this.bUserPassword = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new WindowsFormsApp1.usersDataSet();
            this.userTableAdapter = new WindowsFormsApp1.usersDataSetTableAdapters.userTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pAdmin
            // 
            this.pAdmin.Controls.Add(this.label2);
            this.pAdmin.Controls.Add(this.label1);
            this.pAdmin.Controls.Add(this.bAdd);
            this.pAdmin.Controls.Add(this.bEdit);
            this.pAdmin.Controls.Add(this.bPassword);
            this.pAdmin.Controls.Add(this.bDelete);
            this.pAdmin.Controls.Add(this.bSave);
            this.pAdmin.Controls.Add(this.dataGridView1);
            this.pAdmin.Location = new System.Drawing.Point(12, 12);
            this.pAdmin.Name = "pAdmin";
            this.pAdmin.Size = new System.Drawing.Size(1047, 437);
            this.pAdmin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(785, 361);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(259, 31);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Добавить пользователя";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // bEdit
            // 
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEdit.Location = new System.Drawing.Point(506, 361);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(273, 31);
            this.bEdit.TabIndex = 4;
            this.bEdit.Text = "Редактировать данные";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bPassword
            // 
            this.bPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPassword.Location = new System.Drawing.Point(307, 361);
            this.bPassword.Name = "bPassword";
            this.bPassword.Size = new System.Drawing.Size(193, 31);
            this.bPassword.TabIndex = 3;
            this.bPassword.Text = "Сбросить пароль";
            this.bPassword.UseVisualStyleBackColor = true;
            this.bPassword.Click += new System.EventHandler(this.bPassword_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(151, 361);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(150, 31);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(3, 361);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(142, 31);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Обновить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pUser
            // 
            this.pUser.Controls.Add(this.bEditName);
            this.pUser.Controls.Add(this.bUserSave);
            this.pUser.Controls.Add(this.bUserPassword);
            this.pUser.Location = new System.Drawing.Point(12, 12);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(278, 228);
            this.pUser.TabIndex = 1;
            this.pUser.Visible = false;
            // 
            // bEditName
            // 
            this.bEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bEditName.Location = new System.Drawing.Point(31, 82);
            this.bEditName.Name = "bEditName";
            this.bEditName.Size = new System.Drawing.Size(214, 31);
            this.bEditName.TabIndex = 4;
            this.bEditName.Text = "Сменить имя";
            this.bEditName.UseVisualStyleBackColor = true;
            // 
            // bUserSave
            // 
            this.bUserSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUserSave.Location = new System.Drawing.Point(65, 140);
            this.bUserSave.Name = "bUserSave";
            this.bUserSave.Size = new System.Drawing.Size(142, 31);
            this.bUserSave.TabIndex = 3;
            this.bUserSave.Text = "Сохранить";
            this.bUserSave.UseVisualStyleBackColor = true;
            // 
            // bUserPassword
            // 
            this.bUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUserPassword.Location = new System.Drawing.Point(31, 19);
            this.bUserPassword.Name = "bUserPassword";
            this.bUserPassword.Size = new System.Drawing.Size(214, 31);
            this.bUserPassword.TabIndex = 2;
            this.bUserPassword.Text = "Сбросить пароль";
            this.bUserPassword.UseVisualStyleBackColor = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "usersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 461);
            this.Controls.Add(this.pUser);
            this.Controls.Add(this.pAdmin);
            this.Name = "FormSetting";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.pAdmin.ResumeLayout(false);
            this.pAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pAdmin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bPassword;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel pUser;
        private System.Windows.Forms.Button bEditName;
        private System.Windows.Forms.Button bUserSave;
        private System.Windows.Forms.Button bUserPassword;
        private usersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private usersDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}