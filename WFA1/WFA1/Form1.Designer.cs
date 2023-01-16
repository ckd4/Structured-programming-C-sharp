namespace WFA1
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
            this.btnresult = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.tbp = new System.Windows.Forms.TextBox();
            this.tbr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnresult
            // 
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnresult.Location = new System.Drawing.Point(242, 166);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(137, 49);
            this.btnresult.TabIndex = 0;
            this.btnresult.Text = "Вычислить";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblR.Location = new System.Drawing.Point(438, 166);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 42);
            this.lblR.TabIndex = 1;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblP.Location = new System.Drawing.Point(165, 166);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 42);
            this.lblP.TabIndex = 2;
            // 
            // tbp
            // 
            this.tbp.Location = new System.Drawing.Point(146, 112);
            this.tbp.Name = "tbp";
            this.tbp.Size = new System.Drawing.Size(100, 20);
            this.tbp.TabIndex = 3;
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(376, 112);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(100, 20);
            this.tbr.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 353);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.tbp);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnresult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox tbp;
        private System.Windows.Forms.TextBox tbr;
    }
}

