
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.teamOneScoreLabellabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.EntryFeelabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeambutton = new System.Windows.Forms.Button();
            this.CreatePrizebutton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.TeamPlayerslabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayersbutton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizebutton = new System.Windows.Forms.Button();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.PrizeslistBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 31);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(315, 50);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(21, 150);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(306, 35);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // teamOneScoreLabellabel
            // 
            this.teamOneScoreLabellabel.AutoSize = true;
            this.teamOneScoreLabellabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teamOneScoreLabellabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneScoreLabellabel.Location = new System.Drawing.Point(14, 110);
            this.teamOneScoreLabellabel.Name = "teamOneScoreLabellabel";
            this.teamOneScoreLabellabel.Size = new System.Drawing.Size(236, 37);
            this.teamOneScoreLabellabel.TabIndex = 9;
            this.teamOneScoreLabellabel.Text = "Tournament Name";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(150, 221);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.teamOneScoreValue.TabIndex = 12;
            this.teamOneScoreValue.Text = "0";
            // 
            // EntryFeelabel
            // 
            this.EntryFeelabel.AutoSize = true;
            this.EntryFeelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntryFeelabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EntryFeelabel.Location = new System.Drawing.Point(14, 218);
            this.EntryFeelabel.Name = "EntryFeelabel";
            this.EntryFeelabel.Size = new System.Drawing.Size(125, 37);
            this.EntryFeelabel.TabIndex = 11;
            this.EntryFeelabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(21, 318);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(306, 38);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectTeamLabel.Location = new System.Drawing.Point(14, 278);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(222, 284);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // AddTeambutton
            // 
            this.AddTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.AddTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeambutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeambutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddTeambutton.Location = new System.Drawing.Point(102, 362);
            this.AddTeambutton.Name = "AddTeambutton";
            this.AddTeambutton.Size = new System.Drawing.Size(148, 46);
            this.AddTeambutton.TabIndex = 16;
            this.AddTeambutton.Text = "Add Team";
            this.AddTeambutton.UseVisualStyleBackColor = true;
            this.AddTeambutton.Click += new System.EventHandler(this.AddTeambutton_Click);
            // 
            // CreatePrizebutton
            // 
            this.CreatePrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.CreatePrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePrizebutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreatePrizebutton.Location = new System.Drawing.Point(102, 427);
            this.CreatePrizebutton.Name = "CreatePrizebutton";
            this.CreatePrizebutton.Size = new System.Drawing.Size(148, 46);
            this.CreatePrizebutton.TabIndex = 17;
            this.CreatePrizebutton.Text = "Create Prize";
            this.CreatePrizebutton.UseVisualStyleBackColor = true;
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 30;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(382, 150);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(302, 152);
            this.tournamentTeamsListBox.TabIndex = 18;
            // 
            // TeamPlayerslabel
            // 
            this.TeamPlayerslabel.AutoSize = true;
            this.TeamPlayerslabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamPlayerslabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TeamPlayerslabel.Location = new System.Drawing.Point(375, 110);
            this.TeamPlayerslabel.Name = "TeamPlayerslabel";
            this.TeamPlayerslabel.Size = new System.Drawing.Size(187, 37);
            this.TeamPlayerslabel.TabIndex = 19;
            this.TeamPlayerslabel.Text = "Team / Players";
            // 
            // DeleteSelectedPlayersbutton
            // 
            this.DeleteSelectedPlayersbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayersbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.DeleteSelectedPlayersbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedPlayersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayersbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSelectedPlayersbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSelectedPlayersbutton.Location = new System.Drawing.Point(690, 193);
            this.DeleteSelectedPlayersbutton.Name = "DeleteSelectedPlayersbutton";
            this.DeleteSelectedPlayersbutton.Size = new System.Drawing.Size(148, 74);
            this.DeleteSelectedPlayersbutton.TabIndex = 20;
            this.DeleteSelectedPlayersbutton.Text = "Delete Selected";
            this.DeleteSelectedPlayersbutton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizebutton
            // 
            this.DeleteSelectedPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.DeleteSelectedPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSelectedPrizebutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DeleteSelectedPrizebutton.Location = new System.Drawing.Point(690, 398);
            this.DeleteSelectedPrizebutton.Name = "DeleteSelectedPrizebutton";
            this.DeleteSelectedPrizebutton.Size = new System.Drawing.Size(148, 75);
            this.DeleteSelectedPrizebutton.TabIndex = 23;
            this.DeleteSelectedPrizebutton.Text = "Delete Selected";
            this.DeleteSelectedPrizebutton.UseVisualStyleBackColor = true;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prizeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.prizeLabel.Location = new System.Drawing.Point(375, 322);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(85, 37);
            this.prizeLabel.TabIndex = 22;
            this.prizeLabel.Text = "Prizes";
            // 
            // PrizeslistBox
            // 
            this.PrizeslistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeslistBox.FormattingEnabled = true;
            this.PrizeslistBox.ItemHeight = 30;
            this.PrizeslistBox.Location = new System.Drawing.Point(382, 362);
            this.PrizeslistBox.Name = "PrizeslistBox";
            this.PrizeslistBox.Size = new System.Drawing.Size(302, 152);
            this.PrizeslistBox.TabIndex = 21;
            // 
            // CreateTournamentbutton
            // 
            this.CreateTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.CreateTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateTournamentbutton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CreateTournamentbutton.Location = new System.Drawing.Point(298, 549);
            this.CreateTournamentbutton.Name = "CreateTournamentbutton";
            this.CreateTournamentbutton.Size = new System.Drawing.Size(233, 57);
            this.CreateTournamentbutton.TabIndex = 24;
            this.CreateTournamentbutton.Text = "Create Tournament";
            this.CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 618);
            this.Controls.Add(this.CreateTournamentbutton);
            this.Controls.Add(this.DeleteSelectedPrizebutton);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.PrizeslistBox);
            this.Controls.Add(this.DeleteSelectedPlayersbutton);
            this.Controls.Add(this.TeamPlayerslabel);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.CreatePrizebutton);
            this.Controls.Add(this.AddTeambutton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.EntryFeelabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.teamOneScoreLabellabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label teamOneScoreLabellabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.Label EntryFeelabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button AddTeambutton;
        private System.Windows.Forms.Button CreatePrizebutton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.Label TeamPlayerslabel;
        private System.Windows.Forms.Button DeleteSelectedPlayersbutton;
        private System.Windows.Forms.Button DeleteSelectedPrizebutton;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.ListBox PrizeslistBox;
        private System.Windows.Forms.Button CreateTournamentbutton;
    }
}