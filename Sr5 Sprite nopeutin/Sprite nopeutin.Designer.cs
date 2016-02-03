namespace Sr5_Sprite_nopeutin
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.compileValue = new System.Windows.Forms.NumericUpDown();
            this.registerValue = new System.Windows.Forms.NumericUpDown();
            this.soakValue = new System.Windows.Forms.NumericUpDown();
            this.levelValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.compileValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soakValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(123, 109);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Do it!";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // compileValue
            // 
            this.compileValue.Location = new System.Drawing.Point(15, 39);
            this.compileValue.Name = "compileValue";
            this.compileValue.Size = new System.Drawing.Size(56, 20);
            this.compileValue.TabIndex = 5;
            this.compileValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.compileValue.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // registerValue
            // 
            this.registerValue.Location = new System.Drawing.Point(96, 39);
            this.registerValue.Name = "registerValue";
            this.registerValue.Size = new System.Drawing.Size(56, 20);
            this.registerValue.TabIndex = 6;
            this.registerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.registerValue.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // soakValue
            // 
            this.soakValue.Location = new System.Drawing.Point(183, 39);
            this.soakValue.Name = "soakValue";
            this.soakValue.Size = new System.Drawing.Size(56, 20);
            this.soakValue.TabIndex = 7;
            this.soakValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soakValue.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // levelValue
            // 
            this.levelValue.Location = new System.Drawing.Point(265, 39);
            this.levelValue.Name = "levelValue";
            this.levelValue.Size = new System.Drawing.Size(56, 20);
            this.levelValue.TabIndex = 8;
            this.levelValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.levelValue.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 149);
            this.Controls.Add(this.levelValue);
            this.Controls.Add(this.soakValue);
            this.Controls.Add(this.registerValue);
            this.Controls.Add(this.compileValue);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sr5 sprite nopeutin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compileValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soakValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.NumericUpDown compileValue;
        private System.Windows.Forms.NumericUpDown registerValue;
        private System.Windows.Forms.NumericUpDown soakValue;
        private System.Windows.Forms.NumericUpDown levelValue;
    }
}

