namespace RadSistems
{
    partial class AEProductForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_action
            // 
            this.button_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_action.Location = new System.Drawing.Point(188, 118);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(90, 35);
            this.button_action.TabIndex = 0;
            this.button_action.Text = "Добавить";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_cancel.Location = new System.Drawing.Point(12, 118);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(90, 35);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Отменить";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_name.Location = new System.Drawing.Point(101, 39);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(170, 26);
            this.textBox_name.TabIndex = 2;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_name.Location = new System.Drawing.Point(12, 39);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(83, 20);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Название";
            // 
            // AEProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 165);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_action);
            this.Name = "AEProductForm";
            this.Text = "AEProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
    }
}