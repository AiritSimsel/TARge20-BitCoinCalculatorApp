
namespace BitCoinApp
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
            this.currencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.amountOfCoinBox = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.resultLable = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currencyCombo
            // 
            this.currencyCombo.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyCombo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.currencyCombo.FormattingEnabled = true;
            this.currencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.currencyCombo.Location = new System.Drawing.Point(60, 68);
            this.currencyCombo.Name = "currencyCombo";
            this.currencyCombo.Size = new System.Drawing.Size(134, 23);
            this.currencyCombo.TabIndex = 0;
            this.currencyCombo.Text = "Select Currency";
            this.currencyCombo.SelectedIndexChanged += new System.EventHandler(this.currencyCombo_SelectedIndexChanged);
            // 
            // btnGetRates
            // 
            this.btnGetRates.Font = new System.Drawing.Font("Rubik", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetRates.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGetRates.Location = new System.Drawing.Point(214, 68);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(90, 23);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "GetRates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // amountOfCoinBox
            // 
            this.amountOfCoinBox.Location = new System.Drawing.Point(60, 145);
            this.amountOfCoinBox.Name = "amountOfCoinBox";
            this.amountOfCoinBox.Size = new System.Drawing.Size(244, 22);
            this.amountOfCoinBox.TabIndex = 2;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.AliceBlue;
            this.lable1.Location = new System.Drawing.Point(61, 125);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(155, 18);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Amount of BitCoins";
            this.lable1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultLable
            // 
            this.resultLable.AutoSize = true;
            this.resultLable.BackColor = System.Drawing.Color.Transparent;
            this.resultLable.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLable.ForeColor = System.Drawing.Color.AliceBlue;
            this.resultLable.Location = new System.Drawing.Point(57, 190);
            this.resultLable.Name = "resultLable";
            this.resultLable.Size = new System.Drawing.Size(56, 18);
            this.resultLable.TabIndex = 4;
            this.resultLable.Text = "Result";
            this.resultLable.Visible = false;
            this.resultLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(60, 211);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(244, 22);
            this.resultTextBox.TabIndex = 5;
            this.resultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLable);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.amountOfCoinBox);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.currencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox amountOfCoinBox;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label resultLable;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

