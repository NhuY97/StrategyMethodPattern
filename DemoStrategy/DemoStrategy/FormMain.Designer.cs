namespace DemoStrategy
{
    partial class FormMain
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
            this.lbTitleApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbCurrencyName = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.pbEUR = new System.Windows.Forms.PictureBox();
            this.pbJPY = new System.Windows.Forms.PictureBox();
            this.pbUSD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJPY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSD)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleApp
            // 
            this.lbTitleApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitleApp.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitleApp.Location = new System.Drawing.Point(2, 9);
            this.lbTitleApp.Name = "lbTitleApp";
            this.lbTitleApp.Size = new System.Drawing.Size(629, 50);
            this.lbTitleApp.TabIndex = 0;
            this.lbTitleApp.Text = "Demo Strategy Method Pattern - Group 12";
            this.lbTitleApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "CURRENCY CONVERTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Navy;
            this.txtInput.Location = new System.Drawing.Point(45, 330);
            this.txtInput.MaxLength = 20;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(446, 30);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lbCurrencyName
            // 
            this.lbCurrencyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCurrencyName.AutoSize = true;
            this.lbCurrencyName.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrencyName.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrencyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCurrencyName.Location = new System.Drawing.Point(497, 333);
            this.lbCurrencyName.Name = "lbCurrencyName";
            this.lbCurrencyName.Size = new System.Drawing.Size(93, 26);
            this.lbCurrencyName.TabIndex = 4;
            this.lbCurrencyName.Text = "Euro/EUR";
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbResult.Location = new System.Drawing.Point(43, 460);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(549, 106);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "0";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEUR
            // 
            this.pbEUR.BackColor = System.Drawing.Color.Transparent;
            this.pbEUR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEUR.Image = global::DemoStrategy.Properties.Resources.eur;
            this.pbEUR.Location = new System.Drawing.Point(49, 183);
            this.pbEUR.Name = "pbEUR";
            this.pbEUR.Size = new System.Drawing.Size(101, 71);
            this.pbEUR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEUR.TabIndex = 6;
            this.pbEUR.TabStop = false;
            this.pbEUR.Click += new System.EventHandler(this.pbEUR_Click);
            // 
            // pbJPY
            // 
            this.pbJPY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbJPY.BackColor = System.Drawing.Color.Transparent;
            this.pbJPY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbJPY.Image = global::DemoStrategy.Properties.Resources.jpy_64;
            this.pbJPY.Location = new System.Drawing.Point(214, 183);
            this.pbJPY.Name = "pbJPY";
            this.pbJPY.Size = new System.Drawing.Size(229, 71);
            this.pbJPY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJPY.TabIndex = 7;
            this.pbJPY.TabStop = false;
            this.pbJPY.Click += new System.EventHandler(this.pbJPY_Click);
            // 
            // pbUSD
            // 
            this.pbUSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUSD.BackColor = System.Drawing.Color.Transparent;
            this.pbUSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUSD.Image = global::DemoStrategy.Properties.Resources.usd;
            this.pbUSD.Location = new System.Drawing.Point(502, 183);
            this.pbUSD.Name = "pbUSD";
            this.pbUSD.Size = new System.Drawing.Size(101, 71);
            this.pbUSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUSD.TabIndex = 8;
            this.pbUSD.TabStop = false;
            this.pbUSD.Click += new System.EventHandler(this.pbUSD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DemoStrategy.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 592);
            this.Controls.Add(this.pbUSD);
            this.Controls.Add(this.pbJPY);
            this.Controls.Add(this.pbEUR);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbCurrencyName);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitleApp);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Strategy";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJPY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbCurrencyName;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox pbEUR;
        private System.Windows.Forms.PictureBox pbJPY;
        private System.Windows.Forms.PictureBox pbUSD;
    }
}

