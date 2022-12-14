namespace Project_generator
{
    partial class FileGenerator
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
            this.fileGenContainer = new System.Windows.Forms.TabControl();
            this.frontendPage = new System.Windows.Forms.TabPage();
            this.frontendContainer = new System.Windows.Forms.TabControl();
            this.reactPage = new System.Windows.Forms.TabPage();
            this.nextPage = new System.Windows.Forms.TabPage();
            this.backendPage = new System.Windows.Forms.TabPage();
            this.backendContainer = new System.Windows.Forms.TabControl();
            this.nodejsPage = new System.Windows.Forms.TabPage();
            this.dotnetPage = new System.Windows.Forms.TabPage();
            this.mediatorGroup = new System.Windows.Forms.GroupBox();
            this.repositoryGroup = new System.Windows.Forms.GroupBox();
            this.RepoRemoveLastBtn = new System.Windows.Forms.Button();
            this.dotnetRepoShowInstructionCheckbox = new System.Windows.Forms.CheckBox();
            this.dotnetResponseCheckbox = new System.Windows.Forms.CheckBox();
            this.repoDomainNameField = new System.Windows.Forms.TextBox();
            this.repoEntityField = new System.Windows.Forms.Label();
            this.dotnetGenerateRepoBtn = new System.Windows.Forms.Button();
            this.dotnetRepoResetBtn = new System.Windows.Forms.Button();
            this.dotnetRepoSolutionSetPathBtn = new System.Windows.Forms.Button();
            this.dotnetRepoSolutionPathField = new System.Windows.Forms.TextBox();
            this.dotnetRepoSolutionPathLabel = new System.Windows.Forms.Label();
            this.migrations = new System.Windows.Forms.TabPage();
            this.logsPage = new System.Windows.Forms.TabPage();
            this.logsField = new System.Windows.Forms.TextBox();
            this.selectSlnPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileGenContainer.SuspendLayout();
            this.frontendPage.SuspendLayout();
            this.frontendContainer.SuspendLayout();
            this.backendPage.SuspendLayout();
            this.backendContainer.SuspendLayout();
            this.dotnetPage.SuspendLayout();
            this.repositoryGroup.SuspendLayout();
            this.logsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileGenContainer
            // 
            this.fileGenContainer.Controls.Add(this.frontendPage);
            this.fileGenContainer.Controls.Add(this.backendPage);
            this.fileGenContainer.Controls.Add(this.logsPage);
            this.fileGenContainer.Location = new System.Drawing.Point(10, 9);
            this.fileGenContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileGenContainer.Name = "fileGenContainer";
            this.fileGenContainer.SelectedIndex = 0;
            this.fileGenContainer.Size = new System.Drawing.Size(916, 394);
            this.fileGenContainer.TabIndex = 0;
            // 
            // frontendPage
            // 
            this.frontendPage.Controls.Add(this.frontendContainer);
            this.frontendPage.Location = new System.Drawing.Point(4, 24);
            this.frontendPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontendPage.Name = "frontendPage";
            this.frontendPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontendPage.Size = new System.Drawing.Size(908, 366);
            this.frontendPage.TabIndex = 0;
            this.frontendPage.Text = "Front-End";
            this.frontendPage.UseVisualStyleBackColor = true;
            // 
            // frontendContainer
            // 
            this.frontendContainer.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.frontendContainer.Controls.Add(this.reactPage);
            this.frontendContainer.Controls.Add(this.nextPage);
            this.frontendContainer.Location = new System.Drawing.Point(5, 4);
            this.frontendContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontendContainer.Name = "frontendContainer";
            this.frontendContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frontendContainer.SelectedIndex = 0;
            this.frontendContainer.Size = new System.Drawing.Size(899, 360);
            this.frontendContainer.TabIndex = 0;
            // 
            // reactPage
            // 
            this.reactPage.Location = new System.Drawing.Point(4, 27);
            this.reactPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reactPage.Name = "reactPage";
            this.reactPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reactPage.Size = new System.Drawing.Size(891, 329);
            this.reactPage.TabIndex = 0;
            this.reactPage.Text = "React js";
            this.reactPage.UseVisualStyleBackColor = true;
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(4, 27);
            this.nextPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextPage.Name = "nextPage";
            this.nextPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextPage.Size = new System.Drawing.Size(891, 329);
            this.nextPage.TabIndex = 1;
            this.nextPage.Text = "Next js";
            this.nextPage.UseVisualStyleBackColor = true;
            // 
            // backendPage
            // 
            this.backendPage.Controls.Add(this.backendContainer);
            this.backendPage.Location = new System.Drawing.Point(4, 24);
            this.backendPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backendPage.Name = "backendPage";
            this.backendPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backendPage.Size = new System.Drawing.Size(908, 366);
            this.backendPage.TabIndex = 1;
            this.backendPage.Text = "Back-End";
            this.backendPage.UseVisualStyleBackColor = true;
            // 
            // backendContainer
            // 
            this.backendContainer.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.backendContainer.Controls.Add(this.nodejsPage);
            this.backendContainer.Controls.Add(this.dotnetPage);
            this.backendContainer.Controls.Add(this.migrations);
            this.backendContainer.Location = new System.Drawing.Point(5, 2);
            this.backendContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backendContainer.Name = "backendContainer";
            this.backendContainer.SelectedIndex = 0;
            this.backendContainer.Size = new System.Drawing.Size(899, 362);
            this.backendContainer.TabIndex = 0;
            // 
            // nodejsPage
            // 
            this.nodejsPage.Location = new System.Drawing.Point(4, 27);
            this.nodejsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nodejsPage.Name = "nodejsPage";
            this.nodejsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nodejsPage.Size = new System.Drawing.Size(891, 331);
            this.nodejsPage.TabIndex = 0;
            this.nodejsPage.Text = "Node js";
            this.nodejsPage.UseVisualStyleBackColor = true;
            // 
            // dotnetPage
            // 
            this.dotnetPage.Controls.Add(this.mediatorGroup);
            this.dotnetPage.Controls.Add(this.repositoryGroup);
            this.dotnetPage.Location = new System.Drawing.Point(4, 27);
            this.dotnetPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetPage.Name = "dotnetPage";
            this.dotnetPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetPage.Size = new System.Drawing.Size(891, 331);
            this.dotnetPage.TabIndex = 1;
            this.dotnetPage.Text = ".Net ";
            this.dotnetPage.UseVisualStyleBackColor = true;
            // 
            // mediatorGroup
            // 
            this.mediatorGroup.Location = new System.Drawing.Point(452, 15);
            this.mediatorGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediatorGroup.Name = "mediatorGroup";
            this.mediatorGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediatorGroup.Size = new System.Drawing.Size(416, 306);
            this.mediatorGroup.TabIndex = 1;
            this.mediatorGroup.TabStop = false;
            this.mediatorGroup.Text = "Mediator architecture file generator";
            // 
            // repositoryGroup
            // 
            this.repositoryGroup.Controls.Add(this.RepoRemoveLastBtn);
            this.repositoryGroup.Controls.Add(this.dotnetRepoShowInstructionCheckbox);
            this.repositoryGroup.Controls.Add(this.dotnetResponseCheckbox);
            this.repositoryGroup.Controls.Add(this.repoDomainNameField);
            this.repositoryGroup.Controls.Add(this.repoEntityField);
            this.repositoryGroup.Controls.Add(this.dotnetGenerateRepoBtn);
            this.repositoryGroup.Controls.Add(this.dotnetRepoResetBtn);
            this.repositoryGroup.Controls.Add(this.dotnetRepoSolutionSetPathBtn);
            this.repositoryGroup.Controls.Add(this.dotnetRepoSolutionPathField);
            this.repositoryGroup.Controls.Add(this.dotnetRepoSolutionPathLabel);
            this.repositoryGroup.Location = new System.Drawing.Point(20, 15);
            this.repositoryGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repositoryGroup.Name = "repositoryGroup";
            this.repositoryGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repositoryGroup.Size = new System.Drawing.Size(412, 306);
            this.repositoryGroup.TabIndex = 0;
            this.repositoryGroup.TabStop = false;
            this.repositoryGroup.Text = "Repository architecture file generator";
            // 
            // RepoRemoveLastBtn
            // 
            this.RepoRemoveLastBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepoRemoveLastBtn.Location = new System.Drawing.Point(13, 256);
            this.RepoRemoveLastBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepoRemoveLastBtn.Name = "RepoRemoveLastBtn";
            this.RepoRemoveLastBtn.Size = new System.Drawing.Size(187, 37);
            this.RepoRemoveLastBtn.TabIndex = 9;
            this.RepoRemoveLastBtn.Text = "Remove entity";
            this.RepoRemoveLastBtn.UseVisualStyleBackColor = true;
            this.RepoRemoveLastBtn.Click += new System.EventHandler(this.RepoRemoveLastBtn_Click);
            // 
            // dotnetRepoShowInstructionCheckbox
            // 
            this.dotnetRepoShowInstructionCheckbox.AutoSize = true;
            this.dotnetRepoShowInstructionCheckbox.Checked = true;
            this.dotnetRepoShowInstructionCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dotnetRepoShowInstructionCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetRepoShowInstructionCheckbox.Location = new System.Drawing.Point(13, 162);
            this.dotnetRepoShowInstructionCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetRepoShowInstructionCheckbox.Name = "dotnetRepoShowInstructionCheckbox";
            this.dotnetRepoShowInstructionCheckbox.Size = new System.Drawing.Size(202, 19);
            this.dotnetRepoShowInstructionCheckbox.TabIndex = 8;
            this.dotnetRepoShowInstructionCheckbox.Text = "Show instruction after generation";
            this.dotnetRepoShowInstructionCheckbox.UseVisualStyleBackColor = true;
            // 
            // dotnetResponseCheckbox
            // 
            this.dotnetResponseCheckbox.AutoSize = true;
            this.dotnetResponseCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetResponseCheckbox.Location = new System.Drawing.Point(13, 139);
            this.dotnetResponseCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetResponseCheckbox.Name = "dotnetResponseCheckbox";
            this.dotnetResponseCheckbox.Size = new System.Drawing.Size(223, 19);
            this.dotnetResponseCheckbox.TabIndex = 7;
            this.dotnetResponseCheckbox.Text = "Create a custom entity response class";
            this.dotnetResponseCheckbox.UseVisualStyleBackColor = true;
            // 
            // repoDomainNameField
            // 
            this.repoDomainNameField.Location = new System.Drawing.Point(13, 99);
            this.repoDomainNameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.repoDomainNameField.Name = "repoDomainNameField";
            this.repoDomainNameField.Size = new System.Drawing.Size(309, 23);
            this.repoDomainNameField.TabIndex = 6;
            // 
            // repoEntityField
            // 
            this.repoEntityField.AutoSize = true;
            this.repoEntityField.Location = new System.Drawing.Point(13, 82);
            this.repoEntityField.Name = "repoEntityField";
            this.repoEntityField.Size = new System.Drawing.Size(115, 15);
            this.repoEntityField.TabIndex = 5;
            this.repoEntityField.Text = "Domain Entity name";
            // 
            // dotnetGenerateRepoBtn
            // 
            this.dotnetGenerateRepoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetGenerateRepoBtn.Location = new System.Drawing.Point(206, 256);
            this.dotnetGenerateRepoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetGenerateRepoBtn.Name = "dotnetGenerateRepoBtn";
            this.dotnetGenerateRepoBtn.Size = new System.Drawing.Size(189, 37);
            this.dotnetGenerateRepoBtn.TabIndex = 4;
            this.dotnetGenerateRepoBtn.Text = "Generate files";
            this.dotnetGenerateRepoBtn.UseVisualStyleBackColor = true;
            this.dotnetGenerateRepoBtn.Click += new System.EventHandler(this.dotnetGenerateRepoBtn_Click);
            // 
            // dotnetRepoResetBtn
            // 
            this.dotnetRepoResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetRepoResetBtn.Location = new System.Drawing.Point(316, 225);
            this.dotnetRepoResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetRepoResetBtn.Name = "dotnetRepoResetBtn";
            this.dotnetRepoResetBtn.Size = new System.Drawing.Size(79, 27);
            this.dotnetRepoResetBtn.TabIndex = 3;
            this.dotnetRepoResetBtn.Text = "Reset fields";
            this.dotnetRepoResetBtn.UseVisualStyleBackColor = true;
            this.dotnetRepoResetBtn.Click += new System.EventHandler(this.dotnetRepoResetBtn_Click);
            // 
            // dotnetRepoSolutionSetPathBtn
            // 
            this.dotnetRepoSolutionSetPathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetRepoSolutionSetPathBtn.Location = new System.Drawing.Point(327, 46);
            this.dotnetRepoSolutionSetPathBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetRepoSolutionSetPathBtn.Name = "dotnetRepoSolutionSetPathBtn";
            this.dotnetRepoSolutionSetPathBtn.Size = new System.Drawing.Size(68, 22);
            this.dotnetRepoSolutionSetPathBtn.TabIndex = 2;
            this.dotnetRepoSolutionSetPathBtn.Text = "Set path";
            this.dotnetRepoSolutionSetPathBtn.UseVisualStyleBackColor = true;
            this.dotnetRepoSolutionSetPathBtn.Click += new System.EventHandler(this.dotnetRepoSolutionSetPathBtn_Click);
            // 
            // dotnetRepoSolutionPathField
            // 
            this.dotnetRepoSolutionPathField.Enabled = false;
            this.dotnetRepoSolutionPathField.Location = new System.Drawing.Point(13, 47);
            this.dotnetRepoSolutionPathField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dotnetRepoSolutionPathField.Name = "dotnetRepoSolutionPathField";
            this.dotnetRepoSolutionPathField.Size = new System.Drawing.Size(309, 23);
            this.dotnetRepoSolutionPathField.TabIndex = 1;
            // 
            // dotnetRepoSolutionPathLabel
            // 
            this.dotnetRepoSolutionPathLabel.AutoSize = true;
            this.dotnetRepoSolutionPathLabel.Location = new System.Drawing.Point(13, 30);
            this.dotnetRepoSolutionPathLabel.Name = "dotnetRepoSolutionPathLabel";
            this.dotnetRepoSolutionPathLabel.Size = new System.Drawing.Size(130, 15);
            this.dotnetRepoSolutionPathLabel.TabIndex = 0;
            this.dotnetRepoSolutionPathLabel.Text = "Path to the solution file";
            // 
            // migrations
            // 
            this.migrations.Location = new System.Drawing.Point(4, 27);
            this.migrations.Name = "migrations";
            this.migrations.Padding = new System.Windows.Forms.Padding(3);
            this.migrations.Size = new System.Drawing.Size(891, 331);
            this.migrations.TabIndex = 2;
            this.migrations.Text = "Database migrations";
            this.migrations.UseVisualStyleBackColor = true;
            // 
            // logsPage
            // 
            this.logsPage.Controls.Add(this.logsField);
            this.logsPage.Location = new System.Drawing.Point(4, 24);
            this.logsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logsPage.Name = "logsPage";
            this.logsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logsPage.Size = new System.Drawing.Size(908, 366);
            this.logsPage.TabIndex = 2;
            this.logsPage.Text = "Logs";
            this.logsPage.UseVisualStyleBackColor = true;
            // 
            // logsField
            // 
            this.logsField.BackColor = System.Drawing.SystemColors.WindowText;
            this.logsField.ForeColor = System.Drawing.SystemColors.Window;
            this.logsField.Location = new System.Drawing.Point(5, 4);
            this.logsField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logsField.Multiline = true;
            this.logsField.Name = "logsField";
            this.logsField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logsField.Size = new System.Drawing.Size(899, 401);
            this.logsField.TabIndex = 0;
            // 
            // FileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 411);
            this.Controls.Add(this.fileGenContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileGenerator";
            this.Load += new System.EventHandler(this.FileGenerator_Load);
            this.fileGenContainer.ResumeLayout(false);
            this.frontendPage.ResumeLayout(false);
            this.frontendContainer.ResumeLayout(false);
            this.backendPage.ResumeLayout(false);
            this.backendContainer.ResumeLayout(false);
            this.dotnetPage.ResumeLayout(false);
            this.repositoryGroup.ResumeLayout(false);
            this.repositoryGroup.PerformLayout();
            this.logsPage.ResumeLayout(false);
            this.logsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl fileGenContainer;
        private TabPage frontendPage;
        private TabPage backendPage;
        private TabControl frontendContainer;
        private TabPage reactPage;
        private TabPage nextPage;
        private TabControl backendContainer;
        private TabPage nodejsPage;
        private TabPage dotnetPage;
        private GroupBox repositoryGroup;
        private GroupBox mediatorGroup;
        private Button dotnetRepoSolutionSetPathBtn;
        private TextBox dotnetRepoSolutionPathField;
        private Label dotnetRepoSolutionPathLabel;
        private Button dotnetGenerateRepoBtn;
        private Button dotnetRepoResetBtn;
        private TextBox repoDomainNameField;
        private Label repoEntityField;
        private CheckBox dotnetResponseCheckbox;
        private TabPage logsPage;
        private TextBox logsField;
        private CheckBox dotnetRepoShowInstructionCheckbox;
        private OpenFileDialog selectSlnPathDialog;
        private Button RepoRemoveLastBtn;
        private TabPage migrations;
    }
}