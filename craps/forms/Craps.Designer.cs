namespace craps
{
    partial class Craps
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Dice = new System.Windows.Forms.GroupBox();
            this.diceOneTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diceTwoTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.rollBtn = new System.Windows.Forms.Button();
            this.userselectGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.historyGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentGameGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.winRateTxt = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pointTxt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteHistoryBtn = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.Dice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userselectGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGameGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(692, 303);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Dice
            // 
            this.Dice.Controls.Add(this.diceOneTxt);
            this.Dice.Location = new System.Drawing.Point(16, 42);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(133, 123);
            this.Dice.TabIndex = 3;
            this.Dice.TabStop = false;
            this.Dice.Text = "Dice 1";
            // 
            // diceOneTxt
            // 
            this.diceOneTxt.AutoSize = true;
            this.diceOneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceOneTxt.Location = new System.Drawing.Point(34, 20);
            this.diceOneTxt.Name = "diceOneTxt";
            this.diceOneTxt.Size = new System.Drawing.Size(69, 73);
            this.diceOneTxt.TabIndex = 10;
            this.diceOneTxt.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.diceTwoTxt);
            this.groupBox1.Location = new System.Drawing.Point(167, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice 2";
            // 
            // diceTwoTxt
            // 
            this.diceTwoTxt.AutoSize = true;
            this.diceTwoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceTwoTxt.Location = new System.Drawing.Point(28, 16);
            this.diceTwoTxt.Name = "diceTwoTxt";
            this.diceTwoTxt.Size = new System.Drawing.Size(69, 73);
            this.diceTwoTxt.TabIndex = 11;
            this.diceTwoTxt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CurrentGame:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "You are logged in as: ";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(115, 6);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(53, 13);
            this.usernameLbl.TabIndex = 8;
            this.usernameLbl.Text = "username";
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(225, 174);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(75, 23);
            this.rollBtn.TabIndex = 9;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // userselectGrid
            // 
            this.userselectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userselectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userselectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.userselectGrid.EnableHeadersVisualStyles = false;
            this.userselectGrid.Location = new System.Drawing.Point(506, 26);
            this.userselectGrid.Name = "userselectGrid";
            this.userselectGrid.RowHeadersVisible = false;
            this.userselectGrid.Size = new System.Drawing.Size(172, 412);
            this.userselectGrid.TabIndex = 10;
            this.toolTip1.SetToolTip(this.userselectGrid, "Select UserName to View Their stats");
            this.userselectGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userselectGrid_CellContentClick);
            this.userselectGrid.SelectionChanged += new System.EventHandler(this.userselectGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "UserName";
            this.Column1.Name = "Column1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "OtherUsers";
            // 
            // historyGrid
            // 
            this.historyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.historyGrid.EnableHeadersVisualStyles = false;
            this.historyGrid.Location = new System.Drawing.Point(319, 26);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.RowHeadersVisible = false;
            this.historyGrid.Size = new System.Drawing.Size(172, 386);
            this.historyGrid.TabIndex = 12;
            this.toolTip1.SetToolTip(this.historyGrid, "Select UserName to View Their stats");
            this.historyGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Game#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 139.0863F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Win";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // currentGameGrid
            // 
            this.currentGameGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currentGameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentGameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.currentGameGrid.EnableHeadersVisualStyles = false;
            this.currentGameGrid.Location = new System.Drawing.Point(15, 219);
            this.currentGameGrid.Name = "currentGameGrid";
            this.currentGameGrid.RowHeadersVisible = false;
            this.currentGameGrid.Size = new System.Drawing.Size(286, 218);
            this.currentGameGrid.TabIndex = 18;
            this.toolTip1.SetToolTip(this.currentGameGrid, "Select UserName to View Their stats");
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "RollNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DIceOne";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DiceTwo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Points";
            this.Column5.Name = "Column5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "WinRate:";
            this.label3.Visible = false;
            // 
            // winRateTxt
            // 
            this.winRateTxt.AutoSize = true;
            this.winRateTxt.Location = new System.Drawing.Point(392, 9);
            this.winRateTxt.Name = "winRateTxt";
            this.winRateTxt.Size = new System.Drawing.Size(21, 13);
            this.winRateTxt.TabIndex = 14;
            this.winRateTxt.Text = "0%";
            this.winRateTxt.Visible = false;
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(144, 174);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 15;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Points:";
            // 
            // pointTxt
            // 
            this.pointTxt.AutoSize = true;
            this.pointTxt.Location = new System.Drawing.Point(257, 203);
            this.pointTxt.Name = "pointTxt";
            this.pointTxt.Size = new System.Drawing.Size(13, 13);
            this.pointTxt.TabIndex = 17;
            this.pointTxt.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // deleteHistoryBtn
            // 
            this.deleteHistoryBtn.Location = new System.Drawing.Point(395, 418);
            this.deleteHistoryBtn.Name = "deleteHistoryBtn";
            this.deleteHistoryBtn.Size = new System.Drawing.Size(96, 23);
            this.deleteHistoryBtn.TabIndex = 21;
            this.deleteHistoryBtn.Text = "Clear History";
            this.deleteHistoryBtn.UseVisualStyleBackColor = true;
            this.deleteHistoryBtn.Click += new System.EventHandler(this.deleteHistoryBtn_Click);
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 449);
            this.Controls.Add(this.deleteHistoryBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.currentGameGrid);
            this.Controls.Add(this.pointTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.winRateTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.historyGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userselectGrid);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.tabControl2);
            this.Name = "Craps";
            this.Text = "Craps";
            this.tabControl2.ResumeLayout(false);
            this.Dice.ResumeLayout(false);
            this.Dice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userselectGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentGameGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox Dice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Label diceOneTxt;
        private System.Windows.Forms.Label diceTwoTxt;
        private System.Windows.Forms.DataGridView userselectGrid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView historyGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label winRateTxt;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pointTxt;
        private System.Windows.Forms.DataGridView currentGameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteHistoryBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

