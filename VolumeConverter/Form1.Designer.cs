
namespace VolumeConverter
{
    partial class volumeConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volumeConverter));
            this.converterCLTitleLable = new System.Windows.Forms.Label();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clLable = new System.Windows.Forms.Label();
            this.litreLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // converterCLTitleLable
            // 
            this.converterCLTitleLable.AutoSize = true;
            this.converterCLTitleLable.Font = new System.Drawing.Font("Palatino Linotype", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterCLTitleLable.Location = new System.Drawing.Point(276, 81);
            this.converterCLTitleLable.Name = "converterCLTitleLable";
            this.converterCLTitleLable.Size = new System.Drawing.Size(626, 90);
            this.converterCLTitleLable.TabIndex = 0;
            this.converterCLTitleLable.Text = "Convert CL to Liter";
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTextBox.Location = new System.Drawing.Point(291, 341);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(279, 58);
            this.clTextBox.TabIndex = 1;
            this.clTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreTextBox.Location = new System.Drawing.Point(291, 451);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(279, 55);
            this.litreTextBox.TabIndex = 2;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.litreTextBox.TextChanged += new System.EventHandler(this.litreTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Yellow;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(291, 599);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(107, 51);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Yellow;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(463, 599);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 51);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clLable
            // 
            this.clLable.AutoSize = true;
            this.clLable.Font = new System.Drawing.Font("Palatino Linotype", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLable.Location = new System.Drawing.Point(741, 341);
            this.clLable.Name = "clLable";
            this.clLable.Size = new System.Drawing.Size(89, 63);
            this.clLable.TabIndex = 5;
            this.clLable.Text = "CL";
            // 
            // litreLable
            // 
            this.litreLable.AutoSize = true;
            this.litreLable.Font = new System.Drawing.Font("Palatino Linotype", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreLable.Location = new System.Drawing.Point(741, 451);
            this.litreLable.Name = "litreLable";
            this.litreLable.Size = new System.Drawing.Size(129, 63);
            this.litreLable.TabIndex = 6;
            this.litreLable.Text = "Liter";
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1661, 970);
            this.Controls.Add(this.litreLable);
            this.Controls.Add(this.clLable);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.converterCLTitleLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "volumeConverter";
            this.Text = "Volume Converter CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label converterCLTitleLable;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.TextBox litreTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clLable;
        private System.Windows.Forms.Label litreLable;
    }
}

