namespace Lab6_1CreditCardMasker
{
    partial class FormCreditCardMasker
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
            this.buttonMask = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.labelMask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMask
            // 
            this.buttonMask.Location = new System.Drawing.Point(517, 79);
            this.buttonMask.Name = "buttonMask";
            this.buttonMask.Size = new System.Drawing.Size(127, 47);
            this.buttonMask.TabIndex = 1;
            this.buttonMask.Text = "Mask";
            this.buttonMask.UseVisualStyleBackColor = true;
            this.buttonMask.Click += new System.EventHandler(this.buttonMask_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(354, 200);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 47);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(67, 200);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 47);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxCreditCardNumber
            // 
            this.textBoxCreditCardNumber.Location = new System.Drawing.Point(63, 55);
            this.textBoxCreditCardNumber.Multiline = true;
            this.textBoxCreditCardNumber.Name = "textBoxCreditCardNumber";
            this.textBoxCreditCardNumber.Size = new System.Drawing.Size(418, 40);
            this.textBoxCreditCardNumber.TabIndex = 0;
            this.textBoxCreditCardNumber.WordWrap = false;
            // 
            // labelMask
            // 
            this.labelMask.BackColor = System.Drawing.SystemColors.Control;
            this.labelMask.Location = new System.Drawing.Point(63, 107);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(418, 40);
            this.labelMask.TabIndex = 4;
            // 
            // FormCreditCardMasker
            // 
            this.AcceptButton = this.buttonMask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(692, 303);
            this.Controls.Add(this.labelMask);
            this.Controls.Add(this.textBoxCreditCardNumber);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonMask);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCreditCardMasker";
            this.Text = "Credit Card Masker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMask;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxCreditCardNumber;
        private System.Windows.Forms.Label labelMask;
    }
}

