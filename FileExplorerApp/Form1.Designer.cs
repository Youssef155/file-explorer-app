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
            rightTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rightTextBox.Location = new Point(799, 29);
            rightTextBox.Name = "rightTextBox";
            rightTextBox.Size = new Size(593, 27);
            rightTextBox.TabIndex = 0;
            // 
            // leftTextBox
            // 
            leftTextBox.Location = new Point(94, 29);
            leftTextBox.Name = "leftTextBox";
            leftTextBox.Size = new Size(614, 27);
            leftTextBox.TabIndex = 1;
            // 
            // LeftArrowBtn
            // 
            LeftArrowBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LeftArrowBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftArrowBtn.Location = new Point(726, 281);
            LeftArrowBtn.Name = "LeftArrowBtn";
            LeftArrowBtn.Size = new Size(46, 48);
            LeftArrowBtn.TabIndex = 4;
            LeftArrowBtn.Text = "<<";
            LeftArrowBtn.UseVisualStyleBackColor = true;
            // 
            // RightArrowBtn
            // 
            RightArrowBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RightArrowBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RightArrowBtn.Location = new Point(730, 361);
            RightArrowBtn.Name = "RightArrowBtn";
            RightArrowBtn.Size = new Size(42, 48);
            RightArrowBtn.TabIndex = 5;
            RightArrowBtn.Text = ">>";
            RightArrowBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackBtn.Location = new Point(1206, 574);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 6;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // CopyBtn
            // 
            CopyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CopyBtn.Location = new Point(178, 574);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(94, 29);
            CopyBtn.TabIndex = 7;
            CopyBtn.Text = "Copy";
            CopyBtn.UseVisualStyleBackColor = true;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom;
            DeleteBtn.Location = new Point(705, 574);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // RightListView
            // 
            RightListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RightListView.Location = new Point(799, 86);
            RightListView.Name = "RightListView";
            RightListView.Size = new Size(593, 435);
            RightListView.TabIndex = 9;
            RightListView.UseCompatibleStateImageBehavior = false;
            RightListView.ItemActivate += RightListView_ItemActivate;
            // 
            // LeftListView
            // 
            LeftListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LeftListView.Location = new Point(94, 97);
            LeftListView.Name = "LeftListView";
            LeftListView.Size = new Size(614, 435);
            LeftListView.TabIndex = 10;
            LeftListView.UseCompatibleStateImageBehavior = false;
            LeftListView.ItemActivate += LeftListView_ItemActivate_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 615);
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
            WindowState = FormWindowState.Maximized;
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
