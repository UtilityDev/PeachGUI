namespace PeachGUI
{
    partial class ProjectSetup
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
            ProjectSetupLbl = new Label();
            ProjectNameLbl = new Label();
            ProjectNameTbx = new TextBox();
            ProjectDirectoryTbx = new TextBox();
            ProjectDirectoryLbl = new Label();
            ProjectTemplateLbl = new Label();
            ProjectTemplateDd = new ComboBox();
            CreateProjectBtn = new Button();
            colorDialog1 = new ColorDialog();
            DirectoryBrowseBtn = new Button();
            GoodLuckLbl = new Label();
            SuspendLayout();
            // 
            // ProjectSetupLbl
            // 
            ProjectSetupLbl.AutoSize = true;
            ProjectSetupLbl.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point);
            ProjectSetupLbl.Location = new Point(22, 19);
            ProjectSetupLbl.Name = "ProjectSetupLbl";
            ProjectSetupLbl.Size = new Size(193, 38);
            ProjectSetupLbl.TabIndex = 0;
            ProjectSetupLbl.Text = "Project Setup";
            ProjectSetupLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProjectNameLbl
            // 
            ProjectNameLbl.AutoSize = true;
            ProjectNameLbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectNameLbl.Location = new Point(25, 69);
            ProjectNameLbl.Name = "ProjectNameLbl";
            ProjectNameLbl.Size = new Size(255, 25);
            ProjectNameLbl.TabIndex = 1;
            ProjectNameLbl.Text = "Project Name (make it unique!)";
            ProjectNameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProjectNameTbx
            // 
            ProjectNameTbx.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectNameTbx.Location = new Point(30, 102);
            ProjectNameTbx.Name = "ProjectNameTbx";
            ProjectNameTbx.Size = new Size(222, 31);
            ProjectNameTbx.TabIndex = 2;
            // 
            // ProjectDirectoryTbx
            // 
            ProjectDirectoryTbx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ProjectDirectoryTbx.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectDirectoryTbx.Location = new Point(30, 293);
            ProjectDirectoryTbx.Name = "ProjectDirectoryTbx";
            ProjectDirectoryTbx.Size = new Size(222, 31);
            ProjectDirectoryTbx.TabIndex = 4;
            // 
            // ProjectDirectoryLbl
            // 
            ProjectDirectoryLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ProjectDirectoryLbl.AutoSize = true;
            ProjectDirectoryLbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectDirectoryLbl.Location = new Point(25, 261);
            ProjectDirectoryLbl.Name = "ProjectDirectoryLbl";
            ProjectDirectoryLbl.Size = new Size(143, 25);
            ProjectDirectoryLbl.TabIndex = 3;
            ProjectDirectoryLbl.Text = "Project Directory";
            ProjectDirectoryLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProjectTemplateLbl
            // 
            ProjectTemplateLbl.Anchor = AnchorStyles.Left;
            ProjectTemplateLbl.AutoSize = true;
            ProjectTemplateLbl.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectTemplateLbl.Location = new Point(25, 163);
            ProjectTemplateLbl.Name = "ProjectTemplateLbl";
            ProjectTemplateLbl.Size = new Size(142, 25);
            ProjectTemplateLbl.TabIndex = 5;
            ProjectTemplateLbl.Text = "Project Template";
            ProjectTemplateLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProjectTemplateDd
            // 
            ProjectTemplateDd.Anchor = AnchorStyles.Left;
            ProjectTemplateDd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectTemplateDd.FormattingEnabled = true;
            ProjectTemplateDd.Items.AddRange(new object[] { "C#", "C++", "C", "Python", "Kotlin", "Java", "Rust", "JavaScript", "CSS", "HTML", "F#", "Haskell", "Ruby", "Lua" });
            ProjectTemplateDd.Location = new Point(30, 196);
            ProjectTemplateDd.Name = "ProjectTemplateDd";
            ProjectTemplateDd.Size = new Size(222, 31);
            ProjectTemplateDd.TabIndex = 6;
            // 
            // CreateProjectBtn
            // 
            CreateProjectBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CreateProjectBtn.Location = new Point(286, 102);
            CreateProjectBtn.Name = "CreateProjectBtn";
            CreateProjectBtn.Size = new Size(123, 31);
            CreateProjectBtn.TabIndex = 7;
            CreateProjectBtn.Text = "Create Project!";
            CreateProjectBtn.UseVisualStyleBackColor = true;
            CreateProjectBtn.Click += CreateProjectBtn_Click;
            // 
            // DirectoryBrowseBtn
            // 
            DirectoryBrowseBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DirectoryBrowseBtn.Location = new Point(286, 293);
            DirectoryBrowseBtn.Name = "DirectoryBrowseBtn";
            DirectoryBrowseBtn.Size = new Size(123, 31);
            DirectoryBrowseBtn.TabIndex = 8;
            DirectoryBrowseBtn.Text = "Browse...";
            DirectoryBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // GoodLuckLbl
            // 
            GoodLuckLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GoodLuckLbl.AutoSize = true;
            GoodLuckLbl.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            GoodLuckLbl.Location = new Point(25, 285);
            GoodLuckLbl.Name = "GoodLuckLbl";
            GoodLuckLbl.Size = new Size(0, 30);
            GoodLuckLbl.TabIndex = 9;
            GoodLuckLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProjectSetup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 346);
            Controls.Add(GoodLuckLbl);
            Controls.Add(DirectoryBrowseBtn);
            Controls.Add(CreateProjectBtn);
            Controls.Add(ProjectTemplateDd);
            Controls.Add(ProjectTemplateLbl);
            Controls.Add(ProjectDirectoryTbx);
            Controls.Add(ProjectDirectoryLbl);
            Controls.Add(ProjectNameTbx);
            Controls.Add(ProjectNameLbl);
            Controls.Add(ProjectSetupLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProjectSetup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project Setup - Peach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProjectSetupLbl;
        private Label ProjectNameLbl;
        private TextBox ProjectNameTbx;
        private TextBox ProjectDirectoryTbx;
        private Label ProjectDirectoryLbl;
        private Label ProjectTemplateLbl;
        private ComboBox ProjectTemplateDd;
        private Button CreateProjectBtn;
        private ColorDialog colorDialog1;
        private Button DirectoryBrowseBtn;
        private Label GoodLuckLbl;
    }
}
