namespace RadSistems
{
    partial class ExportForm
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
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_client = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.button_action = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(512, 99);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_start.TabIndex = 0;
            // 
            // dataGridView_client
            // 
            this.dataGridView_client.AllowUserToAddRows = false;
            this.dataGridView_client.AllowUserToDeleteRows = false;
            this.dataGridView_client.AllowUserToResizeRows = false;
            this.dataGridView_client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_client.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_client.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_client.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_client.Name = "dataGridView_client";
            this.dataGridView_client.ReadOnly = true;
            this.dataGridView_client.RowHeadersWidth = 51;
            this.dataGridView_client.RowTemplate.Height = 24;
            this.dataGridView_client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_client.Size = new System.Drawing.Size(412, 450);
            this.dataGridView_client.TabIndex = 1;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(512, 192);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_end.TabIndex = 0;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(544, 309);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(123, 27);
            this.button_action.TabIndex = 2;
            this.button_action.Text = "Сформировать";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "С";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "по";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.dataGridView_client);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DataGridView dataGridView_client;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}