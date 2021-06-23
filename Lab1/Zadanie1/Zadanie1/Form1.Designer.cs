
namespace Zadanie1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(338, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(346, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(354, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(131, 68);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(125, 27);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(131, 145);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(125, 27);
            this.textBoxZ.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(131, 107);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(125, 27);
            this.textBoxY.TabIndex = 2;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(290, 68);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(94, 29);
            this.buttonSum.TabIndex = 3;
            this.buttonSum.Text = "Suma";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(290, 105);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(94, 29);
            this.buttonMul.TabIndex = 4;
            this.buttonMul.Text = "Iloczyn";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.Location = new System.Drawing.Point(290, 143);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(94, 29);
            this.buttonEx.TabIndex = 5;
            this.buttonEx.Text = "Wyjście";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "z";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(131, 200);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(125, 27);
            this.textBoxAnswer.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label4;
    }
}

