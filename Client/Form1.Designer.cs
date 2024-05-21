namespace Client
{
    partial class Form1
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
            this.dataGridViewIndustry = new System.Windows.Forms.DataGridView();
            this.dataGridViewHoldings = new System.Windows.Forms.DataGridView();
            this.dataGridViewMaster = new System.Windows.Forms.DataGridView();
            this.masterAdd = new System.Windows.Forms.Button();
            this.masterDelete = new System.Windows.Forms.Button();
            this.holdingsDelete = new System.Windows.Forms.Button();
            this.holdingsAdd = new System.Windows.Forms.Button();
            this.industryDelete = new System.Windows.Forms.Button();
            this.industryAdd = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndustry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewIndustry
            // 
            this.dataGridViewIndustry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndustry.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewIndustry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewIndustry.Name = "dataGridViewIndustry";
            this.dataGridViewIndustry.RowHeadersWidth = 51;
            this.dataGridViewIndustry.RowTemplate.Height = 24;
            this.dataGridViewIndustry.Size = new System.Drawing.Size(492, 281);
            this.dataGridViewIndustry.TabIndex = 0;
            this.dataGridViewIndustry.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewIndustry_CellDoubleClick);
            // 
            // dataGridViewHoldings
            // 
            this.dataGridViewHoldings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoldings.Location = new System.Drawing.Point(523, 50);
            this.dataGridViewHoldings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHoldings.Name = "dataGridViewHoldings";
            this.dataGridViewHoldings.RowHeadersWidth = 51;
            this.dataGridViewHoldings.RowTemplate.Height = 24;
            this.dataGridViewHoldings.Size = new System.Drawing.Size(596, 281);
            this.dataGridViewHoldings.TabIndex = 1;
            // 
            // dataGridViewMaster
            // 
            this.dataGridViewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaster.Location = new System.Drawing.Point(12, 408);
            this.dataGridViewMaster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMaster.Name = "dataGridViewMaster";
            this.dataGridViewMaster.RowHeadersWidth = 51;
            this.dataGridViewMaster.RowTemplate.Height = 24;
            this.dataGridViewMaster.Size = new System.Drawing.Size(1107, 213);
            this.dataGridViewMaster.TabIndex = 2;
            this.dataGridViewMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMaster_CellDoubleClick);
            // 
            // masterAdd
            // 
            this.masterAdd.Location = new System.Drawing.Point(12, 626);
            this.masterAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masterAdd.Name = "masterAdd";
            this.masterAdd.Size = new System.Drawing.Size(133, 50);
            this.masterAdd.TabIndex = 3;
            this.masterAdd.Text = "Додати рядок";
            this.masterAdd.UseVisualStyleBackColor = true;
            this.masterAdd.Click += new System.EventHandler(this.masterAdd_Click);
            // 
            // masterDelete
            // 
            this.masterDelete.Location = new System.Drawing.Point(192, 626);
            this.masterDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.masterDelete.Name = "masterDelete";
            this.masterDelete.Size = new System.Drawing.Size(124, 50);
            this.masterDelete.TabIndex = 4;
            this.masterDelete.Text = "Видалити рядок";
            this.masterDelete.UseVisualStyleBackColor = true;
            this.masterDelete.Click += new System.EventHandler(this.masterDelete_Click);
            // 
            // holdingsDelete
            // 
            this.holdingsDelete.Location = new System.Drawing.Point(703, 338);
            this.holdingsDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.holdingsDelete.Name = "holdingsDelete";
            this.holdingsDelete.Size = new System.Drawing.Size(124, 50);
            this.holdingsDelete.TabIndex = 6;
            this.holdingsDelete.Text = "Видалити рядок";
            this.holdingsDelete.UseVisualStyleBackColor = true;
            this.holdingsDelete.Click += new System.EventHandler(this.holdingsDelete_Click);
            // 
            // holdingsAdd
            // 
            this.holdingsAdd.Location = new System.Drawing.Point(523, 338);
            this.holdingsAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.holdingsAdd.Name = "holdingsAdd";
            this.holdingsAdd.Size = new System.Drawing.Size(133, 50);
            this.holdingsAdd.TabIndex = 5;
            this.holdingsAdd.Text = "Додати рядок";
            this.holdingsAdd.UseVisualStyleBackColor = true;
            this.holdingsAdd.Click += new System.EventHandler(this.holdingsAdd_Click);
            // 
            // industryDelete
            // 
            this.industryDelete.Location = new System.Drawing.Point(192, 338);
            this.industryDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.industryDelete.Name = "industryDelete";
            this.industryDelete.Size = new System.Drawing.Size(124, 50);
            this.industryDelete.TabIndex = 8;
            this.industryDelete.Text = "Видалити рядок";
            this.industryDelete.UseVisualStyleBackColor = true;
            this.industryDelete.Click += new System.EventHandler(this.industryDelete_Click);
            // 
            // industryAdd
            // 
            this.industryAdd.Location = new System.Drawing.Point(12, 338);
            this.industryAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.industryAdd.Name = "industryAdd";
            this.industryAdd.Size = new System.Drawing.Size(133, 50);
            this.industryAdd.TabIndex = 7;
            this.industryAdd.Text = "Додати рядок";
            this.industryAdd.UseVisualStyleBackColor = true;
            this.industryAdd.Click += new System.EventHandler(this.industryAdd_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(987, 338);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 50);
            this.button7.TabIndex = 9;
            this.button7.Text = "Зберегти зміни";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1131, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpContextToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpContextToolStripMenuItem
            // 
            this.helpContextToolStripMenuItem.Name = "helpContextToolStripMenuItem";
            this.helpContextToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.helpContextToolStripMenuItem.Text = "Help context";
            this.helpContextToolStripMenuItem.Click += new System.EventHandler(this.helpContextToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Промисловість";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Акції";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Володіння акціями";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 678);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.industryDelete);
            this.Controls.Add(this.industryAdd);
            this.Controls.Add(this.holdingsDelete);
            this.Controls.Add(this.holdingsAdd);
            this.Controls.Add(this.masterDelete);
            this.Controls.Add(this.masterAdd);
            this.Controls.Add(this.dataGridViewMaster);
            this.Controls.Add(this.dataGridViewHoldings);
            this.Controls.Add(this.dataGridViewIndustry);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndustry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaster)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIndustry;
        private System.Windows.Forms.DataGridView dataGridViewHoldings;
        private System.Windows.Forms.DataGridView dataGridViewMaster;
        private System.Windows.Forms.Button masterAdd;
        private System.Windows.Forms.Button masterDelete;
        private System.Windows.Forms.Button holdingsDelete;
        private System.Windows.Forms.Button holdingsAdd;
        private System.Windows.Forms.Button industryDelete;
        private System.Windows.Forms.Button industryAdd;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContextToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

