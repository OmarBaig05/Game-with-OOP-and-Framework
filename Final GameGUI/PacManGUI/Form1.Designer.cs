
namespace PacManGUI
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label playerHealthLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.Scorelabel1 = new System.Windows.Forms.Label();
            this.fireTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            playerHealthLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(78, 609);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 1;
            label1.Text = "Score:";
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // Scorelabel1
            // 
            this.Scorelabel1.AutoSize = true;
            this.Scorelabel1.BackColor = System.Drawing.Color.Red;
            this.Scorelabel1.ForeColor = System.Drawing.Color.White;
            this.Scorelabel1.Location = new System.Drawing.Point(119, 609);
            this.Scorelabel1.Name = "Scorelabel1";
            this.Scorelabel1.Size = new System.Drawing.Size(13, 13);
            this.Scorelabel1.TabIndex = 0;
            this.Scorelabel1.Text = "0";
            // 
            // fireTimer
            // 
            this.fireTimer.Enabled = true;
            this.fireTimer.Interval = 2000;
            this.fireTimer.Tick += new System.EventHandler(this.fireTimer_Tick);
            // 
            // playerHealthLabel
            // 
            playerHealthLabel.AutoSize = true;
            playerHealthLabel.BackColor = System.Drawing.Color.Black;
            playerHealthLabel.ForeColor = System.Drawing.Color.White;
            playerHealthLabel.Location = new System.Drawing.Point(76, 634);
            playerHealthLabel.Name = "playerHealthLabel";
            playerHealthLabel.Size = new System.Drawing.Size(88, 13);
            playerHealthLabel.TabIndex = 3;
            playerHealthLabel.Text = "PlayerHeartsLeft:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(76, 708);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 13);
            label2.TabIndex = 5;
            label2.Text = "BossHealth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(170, 708);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Black;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(76, 683);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 13);
            label5.TabIndex = 7;
            label5.Text = "Enemy2Health:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(170, 683);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Black;
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(76, 659);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 13);
            label7.TabIndex = 9;
            label7.Text = "Enemy1Health:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(170, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(playerHealthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.Scorelabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label Scorelabel1;
        private System.Windows.Forms.Timer fireTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

