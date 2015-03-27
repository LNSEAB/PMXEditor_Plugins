namespace MakeJoints
{
    partial class MakeJointsForm
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
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BodyListBox = new System.Windows.Forms.ListBox();
            this.AppliedBodyListBox = new System.Windows.Forms.ListBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.ApplyAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BodyListBox
            // 
            this.BodyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BodyListBox.FormattingEnabled = true;
            this.BodyListBox.ItemHeight = 12;
            this.BodyListBox.Location = new System.Drawing.Point(14, 24);
            this.BodyListBox.Name = "BodyListBox";
            this.BodyListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.BodyListBox.Size = new System.Drawing.Size(147, 388);
            this.BodyListBox.TabIndex = 0;
            // 
            // AppliedBodyListBox
            // 
            this.AppliedBodyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppliedBodyListBox.FormattingEnabled = true;
            this.AppliedBodyListBox.ItemHeight = 12;
            this.AppliedBodyListBox.Location = new System.Drawing.Point(199, 24);
            this.AppliedBodyListBox.Name = "AppliedBodyListBox";
            this.AppliedBodyListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.AppliedBodyListBox.Size = new System.Drawing.Size(147, 388);
            this.AppliedBodyListBox.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(167, 150);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(26, 23);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = ">>";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(167, 200);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(26, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "<<";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "剛体";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "適用する剛体";
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Location = new System.Drawing.Point(238, 418);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllButton.TabIndex = 6;
            this.RemoveAllButton.Text = "全解除";
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // ApplyAllButton
            // 
            this.ApplyAllButton.Location = new System.Drawing.Point(50, 418);
            this.ApplyAllButton.Name = "ApplyAllButton";
            this.ApplyAllButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyAllButton.TabIndex = 7;
            this.ApplyAllButton.Text = "全て適用";
            this.ApplyAllButton.UseVisualStyleBackColor = true;
            this.ApplyAllButton.Click += new System.EventHandler(this.ApplyAllButton_Click);
            // 
            // MakeJointsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 460);
            this.Controls.Add(this.ApplyAllButton);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.AppliedBodyListBox);
            this.Controls.Add(this.BodyListBox);
            this.MaximizeBox = false;
            this.Name = "MakeJointsForm";
            this.Text = "ジョイント生成";
            this.Activated += new System.EventHandler(this.MakeJointsForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MakeJointsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BodyListBox;
        private System.Windows.Forms.ListBox AppliedBodyListBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveAllButton;
        private System.Windows.Forms.Button ApplyAllButton;
    }
}