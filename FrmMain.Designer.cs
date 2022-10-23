namespace SQLiteTESTwithDapper
{
    partial class FrmMain
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
            this.lblAddPerson = new System.Windows.Forms.Label();
            this.lblListPeople = new System.Windows.Forms.Label();
            this.lbxPeopleListBox = new System.Windows.Forms.ListBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddPerson
            // 
            this.lblAddPerson.AutoSize = true;
            this.lblAddPerson.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddPerson.Location = new System.Drawing.Point(36, 29);
            this.lblAddPerson.Name = "lblAddPerson";
            this.lblAddPerson.Size = new System.Drawing.Size(159, 38);
            this.lblAddPerson.TabIndex = 0;
            this.lblAddPerson.Text = "Add Person";
            // 
            // lblListPeople
            // 
            this.lblListPeople.AutoSize = true;
            this.lblListPeople.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblListPeople.Location = new System.Drawing.Point(374, 29);
            this.lblListPeople.Name = "lblListPeople";
            this.lblListPeople.Size = new System.Drawing.Size(142, 38);
            this.lblListPeople.TabIndex = 1;
            this.lblListPeople.Text = "ListPeople";
            // 
            // lbxPeopleListBox
            // 
            this.lbxPeopleListBox.FormattingEnabled = true;
            this.lbxPeopleListBox.ItemHeight = 25;
            this.lbxPeopleListBox.Location = new System.Drawing.Point(374, 84);
            this.lbxPeopleListBox.Name = "lbxPeopleListBox";
            this.lbxPeopleListBox.Size = new System.Drawing.Size(399, 404);
            this.lbxPeopleListBox.TabIndex = 2;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(36, 117);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(243, 31);
            this.txbFirstName.TabIndex = 3;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(36, 205);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(243, 31);
            this.txbLastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(41, 87);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 25);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(41, 177);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 25);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(36, 308);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(240, 57);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(36, 395);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(240, 57);
            this.btnRefreshList.TabIndex = 8;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 507);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.lbxPeopleListBox);
            this.Controls.Add(this.lblListPeople);
            this.Controls.Add(this.lblAddPerson);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAddPerson;
        private Label lblListPeople;
        private ListBox lbxPeopleListBox;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private Label lblFirstName;
        private Label lblLastName;
        private Button btnAddPerson;
        private Button btnRefreshList;
    }
}