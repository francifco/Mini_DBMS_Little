namespace SQL_Franci
{
    partial class WinSQL
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
            this.ExeQuery = new System.Windows.Forms.Button();
            this.ClearBrowser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textQueryCmd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtToken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExeQuery
            // 
            this.ExeQuery.Location = new System.Drawing.Point(12, 338);
            this.ExeQuery.Name = "ExeQuery";
            this.ExeQuery.Size = new System.Drawing.Size(204, 23);
            this.ExeQuery.TabIndex = 0;
            this.ExeQuery.Text = "Execute Query";
            this.ExeQuery.UseVisualStyleBackColor = true;
            // 
            // ClearBrowser
            // 
            this.ClearBrowser.Location = new System.Drawing.Point(235, 338);
            this.ClearBrowser.Name = "ClearBrowser";
            this.ClearBrowser.Size = new System.Drawing.Size(221, 23);
            this.ClearBrowser.TabIndex = 1;
            this.ClearBrowser.Text = "Clear browser";
            this.ClearBrowser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textQueryCmd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 320);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Querys commands";
            // 
            // textQueryCmd
            // 
            this.textQueryCmd.Location = new System.Drawing.Point(7, 19);
            this.textQueryCmd.Multiline = true;
            this.textQueryCmd.Name = "textQueryCmd";
            this.textQueryCmd.Size = new System.Drawing.Size(191, 295);
            this.textQueryCmd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browser";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TxtToken,
            this.TxtLexema});
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(208, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // TxtToken
            // 
            this.TxtToken.HeaderText = "Token";
            this.TxtToken.Name = "TxtToken";
            this.TxtToken.ReadOnly = true;
            // 
            // TxtLexema
            // 
            this.TxtLexema.HeaderText = "Lexema";
            this.TxtLexema.Name = "TxtLexema";
            this.TxtLexema.ReadOnly = true;
            // 
            // WinSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClearBrowser);
            this.Controls.Add(this.ExeQuery);
            this.Name = "WinSQL";
            this.Text = "SQL-Franci";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExeQuery;
        private System.Windows.Forms.Button ClearBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textQueryCmd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtToken;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtLexema;
    }
}

