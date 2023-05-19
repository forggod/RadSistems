namespace RadSistems
{
    partial class AEClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_action
            // 
            this.button_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_action.Location = new System.Drawing.Point(205, 125);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(90, 35);
            this.button_action.TabIndex = 0;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО клиента:";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_name.Location = new System.Drawing.Point(136, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(152, 26);
            this.textBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Телефон:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_phone.Location = new System.Drawing.Point(136, 65);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(152, 26);
            this.textBox_phone.TabIndex = 5;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_cancel.Location = new System.Drawing.Point(12, 125);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(90, 35);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Назад";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // AEClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 173);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_action);
            this.Name = "AEClientForm";
            this.Text = "AEClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Button button_cancel;
    }
}