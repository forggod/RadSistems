namespace RadSistems
{
    partial class DataForm
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
            this.dataGridView_first = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaInfoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_second = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_first)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_second)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_first
            // 
            this.dataGridView_first.AllowUserToAddRows = false;
            this.dataGridView_first.AllowUserToDeleteRows = false;
            this.dataGridView_first.AllowUserToResizeRows = false;
            this.dataGridView_first.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_first.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_first.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_first.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_first.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_first.Location = new System.Drawing.Point(0, 28);
            this.dataGridView_first.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_first.MultiSelect = false;
            this.dataGridView_first.Name = "dataGridView_first";
            this.dataGridView_first.ReadOnly = true;
            this.dataGridView_first.RowHeadersWidth = 51;
            this.dataGridView_first.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_first.Size = new System.Drawing.Size(1067, 246);
            this.dataGridView_first.TabIndex = 0;
            this.dataGridView_first.SelectionChanged += new System.EventHandler(this.dataGridView_first_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Add});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Add
            // 
            this.ToolStripMenuItem_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.ToolStripMenuItem_Edit,
            this.ToolStripMenuItem_Delete});
            this.ToolStripMenuItem_Add.Name = "ToolStripMenuItem_Add";
            this.ToolStripMenuItem_Add.Size = new System.Drawing.Size(65, 24);
            this.ToolStripMenuItem_Add.Text = "Меню";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.facturaInfoToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Add_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facturaToolStripMenuItem.Text = "Отчёт";
            this.facturaToolStripMenuItem.Visible = false;
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // facturaInfoToolStripMenuItem
            // 
            this.facturaInfoToolStripMenuItem.Name = "facturaInfoToolStripMenuItem";
            this.facturaInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facturaInfoToolStripMenuItem.Text = "Накладная";
            this.facturaInfoToolStripMenuItem.Visible = false;
            this.facturaInfoToolStripMenuItem.Click += new System.EventHandler(this.facturaInfoToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Edit
            // 
            this.ToolStripMenuItem_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem1,
            this.facturaInfoToolStripMenuItem1});
            this.ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            this.ToolStripMenuItem_Edit.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_Edit.Text = "Изменить";
            this.ToolStripMenuItem_Edit.Click += new System.EventHandler(this.ToolStripMenuItem_Edit_Click);
            // 
            // facturaToolStripMenuItem1
            // 
            this.facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            this.facturaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.facturaToolStripMenuItem1.Text = "Отчёт";
            this.facturaToolStripMenuItem1.Visible = false;
            this.facturaToolStripMenuItem1.Click += new System.EventHandler(this.facturaToolStripMenuItem1_Click);
            // 
            // facturaInfoToolStripMenuItem1
            // 
            this.facturaInfoToolStripMenuItem1.Name = "facturaInfoToolStripMenuItem1";
            this.facturaInfoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.facturaInfoToolStripMenuItem1.Text = "Накладная";
            this.facturaInfoToolStripMenuItem1.Visible = false;
            this.facturaInfoToolStripMenuItem1.Click += new System.EventHandler(this.facturaInfoToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem2,
            this.facturaInfoToolStripMenuItem2});
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem_Delete.Text = "Удалить";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // facturaToolStripMenuItem2
            // 
            this.facturaToolStripMenuItem2.Name = "facturaToolStripMenuItem2";
            this.facturaToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.facturaToolStripMenuItem2.Text = "Отчёт";
            this.facturaToolStripMenuItem2.Visible = false;
            this.facturaToolStripMenuItem2.Click += new System.EventHandler(this.facturaToolStripMenuItem2_Click);
            // 
            // facturaInfoToolStripMenuItem2
            // 
            this.facturaInfoToolStripMenuItem2.Name = "facturaInfoToolStripMenuItem2";
            this.facturaInfoToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.facturaInfoToolStripMenuItem2.Text = "Накладная";
            this.facturaInfoToolStripMenuItem2.Visible = false;
            this.facturaInfoToolStripMenuItem2.Click += new System.EventHandler(this.facturaInfoToolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отчёты:";
            // 
            // timer_update
            // 
            this.timer_update.Enabled = true;
            this.timer_update.Interval = 2000;
            this.timer_update.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dataGridView_second);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 280);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // dataGridView_second
            // 
            this.dataGridView_second.AllowUserToAddRows = false;
            this.dataGridView_second.AllowUserToDeleteRows = false;
            this.dataGridView_second.AllowUserToResizeRows = false;
            this.dataGridView_second.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_second.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_second.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_second.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_second.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_second.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_second.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_second.MultiSelect = false;
            this.dataGridView_second.Name = "dataGridView_second";
            this.dataGridView_second.ReadOnly = true;
            this.dataGridView_second.RowHeadersWidth = 51;
            this.dataGridView_second.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_second.Size = new System.Drawing.Size(1067, 255);
            this.dataGridView_second.TabIndex = 4;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_first);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataForm";
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_first)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_first;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Add;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_second;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem facturaInfoToolStripMenuItem2;
    }
}