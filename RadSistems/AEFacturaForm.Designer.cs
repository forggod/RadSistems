using System.Drawing;
using System.Windows.Forms;

namespace RadSistems
{
    partial class AEFacturaForm
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
            this.panel_address = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_address = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_action = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.panel_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_address
            // 
            this.panel_address.Controls.Add(this.comboBox1);
            this.panel_address.Controls.Add(this.numericUpDown1);
            this.panel_address.Controls.Add(this.label1);
            this.panel_address.Controls.Add(this.dateTimePicker_date);
            this.panel_address.Controls.Add(this.label_address);
            this.panel_address.Controls.Add(this.button_cancel);
            this.panel_address.Controls.Add(this.button_action);
            this.panel_address.Controls.Add(this.label_name);
            this.panel_address.Location = new System.Drawing.Point(12, 10);
            this.panel_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_address.Name = "panel_address";
            this.panel_address.Size = new System.Drawing.Size(411, 329);
            this.panel_address.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 134);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(251, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Оплата";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(125, 76);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(249, 22);
            this.dateTimePicker_date.TabIndex = 1;
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(33, 76);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(42, 16);
            this.label_address.TabIndex = 3;
            this.label_address.Text = "Дата:";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(281, 293);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(115, 32);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(16, 293);
            this.button_action.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(115, 32);
            this.button_action.TabIndex = 6;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(32, 36);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 16);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Клиент:";
            // 
            // AEFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 353);
            this.Controls.Add(this.panel_address);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AEFacturaForm";
            this.Text = "AEFuturaForm";
            this.panel_address.ResumeLayout(false);
            this.panel_address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_address;
        private Label label_address;
        private Button button_cancel;
        private Button button_action;
        private Label label_name;
        private DateTimePicker dateTimePicker_date;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private ComboBox comboBox1;
    }
}