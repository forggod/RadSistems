namespace RadSistems
{
    partial class AEFacturaInfo
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
            this.button_action = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_product = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.SuspendLayout();
            // 
            // button_action
            // 
            this.button_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_action.Location = new System.Drawing.Point(269, 175);
            this.button_action.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(120, 43);
            this.button_action.TabIndex = 0;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_cancel.Location = new System.Drawing.Point(16, 175);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(120, 43);
            this.button_cancel.TabIndex = 0;
            this.button_cancel.Text = "Отменить";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_product.Location = new System.Drawing.Point(23, 26);
            this.label_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(97, 25);
            this.label_product.TabIndex = 1;
            this.label_product.Text = "Продукт:";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_price.Location = new System.Drawing.Point(57, 81);
            this.label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(64, 25);
            this.label_price.TabIndex = 1;
            this.label_price.Text = "Цена:";
            // 
            // comboBox_product
            // 
            this.comboBox_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(135, 26);
            this.comboBox_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(232, 33);
            this.comboBox_product.TabIndex = 3;
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown_price.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_price.Location = new System.Drawing.Point(135, 81);
            this.numericUpDown_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(233, 30);
            this.numericUpDown_price.TabIndex = 4;
            this.numericUpDown_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AEFacturaInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 233);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_action);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AEFacturaInfo";
            this.Text = "AEFacturaInfo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
    }
}