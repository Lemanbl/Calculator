namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.deleteButton = new System.Windows.Forms.Button();
            this.parenthesesButton = new System.Windows.Forms.Button();
            this.percentButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Lavender;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(43, 229);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 60);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "C";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // parenthesesButton
            // 
            this.parenthesesButton.BackColor = System.Drawing.Color.Lavender;
            this.parenthesesButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parenthesesButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.parenthesesButton.Location = new System.Drawing.Point(121, 229);
            this.parenthesesButton.Name = "parenthesesButton";
            this.parenthesesButton.Size = new System.Drawing.Size(60, 60);
            this.parenthesesButton.TabIndex = 1;
            this.parenthesesButton.Text = "()";
            this.parenthesesButton.UseVisualStyleBackColor = false;
            // 
            // percentButton
            // 
            this.percentButton.BackColor = System.Drawing.Color.Lavender;
            this.percentButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.percentButton.Location = new System.Drawing.Point(197, 229);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(60, 60);
            this.percentButton.TabIndex = 2;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = false;
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.Lavender;
            this.divisionButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.divisionButton.Location = new System.Drawing.Point(275, 229);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(60, 60);
            this.divisionButton.TabIndex = 3;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // mulButton
            // 
            this.mulButton.BackColor = System.Drawing.Color.Lavender;
            this.mulButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.mulButton.Location = new System.Drawing.Point(275, 304);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(60, 60);
            this.mulButton.TabIndex = 7;
            this.mulButton.Text = "x";
            this.mulButton.UseVisualStyleBackColor = false;
            this.mulButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lavender;
            this.button6.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Navy;
            this.button6.Location = new System.Drawing.Point(197, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lavender;
            this.button7.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Navy;
            this.button7.Location = new System.Drawing.Point(121, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 5;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lavender;
            this.button8.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Navy;
            this.button8.Location = new System.Drawing.Point(43, 304);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 4;
            this.button8.Text = "1";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lavender;
            this.addButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.addButton.Location = new System.Drawing.Point(275, 455);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 60);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Lavender;
            this.button10.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Navy;
            this.button10.Location = new System.Drawing.Point(197, 455);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 60);
            this.button10.TabIndex = 14;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Lavender;
            this.button11.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Navy;
            this.button11.Location = new System.Drawing.Point(121, 455);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 60);
            this.button11.TabIndex = 13;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Lavender;
            this.button12.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Navy;
            this.button12.Location = new System.Drawing.Point(43, 455);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 60);
            this.button12.TabIndex = 12;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.Lavender;
            this.subButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.subButton.Location = new System.Drawing.Point(275, 380);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(60, 60);
            this.subButton.TabIndex = 11;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Lavender;
            this.button14.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Navy;
            this.button14.Location = new System.Drawing.Point(197, 380);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 60);
            this.button14.TabIndex = 10;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Lavender;
            this.button15.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Navy;
            this.button15.Location = new System.Drawing.Point(121, 380);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 60);
            this.button15.TabIndex = 9;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Lavender;
            this.button16.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Navy;
            this.button16.Location = new System.Drawing.Point(43, 380);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 60);
            this.button16.TabIndex = 8;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.Green;
            this.equalButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.equalButton.Location = new System.Drawing.Point(275, 529);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(60, 60);
            this.equalButton.TabIndex = 19;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.Color.Lavender;
            this.pointButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointButton.ForeColor = System.Drawing.Color.Navy;
            this.pointButton.Location = new System.Drawing.Point(197, 529);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(60, 60);
            this.pointButton.TabIndex = 18;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Lavender;
            this.button19.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Navy;
            this.button19.Location = new System.Drawing.Point(121, 529);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 60);
            this.button19.TabIndex = 17;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Lavender;
            this.minusButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.Color.Navy;
            this.minusButton.Location = new System.Drawing.Point(43, 529);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(60, 60);
            this.minusButton.TabIndex = 16;
            this.minusButton.Text = "+/-";
            this.minusButton.UseVisualStyleBackColor = false;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Navy;
            this.textBox.Location = new System.Drawing.Point(24, 34);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(332, 116);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(24, 164);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(331, 53);
            this.resultLabel.TabIndex = 21;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(375, 621);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.parenthesesButton);
            this.Controls.Add(this.deleteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button parenthesesButton;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

