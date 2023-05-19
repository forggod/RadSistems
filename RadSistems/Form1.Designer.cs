namespace RadSistems
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_invoices = new System.Windows.Forms.Button();
            this.button_client = new System.Windows.Forms.Button();
            this.button_price = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_invoices);
            this.panel1.Controls.Add(this.button_client);
            this.panel1.Controls.Add(this.button_price);
            this.panel1.Controls.Add(this.button_product);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 347);
            this.panel1.TabIndex = 0;
            // 
            // button_invoices
            // 
            this.button_invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_invoices.Location = new System.Drawing.Point(52, 181);
            this.button_invoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_invoices.Name = "button_invoices";
            this.button_invoices.Size = new System.Drawing.Size(165, 46);
            this.button_invoices.TabIndex = 3;
            this.button_invoices.Text = "Накладная";
            this.button_invoices.UseVisualStyleBackColor = true;
            this.button_invoices.Click += new System.EventHandler(this.button_invoices_Click);
            // 
            // button_client
            // 
            this.button_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_client.Location = new System.Drawing.Point(52, 128);
            this.button_client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(165, 46);
            this.button_client.TabIndex = 2;
            this.button_client.Text = "Клиенты";
            this.button_client.UseVisualStyleBackColor = true;
            this.button_client.Click += new System.EventHandler(this.button_client_Click);
            // 
            // button_price
            // 
            this.button_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_price.Location = new System.Drawing.Point(52, 75);
            this.button_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_price.Name = "button_price";
            this.button_price.Size = new System.Drawing.Size(165, 46);
            this.button_price.TabIndex = 1;
            this.button_price.Text = "Цены";
            this.button_price.UseVisualStyleBackColor = true;
            this.button_price.Click += new System.EventHandler(this.button_price_Click);
            // 
            // button_product
            // 
            this.button_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_product.Location = new System.Drawing.Point(52, 22);
            this.button_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(165, 46);
            this.button_product.TabIndex = 0;
            this.button_product.Text = "Товары";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(52, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Экспорт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 375);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_invoices;
        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_price;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Button button1;
    }
}

