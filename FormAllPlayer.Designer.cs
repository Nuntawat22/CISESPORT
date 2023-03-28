namespace CISESPORT
{
    partial class FormAllPlayer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDisplayname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMailuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1234, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.existToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.existToolStripMenuItem.Text = "Close";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem1});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // newPlayerToolStripMenuItem1
            // 
            this.newPlayerToolStripMenuItem1.Name = "newPlayerToolStripMenuItem1";
            this.newPlayerToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.newPlayerToolStripMenuItem1.Text = "New Player";
            this.newPlayerToolStripMenuItem1.Click += new System.EventHandler(this.newPlayerToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnLastname,
            this.ColumnMajor,
            this.ColumnDisplayname,
            this.ColumnIdname,
            this.ColumnMailuser,
            this.ColumnPhone,
            this.ColumnAge});
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(983, 465);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnLastname
            // 
            this.ColumnLastname.DataPropertyName = "lastname";
            this.ColumnLastname.HeaderText = "Lastname";
            this.ColumnLastname.MinimumWidth = 8;
            this.ColumnLastname.Name = "ColumnLastname";
            this.ColumnLastname.Width = 150;
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.DataPropertyName = "Major";
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.MinimumWidth = 8;
            this.ColumnMajor.Name = "ColumnMajor";
            this.ColumnMajor.Width = 150;
            // 
            // ColumnDisplayname
            // 
            this.ColumnDisplayname.DataPropertyName = "Displayname";
            this.ColumnDisplayname.HeaderText = "Displayname";
            this.ColumnDisplayname.MinimumWidth = 8;
            this.ColumnDisplayname.Name = "ColumnDisplayname";
            this.ColumnDisplayname.Width = 150;
            // 
            // ColumnIdname
            // 
            this.ColumnIdname.DataPropertyName = "ID";
            this.ColumnIdname.HeaderText = "ID";
            this.ColumnIdname.MinimumWidth = 8;
            this.ColumnIdname.Name = "ColumnIdname";
            this.ColumnIdname.Width = 150;
            // 
            // ColumnMailuser
            // 
            this.ColumnMailuser.DataPropertyName = "Mail";
            this.ColumnMailuser.HeaderText = "Mail";
            this.ColumnMailuser.MinimumWidth = 8;
            this.ColumnMailuser.Name = "ColumnMailuser";
            this.ColumnMailuser.Width = 150;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "Phone";
            this.ColumnPhone.HeaderText = "Phone";
            this.ColumnPhone.MinimumWidth = 8;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Width = 150;
            // 
            // ColumnAge
            // 
            this.ColumnAge.DataPropertyName = "Age";
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.MinimumWidth = 8;
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.Width = 150;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(CISESPORT.Player);
            // 
            // playerBindingSource1
            // 
            this.playerBindingSource1.DataSource = typeof(CISESPORT.Player);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(990, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAllPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAllPlayer";
            this.Text = "FormAllPlayer";
            this.Load += new System.EventHandler(this.FormAllPlayer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private DataGridView dataGridView1;
        private BindingSource playerBindingSource;
        private BindingSource playerBindingSource1;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem1;
        private ToolStripMenuItem existToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastname;
        private DataGridViewTextBoxColumn ColumnMajor;
        private DataGridViewTextBoxColumn ColumnDisplayname;
        private DataGridViewTextBoxColumn ColumnIdname;
        private DataGridViewTextBoxColumn ColumnMailuser;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAge;
        private Button button1;
    }
}