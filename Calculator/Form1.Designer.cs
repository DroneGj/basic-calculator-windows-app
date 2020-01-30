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
            this.BtEqual = new System.Windows.Forms.Button();
            this.BtDot = new System.Windows.Forms.Button();
            this.BtMul = new System.Windows.Forms.Button();
            this.BtMin = new System.Windows.Forms.Button();
            this.BtDiv = new System.Windows.Forms.Button();
            this.BtCut = new System.Windows.Forms.Button();
            this.BtSum = new System.Windows.Forms.Button();
            this.BtThree = new System.Windows.Forms.Button();
            this.BtSix = new System.Windows.Forms.Button();
            this.BtNine = new System.Windows.Forms.Button();
            this.BtTwo = new System.Windows.Forms.Button();
            this.BtFive = new System.Windows.Forms.Button();
            this.BtEight = new System.Windows.Forms.Button();
            this.BtOne = new System.Windows.Forms.Button();
            this.BtFour = new System.Windows.Forms.Button();
            this.BtSeven = new System.Windows.Forms.Button();
            this.BtZero = new System.Windows.Forms.Button();
            this.BtAC = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.labelStoreOperation = new System.Windows.Forms.Label();
            this.BtDoubleZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtEqual
            // 
            this.BtEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEqual.Location = new System.Drawing.Point(342, 206);
            this.BtEqual.Name = "BtEqual";
            this.BtEqual.Size = new System.Drawing.Size(126, 50);
            this.BtEqual.TabIndex = 0;
            this.BtEqual.Text = "=";
            this.BtEqual.UseVisualStyleBackColor = true;
            this.BtEqual.Click += new System.EventHandler(this.BtEqual_Click);
            // 
            // BtDot
            // 
            this.BtDot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDot.Location = new System.Drawing.Point(276, 206);
            this.BtDot.Name = "BtDot";
            this.BtDot.Size = new System.Drawing.Size(60, 50);
            this.BtDot.TabIndex = 1;
            this.BtDot.Text = ".";
            this.BtDot.UseVisualStyleBackColor = true;
            this.BtDot.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtMul
            // 
            this.BtMul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMul.Location = new System.Drawing.Point(342, 150);
            this.BtMul.Name = "BtMul";
            this.BtMul.Size = new System.Drawing.Size(60, 50);
            this.BtMul.TabIndex = 2;
            this.BtMul.Text = "*";
            this.BtMul.UseVisualStyleBackColor = true;
            this.BtMul.Click += new System.EventHandler(this.BtOperator_Click);
            // 
            // BtMin
            // 
            this.BtMin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMin.Location = new System.Drawing.Point(408, 94);
            this.BtMin.Name = "BtMin";
            this.BtMin.Size = new System.Drawing.Size(60, 106);
            this.BtMin.TabIndex = 3;
            this.BtMin.Text = "-";
            this.BtMin.UseVisualStyleBackColor = true;
            this.BtMin.Click += new System.EventHandler(this.BtOperator_Click);
            // 
            // BtDiv
            // 
            this.BtDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDiv.Location = new System.Drawing.Point(342, 94);
            this.BtDiv.Name = "BtDiv";
            this.BtDiv.Size = new System.Drawing.Size(60, 50);
            this.BtDiv.TabIndex = 4;
            this.BtDiv.Text = "/";
            this.BtDiv.UseVisualStyleBackColor = true;
            this.BtDiv.Click += new System.EventHandler(this.BtOperator_Click);
            // 
            // BtCut
            // 
            this.BtCut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCut.Location = new System.Drawing.Point(408, 25);
            this.BtCut.Name = "BtCut";
            this.BtCut.Size = new System.Drawing.Size(60, 50);
            this.BtCut.TabIndex = 5;
            this.BtCut.Text = "C";
            this.BtCut.UseVisualStyleBackColor = true;
            this.BtCut.Click += new System.EventHandler(this.BtCut_Click);
            // 
            // BtSum
            // 
            this.BtSum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSum.Location = new System.Drawing.Point(276, 94);
            this.BtSum.Name = "BtSum";
            this.BtSum.Size = new System.Drawing.Size(60, 106);
            this.BtSum.TabIndex = 6;
            this.BtSum.Text = "+";
            this.BtSum.UseVisualStyleBackColor = true;
            this.BtSum.Click += new System.EventHandler(this.BtOperator_Click);
            // 
            // BtThree
            // 
            this.BtThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtThree.Location = new System.Drawing.Point(78, 150);
            this.BtThree.Name = "BtThree";
            this.BtThree.Size = new System.Drawing.Size(60, 50);
            this.BtThree.TabIndex = 7;
            this.BtThree.Text = "3";
            this.BtThree.UseVisualStyleBackColor = true;
            this.BtThree.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtSix
            // 
            this.BtSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSix.Location = new System.Drawing.Point(12, 94);
            this.BtSix.Name = "BtSix";
            this.BtSix.Size = new System.Drawing.Size(60, 50);
            this.BtSix.TabIndex = 8;
            this.BtSix.Text = "6";
            this.BtSix.UseVisualStyleBackColor = true;
            this.BtSix.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtNine
            // 
            this.BtNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNine.Location = new System.Drawing.Point(210, 94);
            this.BtNine.Name = "BtNine";
            this.BtNine.Size = new System.Drawing.Size(60, 50);
            this.BtNine.TabIndex = 9;
            this.BtNine.Text = "9";
            this.BtNine.UseVisualStyleBackColor = true;
            this.BtNine.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtTwo
            // 
            this.BtTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTwo.Location = new System.Drawing.Point(12, 150);
            this.BtTwo.Name = "BtTwo";
            this.BtTwo.Size = new System.Drawing.Size(60, 50);
            this.BtTwo.TabIndex = 10;
            this.BtTwo.Text = "2";
            this.BtTwo.UseVisualStyleBackColor = true;
            this.BtTwo.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtFive
            // 
            this.BtFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFive.Location = new System.Drawing.Point(210, 150);
            this.BtFive.Name = "BtFive";
            this.BtFive.Size = new System.Drawing.Size(60, 50);
            this.BtFive.TabIndex = 11;
            this.BtFive.Text = "5";
            this.BtFive.UseVisualStyleBackColor = true;
            this.BtFive.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtEight
            // 
            this.BtEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEight.Location = new System.Drawing.Point(144, 94);
            this.BtEight.Name = "BtEight";
            this.BtEight.Size = new System.Drawing.Size(60, 50);
            this.BtEight.TabIndex = 12;
            this.BtEight.Text = "8";
            this.BtEight.UseVisualStyleBackColor = true;
            this.BtEight.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtOne
            // 
            this.BtOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtOne.Location = new System.Drawing.Point(210, 206);
            this.BtOne.Name = "BtOne";
            this.BtOne.Size = new System.Drawing.Size(60, 50);
            this.BtOne.TabIndex = 13;
            this.BtOne.Text = "1";
            this.BtOne.UseVisualStyleBackColor = true;
            this.BtOne.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtFour
            // 
            this.BtFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFour.Location = new System.Drawing.Point(144, 150);
            this.BtFour.Name = "BtFour";
            this.BtFour.Size = new System.Drawing.Size(60, 50);
            this.BtFour.TabIndex = 14;
            this.BtFour.Text = "4";
            this.BtFour.UseVisualStyleBackColor = true;
            this.BtFour.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtSeven
            // 
            this.BtSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSeven.Location = new System.Drawing.Point(78, 94);
            this.BtSeven.Name = "BtSeven";
            this.BtSeven.Size = new System.Drawing.Size(60, 50);
            this.BtSeven.TabIndex = 15;
            this.BtSeven.Text = "7";
            this.BtSeven.UseVisualStyleBackColor = true;
            this.BtSeven.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtZero
            // 
            this.BtZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtZero.Location = new System.Drawing.Point(144, 206);
            this.BtZero.Name = "BtZero";
            this.BtZero.Size = new System.Drawing.Size(60, 50);
            this.BtZero.TabIndex = 16;
            this.BtZero.Text = "0";
            this.BtZero.UseVisualStyleBackColor = true;
            this.BtZero.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // BtAC
            // 
            this.BtAC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAC.Location = new System.Drawing.Point(12, 25);
            this.BtAC.Name = "BtAC";
            this.BtAC.Size = new System.Drawing.Size(60, 50);
            this.BtAC.TabIndex = 19;
            this.BtAC.Text = "AC";
            this.BtAC.UseVisualStyleBackColor = true;
            this.BtAC.Click += new System.EventHandler(this.BtAC_Click);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(88, 40);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(302, 31);
            this.Output.TabIndex = 20;
            this.Output.Text = "0";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelStoreOperation
            // 
            this.labelStoreOperation.AutoSize = true;
            this.labelStoreOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoreOperation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStoreOperation.Location = new System.Drawing.Point(85, 21);
            this.labelStoreOperation.Name = "labelStoreOperation";
            this.labelStoreOperation.Size = new System.Drawing.Size(0, 17);
            this.labelStoreOperation.TabIndex = 21;
            // 
            // BtDoubleZero
            // 
            this.BtDoubleZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtDoubleZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDoubleZero.Location = new System.Drawing.Point(12, 206);
            this.BtDoubleZero.Name = "BtDoubleZero";
            this.BtDoubleZero.Size = new System.Drawing.Size(126, 50);
            this.BtDoubleZero.TabIndex = 22;
            this.BtDoubleZero.Text = "00";
            this.BtDoubleZero.UseVisualStyleBackColor = true;
            this.BtDoubleZero.Click += new System.EventHandler(this.BtOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 268);
            this.Controls.Add(this.BtDoubleZero);
            this.Controls.Add(this.labelStoreOperation);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.BtAC);
            this.Controls.Add(this.BtZero);
            this.Controls.Add(this.BtSeven);
            this.Controls.Add(this.BtFour);
            this.Controls.Add(this.BtOne);
            this.Controls.Add(this.BtEight);
            this.Controls.Add(this.BtFive);
            this.Controls.Add(this.BtTwo);
            this.Controls.Add(this.BtNine);
            this.Controls.Add(this.BtSix);
            this.Controls.Add(this.BtThree);
            this.Controls.Add(this.BtSum);
            this.Controls.Add(this.BtCut);
            this.Controls.Add(this.BtDiv);
            this.Controls.Add(this.BtMin);
            this.Controls.Add(this.BtMul);
            this.Controls.Add(this.BtDot);
            this.Controls.Add(this.BtEqual);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtEqual;
        private System.Windows.Forms.Button BtDot;
        private System.Windows.Forms.Button BtMul;
        private System.Windows.Forms.Button BtMin;
        private System.Windows.Forms.Button BtDiv;
        private System.Windows.Forms.Button BtCut;
        private System.Windows.Forms.Button BtSum;
        private System.Windows.Forms.Button BtThree;
        private System.Windows.Forms.Button BtSix;
        private System.Windows.Forms.Button BtNine;
        private System.Windows.Forms.Button BtTwo;
        private System.Windows.Forms.Button BtFive;
        private System.Windows.Forms.Button BtEight;
        private System.Windows.Forms.Button BtOne;
        private System.Windows.Forms.Button BtFour;
        private System.Windows.Forms.Button BtSeven;
        private System.Windows.Forms.Button BtZero;
        private System.Windows.Forms.Button BtAC;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label labelStoreOperation;
        private System.Windows.Forms.Button BtDoubleZero;
    }
}

