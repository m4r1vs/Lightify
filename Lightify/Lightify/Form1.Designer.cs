namespace Lightify
{
    partial class Lightify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lightify));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Static";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.static_button);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Spectrum Cycle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.fade_button);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Breathing";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.breath_button);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 87);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 27);
            this.button8.TabIndex = 8;
            this.button8.Text = "Party";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.party_button);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 156);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effect-Modes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(165, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 90);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Applications";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 26);
            this.button3.TabIndex = 1;
            this.button3.Text = "Audioly";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.audioly_button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ambilight";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ambilight_button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Assuming Arduino is connected to COM3";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(172, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 27);
            this.button6.TabIndex = 26;
            this.button6.Text = "Turn Off";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.turnoff_Click);
            // 
            // Lightify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 191);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lightify";
            this.Text = "Lightify";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
    }
}

