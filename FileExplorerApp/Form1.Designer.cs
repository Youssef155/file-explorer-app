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
            rightTextBox.BackColor = Color.DimGray;
            rightTextBox.BorderStyle = BorderStyle.FixedSingle;
            rightTextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            rightTextBox.ForeColor = Color.White;
            rightTextBox.Location = new Point(815, 29);
            rightTextBox.Name = "rightTextBox";
            rightTextBox.Size = new Size(593, 30);
            rightTextBox.TabIndex = 0;
            // 
            // leftTextBox
            // 
            leftTextBox.BackColor = Color.DimGray;
            leftTextBox.BorderStyle = BorderStyle.FixedSingle;
            leftTextBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            leftTextBox.ForeColor = Color.White;
            leftTextBox.Location = new Point(94, 29);
            leftTextBox.Name = "leftTextBox";
            leftTextBox.Size = new Size(614, 30);
            leftTextBox.TabIndex = 1;
            // 
            // LeftArrowBtn
            // 
            LeftArrowBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LeftArrowBtn.BackColor = Color.FromArgb(163, 151, 12);
            LeftArrowBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftArrowBtn.ForeColor = SystemColors.ButtonFace;
            LeftArrowBtn.Location = new Point(730, 271);
            LeftArrowBtn.Name = "LeftArrowBtn";
            LeftArrowBtn.Size = new Size(58, 48);
            LeftArrowBtn.TabIndex = 4;
            LeftArrowBtn.Text = "<<";
            LeftArrowBtn.UseVisualStyleBackColor = false;
            LeftArrowBtn.Click += LeftArrowBtn_Click;
            // 
            // RightArrowBtn
            // 
            RightArrowBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RightArrowBtn.BackColor = Color.FromArgb(163, 151, 12);
            RightArrowBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RightArrowBtn.ForeColor = SystemColors.ButtonFace;
            RightArrowBtn.Location = new Point(730, 352);
            RightArrowBtn.Name = "RightArrowBtn";
            RightArrowBtn.Size = new Size(58, 48);
            RightArrowBtn.TabIndex = 5;
            RightArrowBtn.Text = ">>";
            RightArrowBtn.UseVisualStyleBackColor = false;
            RightArrowBtn.Click += RightArrowBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BackBtn.BackColor = Color.FromArgb(163, 151, 12);
            BackBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BackBtn.ForeColor = SystemColors.ButtonFace;
            BackBtn.Location = new Point(1222, 540);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(130, 45);
            BackBtn.TabIndex = 6;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // CopyBtn
            // 
            CopyBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CopyBtn.BackColor = Color.FromArgb(163, 151, 12);
            CopyBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            CopyBtn.ForeColor = SystemColors.ButtonFace;
            CopyBtn.Location = new Point(178, 540);
            CopyBtn.Name = "CopyBtn";
            CopyBtn.Size = new Size(130, 45);
            CopyBtn.TabIndex = 7;
            CopyBtn.Text = "Copy";
            CopyBtn.UseVisualStyleBackColor = false;
            CopyBtn.Click += CopyBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom;
            DeleteBtn.BackColor = Color.FromArgb(163, 151, 12);
            DeleteBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DeleteBtn.ForeColor = SystemColors.ButtonFace;
            DeleteBtn.Location = new Point(713, 540);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(130, 45);
            DeleteBtn.TabIndex = 8;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // RightListView
            // 
            RightListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RightListView.BackColor = Color.DimGray;
            RightListView.BorderStyle = BorderStyle.FixedSingle;
            RightListView.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            RightListView.ForeColor = Color.White;
            RightListView.Location = new Point(815, 86);
            RightListView.Name = "RightListView";
            RightListView.Size = new Size(593, 431);
            RightListView.TabIndex = 9;
            RightListView.UseCompatibleStateImageBehavior = false;
            RightListView.ItemActivate += listView_ItemActivate;
            // 
            // LeftListView
            // 
            LeftListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LeftListView.BackColor = Color.DimGray;
            LeftListView.BorderStyle = BorderStyle.FixedSingle;
            LeftListView.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            LeftListView.ForeColor = Color.White;
            LeftListView.Location = new Point(94, 97);
            LeftListView.Name = "LeftListView";
            LeftListView.Size = new Size(614, 420);
            LeftListView.TabIndex = 10;
            LeftListView.UseCompatibleStateImageBehavior = false;
            LeftListView.ItemActivate += listView_ItemActivate;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 0, 64);
            ClientSize = new Size(1505, 597);
            Controls.Add(LeftListView);
            Controls.Add(RightListView);
            Controls.Add(DeleteBtn);
            Controls.Add(CopyBtn);
            Controls.Add(BackBtn);
            Controls.Add(RightArrowBtn);
            Controls.Add(LeftArrowBtn);
            Controls.Add(leftTextBox);
            Controls.Add(rightTextBox);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Disk Tool";
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
