namespace Album_Collection
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
            this.albumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // albumBox
            // 
            this.albumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumBox.Location = new System.Drawing.Point(235, 36);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(215, 29);
            this.albumBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Album Information:";
            // 
            // originalLabel
            // 
            this.originalLabel.BackColor = System.Drawing.Color.White;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(38, 136);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(267, 307);
            this.originalLabel.TabIndex = 2;
            // 
            // failLabel
            // 
            this.failLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failLabel.Location = new System.Drawing.Point(0, 73);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(652, 54);
            this.failLabel.TabIndex = 4;
            this.failLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.addButton.FlatAppearance.BorderSize = 2;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(456, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 38);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.removeButton.FlatAppearance.BorderSize = 2;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(546, 32);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(93, 38);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sortedLabel
            // 
            this.sortedLabel.BackColor = System.Drawing.Color.White;
            this.sortedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedLabel.Location = new System.Drawing.Point(340, 136);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(267, 307);
            this.sortedLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(651, 473);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumBox);
            this.Name = "Form1";
            this.Text = "Album Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox albumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label sortedLabel;
    }
}

