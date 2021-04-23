
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.teamNamelabel = new System.Windows.Forms.Label();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.AddMemberbutton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
            this.CreateMemeberbutton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.LastNamelabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberbutton = new System.Windows.Forms.Button();
            this.CreateTeambutton = new System.Windows.Forms.Button();
            this.AddNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(22, 144);
            this.TeamNameValue.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(306, 35);
            this.TeamNameValue.TabIndex = 13;
            // 
            // teamNamelabel
            // 
            this.teamNamelabel.AutoSize = true;
            this.teamNamelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamNamelabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamNamelabel.Location = new System.Drawing.Point(15, 82);
            this.teamNamelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamNamelabel.Name = "teamNamelabel";
            this.teamNamelabel.Size = new System.Drawing.Size(157, 37);
            this.teamNamelabel.TabIndex = 12;
            this.teamNamelabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreateTeamLabel.Location = new System.Drawing.Point(15, 21);
            this.CreateTeamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.CreateTeamLabel.TabIndex = 11;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // AddMemberbutton
            // 
            this.AddMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.AddMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMemberbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddMemberbutton.Location = new System.Drawing.Point(85, 301);
            this.AddMemberbutton.Name = "AddMemberbutton";
            this.AddMemberbutton.Size = new System.Drawing.Size(194, 46);
            this.AddMemberbutton.TabIndex = 19;
            this.AddMemberbutton.Text = "Add Member";
            this.AddMemberbutton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(23, 246);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(306, 38);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(16, 206);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamMemberLabel.TabIndex = 17;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // AddNewMemberBox
            // 
            this.AddNewMemberBox.Controls.Add(this.CreateMemeberbutton);
            this.AddNewMemberBox.Controls.Add(this.cellphoneValue);
            this.AddNewMemberBox.Controls.Add(this.CellphoneLabel);
            this.AddNewMemberBox.Controls.Add(this.emailValue);
            this.AddNewMemberBox.Controls.Add(this.Emaillabel);
            this.AddNewMemberBox.Controls.Add(this.lastNameValue);
            this.AddNewMemberBox.Controls.Add(this.LastNamelabel);
            this.AddNewMemberBox.Controls.Add(this.firstNameValue);
            this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewMemberBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddNewMemberBox.Location = new System.Drawing.Point(22, 373);
            this.AddNewMemberBox.Name = "AddNewMemberBox";
            this.AddNewMemberBox.Size = new System.Drawing.Size(382, 343);
            this.AddNewMemberBox.TabIndex = 20;
            this.AddNewMemberBox.TabStop = false;
            this.AddNewMemberBox.Text = "Add New Member";
            // 
            // CreateMemeberbutton
            // 
            this.CreateMemeberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemeberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.CreateMemeberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateMemeberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemeberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMemeberbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreateMemeberbutton.Location = new System.Drawing.Point(101, 281);
            this.CreateMemeberbutton.Name = "CreateMemeberbutton";
            this.CreateMemeberbutton.Size = new System.Drawing.Size(175, 39);
            this.CreateMemeberbutton.TabIndex = 21;
            this.CreateMemeberbutton.Text = "Create Member";
            this.CreateMemeberbutton.UseVisualStyleBackColor = true;
            this.CreateMemeberbutton.Click += new System.EventHandler(this.CreateMemeberbutton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(156, 214);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(203, 43);
            this.cellphoneValue.TabIndex = 16;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CellphoneLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CellphoneLabel.Location = new System.Drawing.Point(6, 211);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(138, 37);
            this.CellphoneLabel.TabIndex = 15;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(156, 159);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(203, 43);
            this.emailValue.TabIndex = 14;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Emaillabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Emaillabel.Location = new System.Drawing.Point(6, 156);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(82, 37);
            this.Emaillabel.TabIndex = 13;
            this.Emaillabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(156, 107);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(203, 43);
            this.lastNameValue.TabIndex = 12;
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.AutoSize = true;
            this.LastNamelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNamelabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LastNamelabel.Location = new System.Drawing.Point(6, 104);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(142, 37);
            this.LastNamelabel.TabIndex = 11;
            this.LastNamelabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(156, 52);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(203, 43);
            this.firstNameValue.TabIndex = 10;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 49);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(434, 144);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(302, 572);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // DeleteSelectedMemberbutton
            // 
            this.DeleteSelectedMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.DeleteSelectedMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSelectedMemberbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSelectedMemberbutton.Location = new System.Drawing.Point(742, 373);
            this.DeleteSelectedMemberbutton.Name = "DeleteSelectedMemberbutton";
            this.DeleteSelectedMemberbutton.Size = new System.Drawing.Size(148, 74);
            this.DeleteSelectedMemberbutton.TabIndex = 22;
            this.DeleteSelectedMemberbutton.Text = "Delete Selected";
            this.DeleteSelectedMemberbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTeambutton
            // 
            this.CreateTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.CreateTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTeambutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreateTeambutton.Location = new System.Drawing.Point(306, 736);
            this.CreateTeambutton.Name = "CreateTeambutton";
            this.CreateTeambutton.Size = new System.Drawing.Size(302, 74);
            this.CreateTeambutton.TabIndex = 23;
            this.CreateTeambutton.Text = "CreateTeam";
            this.CreateTeambutton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 827);
            this.Controls.Add(this.CreateTeambutton);
            this.Controls.Add(this.DeleteSelectedMemberbutton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.AddNewMemberBox);
            this.Controls.Add(this.AddMemberbutton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.teamNamelabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberBox.ResumeLayout(false);
            this.AddNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label teamNamelabel;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Button AddMemberbutton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberBox;
        private System.Windows.Forms.Button CreateMemeberbutton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label LastNamelabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberbutton;
        private System.Windows.Forms.Button CreateTeambutton;
    }
}