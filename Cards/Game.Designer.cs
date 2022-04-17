namespace Cards
{
    partial class Game
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblCurPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(32, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(818, 552);
            this.Panel1.TabIndex = 6;
            // 
            // lblCurPlayer
            // 
            this.lblCurPlayer.AutoSize = true;
            this.lblCurPlayer.Font = new System.Drawing.Font("FiraMono Nerd Font", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurPlayer.Location = new System.Drawing.Point(856, 30);
            this.lblCurPlayer.Name = "lblCurPlayer";
            this.lblCurPlayer.Size = new System.Drawing.Size(177, 27);
            this.lblCurPlayer.TabIndex = 8;
            this.lblCurPlayer.Text = "Current Player:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FiraMono Nerd Font", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(856, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Color:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(861, 116);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(161, 101);
            this.btnColor.TabIndex = 10;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("FiraMono Nerd Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(861, 223);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(161, 110);
            this.btnDraw.TabIndex = 11;
            this.btnDraw.Text = "Draw Card";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 623);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurPlayer);
            this.Controls.Add(this.Panel1);
            this.Name = "Game";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lblCurPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnDraw;
    }
}

