namespace WFA4
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
            this.tbToCompare1 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.tbToCompare2 = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbToCompare1
            // 
            this.tbToCompare1.Location = new System.Drawing.Point(12, 120);
            this.tbToCompare1.Name = "tbToCompare1";
            this.tbToCompare1.Size = new System.Drawing.Size(189, 20);
            this.tbToCompare1.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(169, 173);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(90, 34);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Сравнить";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // tbToCompare2
            // 
            this.tbToCompare2.Location = new System.Drawing.Point(245, 120);
            this.tbToCompare2.Name = "tbToCompare2";
            this.tbToCompare2.Size = new System.Drawing.Size(196, 20);
            this.tbToCompare2.TabIndex = 2;
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut.Location = new System.Drawing.Point(49, 52);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(0, 25);
            this.lblOut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 295);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.tbToCompare2);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tbToCompare1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToCompare1;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox tbToCompare2;
        private System.Windows.Forms.Label lblOut;
    }
}

