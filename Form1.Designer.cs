namespace PHnewnew
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LbVolume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.LbRow1 = new System.Windows.Forms.Label();
            this.LbRow2 = new System.Windows.Forms.Label();
            this.LbRow3 = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Volume:";
            // 
            // LbVolume
            // 
            this.LbVolume.AutoSize = true;
            this.LbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbVolume.Location = new System.Drawing.Point(240, 70);
            this.LbVolume.Name = "LbVolume";
            this.LbVolume.Size = new System.Drawing.Size(55, 24);
            this.LbVolume.TabIndex = 2;
            this.LbVolume.Text = "100%";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbRow1
            // 
            this.LbRow1.AutoSize = true;
            this.LbRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRow1.ForeColor = System.Drawing.Color.ForestGreen;
            this.LbRow1.Location = new System.Drawing.Point(14, 111);
            this.LbRow1.Name = "LbRow1";
            this.LbRow1.Size = new System.Drawing.Size(36, 25);
            this.LbRow1.TabIndex = 4;
            this.LbRow1.Text = "=>";
            this.LbRow1.Visible = false;
            // 
            // LbRow2
            // 
            this.LbRow2.AutoSize = true;
            this.LbRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRow2.ForeColor = System.Drawing.Color.ForestGreen;
            this.LbRow2.Location = new System.Drawing.Point(14, 141);
            this.LbRow2.Name = "LbRow2";
            this.LbRow2.Size = new System.Drawing.Size(36, 25);
            this.LbRow2.TabIndex = 5;
            this.LbRow2.Text = "=>";
            // 
            // LbRow3
            // 
            this.LbRow3.AutoSize = true;
            this.LbRow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRow3.ForeColor = System.Drawing.Color.ForestGreen;
            this.LbRow3.Location = new System.Drawing.Point(14, 171);
            this.LbRow3.Name = "LbRow3";
            this.LbRow3.Size = new System.Drawing.Size(36, 25);
            this.LbRow3.TabIndex = 6;
            this.LbRow3.Text = "=>";
            this.LbRow3.Visible = false;
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(21, 85);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(29, 23);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(21, 199);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(29, 23);
            this.buttonDown.TabIndex = 8;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 273);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.LbRow3);
            this.Controls.Add(this.LbRow2);
            this.Controls.Add(this.LbRow1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbVolume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbVolume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbRow1;
        private System.Windows.Forms.Label LbRow2;
        private System.Windows.Forms.Label LbRow3;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
    }
}

