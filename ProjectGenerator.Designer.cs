namespace Project_generator
{
    partial class projectGenerator
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
            this.reactGeneratorGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reactMicroFrontendArchitectureRadio = new System.Windows.Forms.RadioButton();
            this.baseArchitectureRadio = new System.Windows.Forms.RadioButton();
            this.generateReactProjectBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.setPathBtn = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.pathField = new System.Windows.Forms.TextBox();
            this.nodejsGeneratorGroup = new System.Windows.Forms.GroupBox();
            this.nodejsTypescriptCheck = new System.Windows.Forms.CheckBox();
            this.nodejsNoSqlRadio = new System.Windows.Forms.RadioButton();
            this.nodejsSqlRadio = new System.Windows.Forms.RadioButton();
            this.nodejsgenerateBtn = new System.Windows.Forms.Button();
            this.nodejsResetBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nodejsNameField = new System.Windows.Forms.TextBox();
            this.nodejsSetPathBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nodejsPathField = new System.Windows.Forms.TextBox();
            this.folderBrowserPath = new System.Windows.Forms.FolderBrowserDialog();
            this.terminalField = new System.Windows.Forms.TextBox();
            this.nextGeneratorGroup = new System.Windows.Forms.GroupBox();
            this.nextMicroFrontendArchitectureRadio = new System.Windows.Forms.RadioButton();
            this.nextBaseArchitectureRadio = new System.Windows.Forms.RadioButton();
            this.nextGenerateProjectBtn = new System.Windows.Forms.Button();
            this.nextResetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nextNameField = new System.Windows.Forms.TextBox();
            this.nextSetPathBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nextPathField = new System.Windows.Forms.TextBox();
            this.dotnetGeneratorGroup = new System.Windows.Forms.GroupBox();
            this.cqrsMediatrRadio = new System.Windows.Forms.RadioButton();
            this.cqerRepoRadio = new System.Windows.Forms.RadioButton();
            this.dotnetGenerateBtn = new System.Windows.Forms.Button();
            this.dotnetResetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dotnetNameField = new System.Windows.Forms.TextBox();
            this.dotnetSetPathBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dotnetPathField = new System.Windows.Forms.TextBox();
            this.generatorRadio = new System.Windows.Forms.RadioButton();
            this.showLogsRadio = new System.Windows.Forms.RadioButton();
            this.clearLogsBtn = new System.Windows.Forms.Button();
            this.fileGenerator = new System.Windows.Forms.Button();
            this.reactGeneratorGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.nodejsGeneratorGroup.SuspendLayout();
            this.nextGeneratorGroup.SuspendLayout();
            this.dotnetGeneratorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // reactGeneratorGroup
            // 
            this.reactGeneratorGroup.Controls.Add(this.groupBox1);
            this.reactGeneratorGroup.Controls.Add(this.reactMicroFrontendArchitectureRadio);
            this.reactGeneratorGroup.Controls.Add(this.baseArchitectureRadio);
            this.reactGeneratorGroup.Controls.Add(this.generateReactProjectBtn);
            this.reactGeneratorGroup.Controls.Add(this.resetBtn);
            this.reactGeneratorGroup.Controls.Add(this.name);
            this.reactGeneratorGroup.Controls.Add(this.nameField);
            this.reactGeneratorGroup.Controls.Add(this.setPathBtn);
            this.reactGeneratorGroup.Controls.Add(this.path);
            this.reactGeneratorGroup.Controls.Add(this.pathField);
            this.reactGeneratorGroup.Location = new System.Drawing.Point(12, 12);
            this.reactGeneratorGroup.Name = "reactGeneratorGroup";
            this.reactGeneratorGroup.Size = new System.Drawing.Size(464, 244);
            this.reactGeneratorGroup.TabIndex = 0;
            this.reactGeneratorGroup.TabStop = false;
            this.reactGeneratorGroup.Text = "React generator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 244);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Next generator";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 197);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(219, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Micro Front-End architecture";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Base architecture";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate project";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 27);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Path";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(73, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 27);
            this.textBox2.TabIndex = 0;
            // 
            // reactMicroFrontendArchitectureRadio
            // 
            this.reactMicroFrontendArchitectureRadio.AutoSize = true;
            this.reactMicroFrontendArchitectureRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reactMicroFrontendArchitectureRadio.Location = new System.Drawing.Point(18, 194);
            this.reactMicroFrontendArchitectureRadio.Name = "reactMicroFrontendArchitectureRadio";
            this.reactMicroFrontendArchitectureRadio.Size = new System.Drawing.Size(219, 24);
            this.reactMicroFrontendArchitectureRadio.TabIndex = 8;
            this.reactMicroFrontendArchitectureRadio.TabStop = true;
            this.reactMicroFrontendArchitectureRadio.Text = "Micro Front-End architecture";
            this.reactMicroFrontendArchitectureRadio.UseVisualStyleBackColor = true;
            // 
            // baseArchitectureRadio
            // 
            this.baseArchitectureRadio.AutoSize = true;
            this.baseArchitectureRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baseArchitectureRadio.Location = new System.Drawing.Point(18, 162);
            this.baseArchitectureRadio.Name = "baseArchitectureRadio";
            this.baseArchitectureRadio.Size = new System.Drawing.Size(143, 24);
            this.baseArchitectureRadio.TabIndex = 7;
            this.baseArchitectureRadio.TabStop = true;
            this.baseArchitectureRadio.Text = "Base architecture";
            this.baseArchitectureRadio.UseVisualStyleBackColor = true;
            // 
            // generateReactProjectBtn
            // 
            this.generateReactProjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateReactProjectBtn.Location = new System.Drawing.Point(281, 194);
            this.generateReactProjectBtn.Name = "generateReactProjectBtn";
            this.generateReactProjectBtn.Size = new System.Drawing.Size(163, 29);
            this.generateReactProjectBtn.TabIndex = 6;
            this.generateReactProjectBtn.Text = "Generate project";
            this.generateReactProjectBtn.UseVisualStyleBackColor = true;
            this.generateReactProjectBtn.Click += new System.EventHandler(this.generateReactProjectBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Location = new System.Drawing.Point(281, 159);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(163, 29);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(18, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 20);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(73, 65);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(291, 27);
            this.nameField.TabIndex = 3;
            // 
            // setPathBtn
            // 
            this.setPathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setPathBtn.Location = new System.Drawing.Point(370, 28);
            this.setPathBtn.Name = "setPathBtn";
            this.setPathBtn.Size = new System.Drawing.Size(74, 29);
            this.setPathBtn.TabIndex = 2;
            this.setPathBtn.Text = "Set";
            this.setPathBtn.UseVisualStyleBackColor = true;
            this.setPathBtn.Click += new System.EventHandler(this.setPathBtn_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(18, 35);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(37, 20);
            this.path.TabIndex = 1;
            this.path.Text = "Path";
            // 
            // pathField
            // 
            this.pathField.Enabled = false;
            this.pathField.Location = new System.Drawing.Point(73, 30);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(291, 27);
            this.pathField.TabIndex = 0;
            // 
            // nodejsGeneratorGroup
            // 
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsTypescriptCheck);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsNoSqlRadio);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsSqlRadio);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsgenerateBtn);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsResetBtn);
            this.nodejsGeneratorGroup.Controls.Add(this.label5);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsNameField);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsSetPathBtn);
            this.nodejsGeneratorGroup.Controls.Add(this.label6);
            this.nodejsGeneratorGroup.Controls.Add(this.nodejsPathField);
            this.nodejsGeneratorGroup.Location = new System.Drawing.Point(585, 12);
            this.nodejsGeneratorGroup.Name = "nodejsGeneratorGroup";
            this.nodejsGeneratorGroup.Size = new System.Drawing.Size(464, 244);
            this.nodejsGeneratorGroup.TabIndex = 9;
            this.nodejsGeneratorGroup.TabStop = false;
            this.nodejsGeneratorGroup.Text = "Nodejs generator";
            // 
            // nodejsTypescriptCheck
            // 
            this.nodejsTypescriptCheck.AutoSize = true;
            this.nodejsTypescriptCheck.Checked = true;
            this.nodejsTypescriptCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nodejsTypescriptCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nodejsTypescriptCheck.Location = new System.Drawing.Point(18, 194);
            this.nodejsTypescriptCheck.Name = "nodejsTypescriptCheck";
            this.nodejsTypescriptCheck.Size = new System.Drawing.Size(98, 24);
            this.nodejsTypescriptCheck.TabIndex = 9;
            this.nodejsTypescriptCheck.Text = "Typescript";
            this.nodejsTypescriptCheck.UseVisualStyleBackColor = true;
            // 
            // nodejsNoSqlRadio
            // 
            this.nodejsNoSqlRadio.AutoSize = true;
            this.nodejsNoSqlRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nodejsNoSqlRadio.Location = new System.Drawing.Point(18, 164);
            this.nodejsNoSqlRadio.Name = "nodejsNoSqlRadio";
            this.nodejsNoSqlRadio.Size = new System.Drawing.Size(80, 24);
            this.nodejsNoSqlRadio.TabIndex = 8;
            this.nodejsNoSqlRadio.TabStop = true;
            this.nodejsNoSqlRadio.Text = "No SQL";
            this.nodejsNoSqlRadio.UseVisualStyleBackColor = true;
            // 
            // nodejsSqlRadio
            // 
            this.nodejsSqlRadio.AutoSize = true;
            this.nodejsSqlRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nodejsSqlRadio.Location = new System.Drawing.Point(18, 134);
            this.nodejsSqlRadio.Name = "nodejsSqlRadio";
            this.nodejsSqlRadio.Size = new System.Drawing.Size(56, 24);
            this.nodejsSqlRadio.TabIndex = 7;
            this.nodejsSqlRadio.TabStop = true;
            this.nodejsSqlRadio.Text = "SQL";
            this.nodejsSqlRadio.UseVisualStyleBackColor = true;
            // 
            // nodejsgenerateBtn
            // 
            this.nodejsgenerateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nodejsgenerateBtn.Location = new System.Drawing.Point(281, 194);
            this.nodejsgenerateBtn.Name = "nodejsgenerateBtn";
            this.nodejsgenerateBtn.Size = new System.Drawing.Size(163, 29);
            this.nodejsgenerateBtn.TabIndex = 6;
            this.nodejsgenerateBtn.Text = "Generate project";
            this.nodejsgenerateBtn.UseVisualStyleBackColor = true;
            this.nodejsgenerateBtn.Click += new System.EventHandler(this.nodejsgenerateBtn_Click);
            // 
            // nodejsResetBtn
            // 
            this.nodejsResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nodejsResetBtn.Location = new System.Drawing.Point(281, 159);
            this.nodejsResetBtn.Name = "nodejsResetBtn";
            this.nodejsResetBtn.Size = new System.Drawing.Size(163, 29);
            this.nodejsResetBtn.TabIndex = 5;
            this.nodejsResetBtn.Text = "Reset";
            this.nodejsResetBtn.UseVisualStyleBackColor = true;
            this.nodejsResetBtn.Click += new System.EventHandler(this.nodejsResetBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // nodejsNameField
            // 
            this.nodejsNameField.Location = new System.Drawing.Point(73, 65);
            this.nodejsNameField.Name = "nodejsNameField";
            this.nodejsNameField.Size = new System.Drawing.Size(291, 27);
            this.nodejsNameField.TabIndex = 3;
            // 
            // nodejsSetPathBtn
            // 
            this.nodejsSetPathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nodejsSetPathBtn.Location = new System.Drawing.Point(370, 28);
            this.nodejsSetPathBtn.Name = "nodejsSetPathBtn";
            this.nodejsSetPathBtn.Size = new System.Drawing.Size(74, 29);
            this.nodejsSetPathBtn.TabIndex = 2;
            this.nodejsSetPathBtn.Text = "Set";
            this.nodejsSetPathBtn.UseVisualStyleBackColor = true;
            this.nodejsSetPathBtn.Click += new System.EventHandler(this.nodejsSetPathBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Path";
            // 
            // nodejsPathField
            // 
            this.nodejsPathField.Enabled = false;
            this.nodejsPathField.Location = new System.Drawing.Point(73, 30);
            this.nodejsPathField.Name = "nodejsPathField";
            this.nodejsPathField.Size = new System.Drawing.Size(291, 27);
            this.nodejsPathField.TabIndex = 0;
            // 
            // terminalField
            // 
            this.terminalField.BackColor = System.Drawing.SystemColors.Desktop;
            this.terminalField.ForeColor = System.Drawing.SystemColors.Window;
            this.terminalField.Location = new System.Drawing.Point(12, 12);
            this.terminalField.Multiline = true;
            this.terminalField.Name = "terminalField";
            this.terminalField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.terminalField.Size = new System.Drawing.Size(1037, 494);
            this.terminalField.TabIndex = 1;
            // 
            // nextGeneratorGroup
            // 
            this.nextGeneratorGroup.Controls.Add(this.nextMicroFrontendArchitectureRadio);
            this.nextGeneratorGroup.Controls.Add(this.nextBaseArchitectureRadio);
            this.nextGeneratorGroup.Controls.Add(this.nextGenerateProjectBtn);
            this.nextGeneratorGroup.Controls.Add(this.nextResetBtn);
            this.nextGeneratorGroup.Controls.Add(this.label1);
            this.nextGeneratorGroup.Controls.Add(this.nextNameField);
            this.nextGeneratorGroup.Controls.Add(this.nextSetPathBtn);
            this.nextGeneratorGroup.Controls.Add(this.label2);
            this.nextGeneratorGroup.Controls.Add(this.nextPathField);
            this.nextGeneratorGroup.Location = new System.Drawing.Point(12, 262);
            this.nextGeneratorGroup.Name = "nextGeneratorGroup";
            this.nextGeneratorGroup.Size = new System.Drawing.Size(464, 244);
            this.nextGeneratorGroup.TabIndex = 2;
            this.nextGeneratorGroup.TabStop = false;
            this.nextGeneratorGroup.Text = "Next generator";
            // 
            // nextMicroFrontendArchitectureRadio
            // 
            this.nextMicroFrontendArchitectureRadio.AutoSize = true;
            this.nextMicroFrontendArchitectureRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextMicroFrontendArchitectureRadio.Location = new System.Drawing.Point(18, 192);
            this.nextMicroFrontendArchitectureRadio.Name = "nextMicroFrontendArchitectureRadio";
            this.nextMicroFrontendArchitectureRadio.Size = new System.Drawing.Size(219, 24);
            this.nextMicroFrontendArchitectureRadio.TabIndex = 8;
            this.nextMicroFrontendArchitectureRadio.TabStop = true;
            this.nextMicroFrontendArchitectureRadio.Text = "Micro Front-End architecture";
            this.nextMicroFrontendArchitectureRadio.UseVisualStyleBackColor = true;
            // 
            // nextBaseArchitectureRadio
            // 
            this.nextBaseArchitectureRadio.AutoSize = true;
            this.nextBaseArchitectureRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBaseArchitectureRadio.Location = new System.Drawing.Point(18, 162);
            this.nextBaseArchitectureRadio.Name = "nextBaseArchitectureRadio";
            this.nextBaseArchitectureRadio.Size = new System.Drawing.Size(143, 24);
            this.nextBaseArchitectureRadio.TabIndex = 7;
            this.nextBaseArchitectureRadio.TabStop = true;
            this.nextBaseArchitectureRadio.Text = "Base architecture";
            this.nextBaseArchitectureRadio.UseVisualStyleBackColor = true;
            // 
            // nextGenerateProjectBtn
            // 
            this.nextGenerateProjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextGenerateProjectBtn.Location = new System.Drawing.Point(281, 194);
            this.nextGenerateProjectBtn.Name = "nextGenerateProjectBtn";
            this.nextGenerateProjectBtn.Size = new System.Drawing.Size(163, 29);
            this.nextGenerateProjectBtn.TabIndex = 6;
            this.nextGenerateProjectBtn.Text = "Generate project";
            this.nextGenerateProjectBtn.UseVisualStyleBackColor = true;
            this.nextGenerateProjectBtn.Click += new System.EventHandler(this.nextGenerateProjectBtn_Click);
            // 
            // nextResetBtn
            // 
            this.nextResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextResetBtn.Location = new System.Drawing.Point(281, 159);
            this.nextResetBtn.Name = "nextResetBtn";
            this.nextResetBtn.Size = new System.Drawing.Size(163, 29);
            this.nextResetBtn.TabIndex = 5;
            this.nextResetBtn.Text = "Reset";
            this.nextResetBtn.UseVisualStyleBackColor = true;
            this.nextResetBtn.Click += new System.EventHandler(this.nextResetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // nextNameField
            // 
            this.nextNameField.Location = new System.Drawing.Point(73, 65);
            this.nextNameField.Name = "nextNameField";
            this.nextNameField.Size = new System.Drawing.Size(291, 27);
            this.nextNameField.TabIndex = 3;
            // 
            // nextSetPathBtn
            // 
            this.nextSetPathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextSetPathBtn.Location = new System.Drawing.Point(370, 28);
            this.nextSetPathBtn.Name = "nextSetPathBtn";
            this.nextSetPathBtn.Size = new System.Drawing.Size(74, 29);
            this.nextSetPathBtn.TabIndex = 2;
            this.nextSetPathBtn.Text = "Set";
            this.nextSetPathBtn.UseVisualStyleBackColor = true;
            this.nextSetPathBtn.Click += new System.EventHandler(this.nextSetPathBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path";
            // 
            // nextPathField
            // 
            this.nextPathField.Enabled = false;
            this.nextPathField.Location = new System.Drawing.Point(73, 30);
            this.nextPathField.Name = "nextPathField";
            this.nextPathField.Size = new System.Drawing.Size(291, 27);
            this.nextPathField.TabIndex = 0;
            // 
            // dotnetGeneratorGroup
            // 
            this.dotnetGeneratorGroup.Controls.Add(this.cqrsMediatrRadio);
            this.dotnetGeneratorGroup.Controls.Add(this.cqerRepoRadio);
            this.dotnetGeneratorGroup.Controls.Add(this.dotnetGenerateBtn);
            this.dotnetGeneratorGroup.Controls.Add(this.dotnetResetBtn);
            this.dotnetGeneratorGroup.Controls.Add(this.label7);
            this.dotnetGeneratorGroup.Controls.Add(this.dotnetNameField);
            this.dotnetGeneratorGroup.Controls.Add(this.dotnetSetPathBtn);
            this.dotnetGeneratorGroup.Controls.Add(this.label8);
            this.dotnetGeneratorGroup.Controls.Add(this.dotnetPathField);
            this.dotnetGeneratorGroup.Location = new System.Drawing.Point(585, 262);
            this.dotnetGeneratorGroup.Name = "dotnetGeneratorGroup";
            this.dotnetGeneratorGroup.Size = new System.Drawing.Size(464, 244);
            this.dotnetGeneratorGroup.TabIndex = 9;
            this.dotnetGeneratorGroup.TabStop = false;
            this.dotnetGeneratorGroup.Text = ".Net generator";
            // 
            // cqrsMediatrRadio
            // 
            this.cqrsMediatrRadio.AutoSize = true;
            this.cqrsMediatrRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cqrsMediatrRadio.Location = new System.Drawing.Point(18, 192);
            this.cqrsMediatrRadio.Name = "cqrsMediatrRadio";
            this.cqrsMediatrRadio.Size = new System.Drawing.Size(214, 24);
            this.cqrsMediatrRadio.TabIndex = 8;
            this.cqrsMediatrRadio.TabStop = true;
            this.cqrsMediatrRadio.Text = "CQRS Mediator architecture";
            this.cqrsMediatrRadio.UseVisualStyleBackColor = true;
            // 
            // cqerRepoRadio
            // 
            this.cqerRepoRadio.AutoSize = true;
            this.cqerRepoRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cqerRepoRadio.Location = new System.Drawing.Point(18, 162);
            this.cqerRepoRadio.Name = "cqerRepoRadio";
            this.cqerRepoRadio.Size = new System.Drawing.Size(224, 24);
            this.cqerRepoRadio.TabIndex = 7;
            this.cqerRepoRadio.TabStop = true;
            this.cqerRepoRadio.Text = "CQRS Repository architecture";
            this.cqerRepoRadio.UseVisualStyleBackColor = true;
            // 
            // dotnetGenerateBtn
            // 
            this.dotnetGenerateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetGenerateBtn.Location = new System.Drawing.Point(281, 194);
            this.dotnetGenerateBtn.Name = "dotnetGenerateBtn";
            this.dotnetGenerateBtn.Size = new System.Drawing.Size(163, 29);
            this.dotnetGenerateBtn.TabIndex = 6;
            this.dotnetGenerateBtn.Text = "Generate project";
            this.dotnetGenerateBtn.UseVisualStyleBackColor = true;
            this.dotnetGenerateBtn.Click += new System.EventHandler(this.dotnetGenerateBtn_Click);
            // 
            // dotnetResetBtn
            // 
            this.dotnetResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetResetBtn.Location = new System.Drawing.Point(281, 159);
            this.dotnetResetBtn.Name = "dotnetResetBtn";
            this.dotnetResetBtn.Size = new System.Drawing.Size(163, 29);
            this.dotnetResetBtn.TabIndex = 5;
            this.dotnetResetBtn.Text = "Reset";
            this.dotnetResetBtn.UseVisualStyleBackColor = true;
            this.dotnetResetBtn.Click += new System.EventHandler(this.dotnetResetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            // 
            // dotnetNameField
            // 
            this.dotnetNameField.Location = new System.Drawing.Point(73, 65);
            this.dotnetNameField.Name = "dotnetNameField";
            this.dotnetNameField.Size = new System.Drawing.Size(291, 27);
            this.dotnetNameField.TabIndex = 3;
            // 
            // dotnetSetPathBtn
            // 
            this.dotnetSetPathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dotnetSetPathBtn.Location = new System.Drawing.Point(370, 28);
            this.dotnetSetPathBtn.Name = "dotnetSetPathBtn";
            this.dotnetSetPathBtn.Size = new System.Drawing.Size(74, 29);
            this.dotnetSetPathBtn.TabIndex = 2;
            this.dotnetSetPathBtn.Text = "Set";
            this.dotnetSetPathBtn.UseVisualStyleBackColor = true;
            this.dotnetSetPathBtn.Click += new System.EventHandler(this.dotnetSetPathBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Path";
            // 
            // dotnetPathField
            // 
            this.dotnetPathField.Enabled = false;
            this.dotnetPathField.Location = new System.Drawing.Point(73, 30);
            this.dotnetPathField.Name = "dotnetPathField";
            this.dotnetPathField.Size = new System.Drawing.Size(291, 27);
            this.dotnetPathField.TabIndex = 0;
            // 
            // generatorRadio
            // 
            this.generatorRadio.AutoSize = true;
            this.generatorRadio.Checked = true;
            this.generatorRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatorRadio.Location = new System.Drawing.Point(171, 527);
            this.generatorRadio.Name = "generatorRadio";
            this.generatorRadio.Size = new System.Drawing.Size(96, 24);
            this.generatorRadio.TabIndex = 3;
            this.generatorRadio.TabStop = true;
            this.generatorRadio.Text = "Generator";
            this.generatorRadio.UseVisualStyleBackColor = true;
            this.generatorRadio.CheckedChanged += new System.EventHandler(this.generatorRadio_CheckedChanged);
            // 
            // showLogsRadio
            // 
            this.showLogsRadio.AutoSize = true;
            this.showLogsRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showLogsRadio.Location = new System.Drawing.Point(274, 527);
            this.showLogsRadio.Name = "showLogsRadio";
            this.showLogsRadio.Size = new System.Drawing.Size(61, 24);
            this.showLogsRadio.TabIndex = 10;
            this.showLogsRadio.Text = "Logs";
            this.showLogsRadio.UseVisualStyleBackColor = true;
            this.showLogsRadio.CheckedChanged += new System.EventHandler(this.showLogsRadio_CheckedChanged);
            // 
            // clearLogsBtn
            // 
            this.clearLogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearLogsBtn.Location = new System.Drawing.Point(935, 525);
            this.clearLogsBtn.Name = "clearLogsBtn";
            this.clearLogsBtn.Size = new System.Drawing.Size(94, 29);
            this.clearLogsBtn.TabIndex = 11;
            this.clearLogsBtn.Text = "Clear logs";
            this.clearLogsBtn.UseVisualStyleBackColor = true;
            this.clearLogsBtn.Click += new System.EventHandler(this.clearLogsBtn_Click);
            // 
            // fileGenerator
            // 
            this.fileGenerator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileGenerator.Location = new System.Drawing.Point(30, 525);
            this.fileGenerator.Name = "fileGenerator";
            this.fileGenerator.Size = new System.Drawing.Size(135, 29);
            this.fileGenerator.TabIndex = 12;
            this.fileGenerator.Text = "File generator";
            this.fileGenerator.UseVisualStyleBackColor = true;
            this.fileGenerator.Click += new System.EventHandler(this.fileGenerator_Click);
            // 
            // projectGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 576);
            this.Controls.Add(this.fileGenerator);
            this.Controls.Add(this.clearLogsBtn);
            this.Controls.Add(this.reactGeneratorGroup);
            this.Controls.Add(this.showLogsRadio);
            this.Controls.Add(this.dotnetGeneratorGroup);
            this.Controls.Add(this.generatorRadio);
            this.Controls.Add(this.nodejsGeneratorGroup);
            this.Controls.Add(this.nextGeneratorGroup);
            this.Controls.Add(this.terminalField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "projectGenerator";
            this.Text = "Project generator";
            this.Load += new System.EventHandler(this.projectGenerator_Load);
            this.reactGeneratorGroup.ResumeLayout(false);
            this.reactGeneratorGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.nodejsGeneratorGroup.ResumeLayout(false);
            this.nodejsGeneratorGroup.PerformLayout();
            this.nextGeneratorGroup.ResumeLayout(false);
            this.nextGeneratorGroup.PerformLayout();
            this.dotnetGeneratorGroup.ResumeLayout(false);
            this.dotnetGeneratorGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox reactGeneratorGroup;
        private Button setPathBtn;
        private Label path;
        private TextBox pathField;
        private FolderBrowserDialog folderBrowserPath;
        private Label name;
        private TextBox nameField;
        private Button generateReactProjectBtn;
        private Button resetBtn;
        private RadioButton reactMicroFrontendArchitectureRadio;
        private RadioButton baseArchitectureRadio;
        private TextBox terminalField;
        private GroupBox nextGeneratorGroup;
        private RadioButton nextMicroFrontendArchitectureRadio;
        private RadioButton nextBaseArchitectureRadio;
        private Button nextGenerateProjectBtn;
        private Button nextResetBtn;
        private Label label1;
        private TextBox nextNameField;
        private Button nextSetPathBtn;
        private Label label2;
        private TextBox nextPathField;
        private RadioButton generatorRadio;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
        private Label label4;
        private TextBox textBox2;
        private GroupBox nodejsGeneratorGroup;
        private RadioButton nodejsNoSqlRadio;
        private RadioButton nodejsSqlRadio;
        private Button nodejsgenerateBtn;
        private Button nodejsResetBtn;
        private Label label5;
        private TextBox nodejsNameField;
        private Button nodejsSetPathBtn;
        private Label label6;
        private TextBox nodejsPathField;
        private GroupBox dotnetGeneratorGroup;
        private RadioButton cqrsMediatrRadio;
        private RadioButton cqerRepoRadio;
        private Button dotnetGenerateBtn;
        private Button dotnetResetBtn;
        private Label label7;
        private TextBox dotnetNameField;
        private Button dotnetSetPathBtn;
        private Label label8;
        private TextBox dotnetPathField;
        private RadioButton showLogsRadio;
        private CheckBox nodejsTypescriptCheck;
        private Button clearLogsBtn;
        private Button fileGenerator;
    }
}