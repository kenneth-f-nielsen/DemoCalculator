﻿namespace CalculatorDll.Form
{
    partial class CalculatorForm
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.closeButton = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.button5 = new System.Windows.Forms.Button();
         this.button6 = new System.Windows.Forms.Button();
         this.button7 = new System.Windows.Forms.Button();
         this.button8 = new System.Windows.Forms.Button();
         this.button9 = new System.Windows.Forms.Button();
         this.button10 = new System.Windows.Forms.Button();
         this.plusButton = new System.Windows.Forms.Button();
         this.minusButton = new System.Windows.Forms.Button();
         this.multiplyButton = new System.Windows.Forms.Button();
         this.divideButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // closeButton
         // 
         this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.closeButton.Location = new System.Drawing.Point(263, 278);
         this.closeButton.Margin = new System.Windows.Forms.Padding(4);
         this.closeButton.Name = "closeButton";
         this.closeButton.Size = new System.Drawing.Size(100, 28);
         this.closeButton.TabIndex = 0;
         this.closeButton.Text = "Close";
         this.closeButton.UseVisualStyleBackColor = true;
         this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(52, 72);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(29, 31);
         this.button1.TabIndex = 1;
         this.button1.Text = "1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(87, 72);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(29, 31);
         this.button2.TabIndex = 2;
         this.button2.Text = "2";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(122, 72);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(29, 31);
         this.button3.TabIndex = 3;
         this.button3.Text = "3";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(52, 109);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(29, 31);
         this.button4.TabIndex = 4;
         this.button4.Text = "4";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(87, 109);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(29, 31);
         this.button5.TabIndex = 5;
         this.button5.Text = "5";
         this.button5.UseVisualStyleBackColor = true;
         this.button5.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button6
         // 
         this.button6.Location = new System.Drawing.Point(122, 109);
         this.button6.Name = "button6";
         this.button6.Size = new System.Drawing.Size(29, 31);
         this.button6.TabIndex = 6;
         this.button6.Text = "6";
         this.button6.UseVisualStyleBackColor = true;
         this.button6.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button7
         // 
         this.button7.Location = new System.Drawing.Point(52, 146);
         this.button7.Name = "button7";
         this.button7.Size = new System.Drawing.Size(29, 31);
         this.button7.TabIndex = 7;
         this.button7.Text = "7";
         this.button7.UseVisualStyleBackColor = true;
         this.button7.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button8
         // 
         this.button8.Location = new System.Drawing.Point(87, 146);
         this.button8.Name = "button8";
         this.button8.Size = new System.Drawing.Size(29, 31);
         this.button8.TabIndex = 8;
         this.button8.Text = "8";
         this.button8.UseVisualStyleBackColor = true;
         this.button8.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button9
         // 
         this.button9.Location = new System.Drawing.Point(122, 146);
         this.button9.Name = "button9";
         this.button9.Size = new System.Drawing.Size(29, 31);
         this.button9.TabIndex = 9;
         this.button9.Text = "9";
         this.button9.UseVisualStyleBackColor = true;
         this.button9.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // button10
         // 
         this.button10.Location = new System.Drawing.Point(87, 183);
         this.button10.Name = "button10";
         this.button10.Size = new System.Drawing.Size(29, 31);
         this.button10.TabIndex = 10;
         this.button10.Text = "0";
         this.button10.UseVisualStyleBackColor = true;
         this.button10.Click += new System.EventHandler(this.digitButton_Click);
         // 
         // plusButton
         // 
         this.plusButton.Location = new System.Drawing.Point(180, 72);
         this.plusButton.Name = "plusButton";
         this.plusButton.Size = new System.Drawing.Size(29, 31);
         this.plusButton.TabIndex = 11;
         this.plusButton.Text = "+";
         this.plusButton.UseVisualStyleBackColor = true;
         this.plusButton.Click += new System.EventHandler(this.operationButton_Click);
         // 
         // minusButton
         // 
         this.minusButton.Location = new System.Drawing.Point(180, 109);
         this.minusButton.Name = "minusButton";
         this.minusButton.Size = new System.Drawing.Size(29, 31);
         this.minusButton.TabIndex = 12;
         this.minusButton.Text = "-";
         this.minusButton.UseVisualStyleBackColor = true;
         this.minusButton.Click += new System.EventHandler(this.operationButton_Click);
         // 
         // multiplyButton
         // 
         this.multiplyButton.Location = new System.Drawing.Point(180, 146);
         this.multiplyButton.Name = "multiplyButton";
         this.multiplyButton.Size = new System.Drawing.Size(29, 31);
         this.multiplyButton.TabIndex = 13;
         this.multiplyButton.Text = "*";
         this.multiplyButton.UseVisualStyleBackColor = true;
         this.multiplyButton.Click += new System.EventHandler(this.operationButton_Click);
         // 
         // divideButton
         // 
         this.divideButton.Location = new System.Drawing.Point(180, 183);
         this.divideButton.Name = "divideButton";
         this.divideButton.Size = new System.Drawing.Size(29, 31);
         this.divideButton.TabIndex = 14;
         this.divideButton.Text = "/";
         this.divideButton.UseVisualStyleBackColor = true;
         this.divideButton.Click += new System.EventHandler(this.operationButton_Click);
         // 
         // CalculatorForm
         // 
         this.AcceptButton = this.closeButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(379, 321);
         this.Controls.Add(this.divideButton);
         this.Controls.Add(this.multiplyButton);
         this.Controls.Add(this.minusButton);
         this.Controls.Add(this.plusButton);
         this.Controls.Add(this.button10);
         this.Controls.Add(this.button9);
         this.Controls.Add(this.button8);
         this.Controls.Add(this.button7);
         this.Controls.Add(this.button6);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.closeButton);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "CalculatorForm";
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.Text = "CalculatorForm";
         this.Click += new System.EventHandler(this.digitButton_Click);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.Button button8;
      private System.Windows.Forms.Button button9;
      private System.Windows.Forms.Button button10;
      private System.Windows.Forms.Button plusButton;
      private System.Windows.Forms.Button minusButton;
      private System.Windows.Forms.Button multiplyButton;
      private System.Windows.Forms.Button divideButton;
   }
}