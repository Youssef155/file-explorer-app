namespace FileExplorerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rightTextBox = new TextBox();
            leftTextBox = new TextBox();
            LeftArrowBtn = new Button();
            RightArrowBtn = new Button();
            BackBtn = new Button();
            CopyBtn = new Button();
            DeleteBtn = new Button();
            RightListView = new ListView();
            LeftListView = new ListView();
            SuspendLayout();
            // 
            // rightTextBox
            // 
            rightTextBox.Location = new Point(624, 29);
            rightTextBox.Name = "rightTextBox";
            rightTextBox.Size = new Size(238, 27);
            rightTextBox.TabIndex = 0;
            // 
            // leftTextBox
            // 
            leftTextBox.Location = new Point(75, 29);
            leftTextBox.Name = "leftTextBox";
            leftTextBox.Size = new Size(238, 27);
            leftTextBox.TabIndex = 1;
            // 
            // LeftArrowBtn
            // 
            LeftArrowBtn.Location = new Point(428, 182);
            LeftArrowBtn.Name = "LeftArrowBtn";
            LeftArrowBtn.Size = new Size(76, 29);
            LeftArrowBtn.TabIndex = 4;
            LeftArrowBtn.Text = "<<";
            LeftArrowBtn.UseVisualStyleBackColor = true;
            // 
            // RightArrowBtn
            // 
            RightArrowBtn.Location = new Point(428, 232);
            RightArrowBtn.Name = "RightArrowBtn";
            RightArrowBtn.Size = new Size(76, 29);
            RightArrowBtn.TabIndex = 5;
            RightArrowBtn.Text = ">>";
            RightArrowBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(709, 433);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 6;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // CopyBtn
            // 
            CopyBtn.Location = new Point(133, 433);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(94, 29);
            CopyBtn.TabIndex = 7;
            CopyBtn.Text = "Copy";
            CopyBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(428, 433);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // RightListView
            // 
            RightListView.Location = new Point(624, 86);
            RightListView.Name = "RightListView";
            RightListView.Size = new Size(238, 268);
            RightListView.TabIndex = 9;
            RightListView.UseCompatibleStateImageBehavior = false;
            RightListView.ItemActivate += RightListView_ItemActivate;
            // 
            // LeftListView
            // 
            LeftListView.Location = new Point(75, 86);
            LeftListView.Name = "LeftListView";
            LeftListView.Size = new Size(238, 268);
            LeftListView.TabIndex = 10;
            LeftListView.UseCompatibleStateImageBehavior = false;
            LeftListView.ItemActivate += LeftListView_ItemActivate_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 576);
            Controls.Add(LeftListView);
            Controls.Add(RightListView);
            Controls.Add(DeleteBtn);
            Controls.Add(CopyBtn);
            Controls.Add(BackBtn);
            Controls.Add(RightArrowBtn);
            Controls.Add(LeftArrowBtn);
            Controls.Add(leftTextBox);
            Controls.Add(rightTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rightTextBox;
        private TextBox leftTextBox;
        private Button LeftArrowBtn;
        private Button RightArrowBtn;
        private Button BackBtn;
        private Button CopyBtn;
        private Button DeleteBtn;
        private ListView RightListView;
        private ListView LeftListView;
    }
}
