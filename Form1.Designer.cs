
namespace QuaverToBG
{
    partial class QuaverToBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuaverToBG));
            this.Panel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Label();
            this.getBgButton = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panel.Controls.Add(this.title);
            this.Panel.Controls.Add(this.minimizeButton);
            this.Panel.Controls.Add(this.closeButton);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(800, 48);
            this.Panel.TabIndex = 0;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(4, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(221, 39);
            this.title.TabIndex = 2;
            this.title.Text = "QuaverToBG";
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(681, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(59, 48);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(740, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 48);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(217, 402);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(381, 39);
            this.credit.TabIndex = 1;
            this.credit.Text = "Made by Plextora#0033";
            // 
            // getBgButton
            // 
            this.getBgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.getBgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getBgButton.FlatAppearance.BorderSize = 0;
            this.getBgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getBgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBgButton.ForeColor = System.Drawing.Color.White;
            this.getBgButton.Location = new System.Drawing.Point(328, 177);
            this.getBgButton.Name = "getBgButton";
            this.getBgButton.Size = new System.Drawing.Size(148, 75);
            this.getBgButton.TabIndex = 3;
            this.getBgButton.Text = "Get BGs";
            this.getBgButton.UseVisualStyleBackColor = false;
            this.getBgButton.Click += new System.EventHandler(this.getBgButton_Click);
            // 
            // QuaverToBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getBgButton);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.Panel);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuaverToBG";
            this.Text = "1";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Button getBgButton;
    }
}

