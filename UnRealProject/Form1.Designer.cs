namespace UnRealProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFam = new System.Windows.Forms.TextBox();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxOtch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmBxCourse = new System.Windows.Forms.ComboBox();
            this.cmBxFaculty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBxOOP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxPhisics = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxMath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownGroup = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxPathSave = new System.Windows.Forms.TextBox();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPred = new System.Windows.Forms.Button();
            this.btnSaveObject = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.chckBxRepeat = new System.Windows.Forms.CheckBox();
            this.chckBxAutoSave = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("makeToolStripMenuItem.Image")));
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.makeToolStripMenuItem.Text = "Make";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.makeToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripMenuItem.Image")));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // txtBxFam
            // 
            this.txtBxFam.BackColor = System.Drawing.SystemColors.Window;
            this.txtBxFam.Enabled = false;
            this.txtBxFam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxFam.Location = new System.Drawing.Point(99, 31);
            this.txtBxFam.Name = "txtBxFam";
            this.txtBxFam.Size = new System.Drawing.Size(192, 20);
            this.txtBxFam.TabIndex = 3;
            this.txtBxFam.Leave += new System.EventHandler(this.txtBxFam_Leave);
            // 
            // txtBxName
            // 
            this.txtBxName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBxName.Enabled = false;
            this.txtBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxName.Location = new System.Drawing.Point(99, 64);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(192, 20);
            this.txtBxName.TabIndex = 4;
            this.txtBxName.Leave += new System.EventHandler(this.txtBxName_Leave);
            // 
            // txtBxOtch
            // 
            this.txtBxOtch.BackColor = System.Drawing.SystemColors.Window;
            this.txtBxOtch.Enabled = false;
            this.txtBxOtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxOtch.Location = new System.Drawing.Point(99, 97);
            this.txtBxOtch.Name = "txtBxOtch";
            this.txtBxOtch.Size = new System.Drawing.Size(192, 20);
            this.txtBxOtch.TabIndex = 5;
            this.txtBxOtch.Leave += new System.EventHandler(this.txtBxOtch_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // cmBxCourse
            // 
            this.cmBxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxCourse.Enabled = false;
            this.cmBxCourse.FormattingEnabled = true;
            this.cmBxCourse.Items.AddRange(new object[] {
            "Курс 1",
            "Курс 2",
            "Курс 3",
            "Курс 4"});
            this.cmBxCourse.Location = new System.Drawing.Point(24, 154);
            this.cmBxCourse.Name = "cmBxCourse";
            this.cmBxCourse.Size = new System.Drawing.Size(121, 21);
            this.cmBxCourse.TabIndex = 8;
            this.cmBxCourse.Leave += new System.EventHandler(this.cmBxCourse_Leave);
            // 
            // cmBxFaculty
            // 
            this.cmBxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBxFaculty.Enabled = false;
            this.cmBxFaculty.FormattingEnabled = true;
            this.cmBxFaculty.Items.AddRange(new object[] {
            "ФММТ",
            "НТФ",
            "ХТФ",
            "ФАИТ",
            "ЭТФ",
            "ФПП",
            "ИЭФ",
            "ФГЛ",
            "ЗЭ",
            "ФДДО",
            "ФПК",
            "ВК"});
            this.cmBxFaculty.Location = new System.Drawing.Point(24, 201);
            this.cmBxFaculty.Name = "cmBxFaculty";
            this.cmBxFaculty.Size = new System.Drawing.Size(121, 21);
            this.cmBxFaculty.TabIndex = 9;
            this.cmBxFaculty.Leave += new System.EventHandler(this.cmBxFaculty_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Факультет";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBxOOP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBxPhisics);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBxMath);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(179, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 129);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оценки";
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // txtBxOOP
            // 
            this.txtBxOOP.Location = new System.Drawing.Point(109, 93);
            this.txtBxOOP.Name = "txtBxOOP";
            this.txtBxOOP.Size = new System.Drawing.Size(100, 20);
            this.txtBxOOP.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "ООП";
            // 
            // txtBxPhisics
            // 
            this.txtBxPhisics.Location = new System.Drawing.Point(109, 61);
            this.txtBxPhisics.Name = "txtBxPhisics";
            this.txtBxPhisics.Size = new System.Drawing.Size(100, 20);
            this.txtBxPhisics.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Физика";
            // 
            // txtBxMath
            // 
            this.txtBxMath.Location = new System.Drawing.Point(109, 30);
            this.txtBxMath.Name = "txtBxMath";
            this.txtBxMath.Size = new System.Drawing.Size(100, 20);
            this.txtBxMath.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Математика";
            // 
            // numericUpDownGroup
            // 
            this.numericUpDownGroup.Enabled = false;
            this.numericUpDownGroup.Location = new System.Drawing.Point(24, 247);
            this.numericUpDownGroup.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGroup.Name = "numericUpDownGroup";
            this.numericUpDownGroup.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownGroup.TabIndex = 15;
            this.numericUpDownGroup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGroup.Leave += new System.EventHandler(this.numericUpDownGroup_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Курс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Группа";
            // 
            // txtBxPathSave
            // 
            this.txtBxPathSave.Location = new System.Drawing.Point(204, 323);
            this.txtBxPathSave.Name = "txtBxPathSave";
            this.txtBxPathSave.ReadOnly = true;
            this.txtBxPathSave.Size = new System.Drawing.Size(245, 20);
            this.txtBxPathSave.TabIndex = 16;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Location = new System.Drawing.Point(466, 321);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(36, 23);
            this.btnSaveFolder.TabIndex = 17;
            this.btnSaveFolder.Text = "...";
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Путь сохранения";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(157, 387);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPred
            // 
            this.btnPred.Location = new System.Drawing.Point(46, 387);
            this.btnPred.Name = "btnPred";
            this.btnPred.Size = new System.Drawing.Size(75, 23);
            this.btnPred.TabIndex = 20;
            this.btnPred.Text = "<<";
            this.btnPred.Click += new System.EventHandler(this.btnPred_Click);
            // 
            // btnSaveObject
            // 
            this.btnSaveObject.Location = new System.Drawing.Point(403, 31);
            this.btnSaveObject.Name = "btnSaveObject";
            this.btnSaveObject.Size = new System.Drawing.Size(100, 43);
            this.btnSaveObject.TabIndex = 21;
            this.btnSaveObject.Text = "Сохранить объект";
            this.btnSaveObject.Click += new System.EventHandler(this.btnSaveObject_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(297, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 43);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Новый";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "0/0";
            // 
            // chckBxRepeat
            // 
            this.chckBxRepeat.AutoSize = true;
            this.chckBxRepeat.Location = new System.Drawing.Point(60, 293);
            this.chckBxRepeat.Name = "chckBxRepeat";
            this.chckBxRepeat.Size = new System.Drawing.Size(63, 17);
            this.chckBxRepeat.TabIndex = 24;
            this.chckBxRepeat.Text = "Повтор";
            // 
            // chckBxAutoSave
            // 
            this.chckBxAutoSave.AutoSize = true;
            this.chckBxAutoSave.Location = new System.Drawing.Point(60, 323);
            this.chckBxAutoSave.Name = "chckBxAutoSave";
            this.chckBxAutoSave.Size = new System.Drawing.Size(109, 17);
            this.chckBxAutoSave.TabIndex = 25;
            this.chckBxAutoSave.Text = "Автосохранение";
            this.chckBxAutoSave.CheckedChanged += new System.EventHandler(this.chckBxAutoSave_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.errorProvider1_RightToLeftChanged);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 467);
            this.Controls.Add(this.chckBxAutoSave);
            this.Controls.Add(this.chckBxRepeat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSaveObject);
            this.Controls.Add(this.btnPred);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSaveFolder);
            this.Controls.Add(this.txtBxPathSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxOtch);
            this.Controls.Add(this.cmBxCourse);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.cmBxFaculty);
            this.Controls.Add(this.txtBxFam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Студенческая БД";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFam;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxOtch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmBxCourse;
        private System.Windows.Forms.ComboBox cmBxFaculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownGroup;
        private System.Windows.Forms.TextBox txtBxMath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxOOP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxPhisics;
        private System.Windows.Forms.TextBox txtBxPathSave;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPred;
        private System.Windows.Forms.Button btnSaveObject;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chckBxRepeat;
        private System.Windows.Forms.CheckBox chckBxAutoSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

