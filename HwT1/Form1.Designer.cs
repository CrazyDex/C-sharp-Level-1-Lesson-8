namespace HwT1
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
            this.PanGame = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGoodAll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnT = new System.Windows.Forms.Button();
            this.LblQ = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            this.horMenu = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmEditBase = new System.Windows.Forms.ToolStripMenuItem();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hmAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.hmHowPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.PanMenu = new System.Windows.Forms.Panel();
            this.MBContinue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MBStart = new System.Windows.Forms.Button();
            this.PanEditor = new System.Windows.Forms.Panel();
            this.editorAdd = new System.Windows.Forms.Button();
            this.editorTxt = new System.Windows.Forms.RichTextBox();
            this.editorEdit = new System.Windows.Forms.Button();
            this.editorDel = new System.Windows.Forms.Button();
            this.editorClear = new System.Windows.Forms.Button();
            this.PanGame.SuspendLayout();
            this.horMenu.SuspendLayout();
            this.PanMenu.SuspendLayout();
            this.PanEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanGame
            // 
            this.PanGame.Controls.Add(this.lblScore);
            this.PanGame.Controls.Add(this.label6);
            this.PanGame.Controls.Add(this.lblGoodAll);
            this.PanGame.Controls.Add(this.label3);
            this.PanGame.Controls.Add(this.btnT);
            this.PanGame.Controls.Add(this.LblQ);
            this.PanGame.Controls.Add(this.btnF);
            this.PanGame.Enabled = false;
            this.PanGame.Location = new System.Drawing.Point(0, 25);
            this.PanGame.Name = "PanGame";
            this.PanGame.Size = new System.Drawing.Size(300, 160);
            this.PanGame.TabIndex = 0;
            this.PanGame.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(225, 125);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 25);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(155, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Счет";
            // 
            // lblGoodAll
            // 
            this.lblGoodAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGoodAll.Location = new System.Drawing.Point(80, 125);
            this.lblGoodAll.Name = "lblGoodAll";
            this.lblGoodAll.Size = new System.Drawing.Size(65, 25);
            this.lblGoodAll.TabIndex = 4;
            this.lblGoodAll.Text = "0/0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Правильно";
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(155, 90);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(135, 25);
            this.btnT.TabIndex = 2;
            this.btnT.Text = "Правда";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // LblQ
            // 
            this.LblQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblQ.Location = new System.Drawing.Point(10, 10);
            this.LblQ.Name = "LblQ";
            this.LblQ.Size = new System.Drawing.Size(280, 70);
            this.LblQ.TabIndex = 1;
            this.LblQ.Text = "Вопросы";
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(10, 90);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(135, 25);
            this.btnF.TabIndex = 0;
            this.btnF.Text = "Ложь";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // horMenu
            // 
            this.horMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.вопросыToolStripMenuItem,
            this.инфоToolStripMenuItem});
            this.horMenu.Location = new System.Drawing.Point(0, 0);
            this.horMenu.Name = "horMenu";
            this.horMenu.Size = new System.Drawing.Size(299, 24);
            this.horMenu.TabIndex = 1;
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmMenu,
            this.hmExit});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // hmMenu
            // 
            this.hmMenu.Name = "hmMenu";
            this.hmMenu.Size = new System.Drawing.Size(152, 22);
            this.hmMenu.Text = "Меню";
            this.hmMenu.Click += new System.EventHandler(this.hmMenu_Click);
            // 
            // hmExit
            // 
            this.hmExit.Name = "hmExit";
            this.hmExit.Size = new System.Drawing.Size(152, 22);
            this.hmExit.Text = "Выход";
            this.hmExit.Click += new System.EventHandler(this.hmExit_Click);
            // 
            // вопросыToolStripMenuItem
            // 
            this.вопросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmEditBase});
            this.вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            this.вопросыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // hmEditBase
            // 
            this.hmEditBase.Name = "hmEditBase";
            this.hmEditBase.Size = new System.Drawing.Size(181, 22);
            this.hmEditBase.Text = "Редактировать базу";
            this.hmEditBase.Click += new System.EventHandler(this.hmEditBase_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hmAuthor,
            this.hmHowPlay});
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // hmAuthor
            // 
            this.hmAuthor.Name = "hmAuthor";
            this.hmAuthor.Size = new System.Drawing.Size(152, 22);
            this.hmAuthor.Text = "Автор";
            // 
            // hmHowPlay
            // 
            this.hmHowPlay.Name = "hmHowPlay";
            this.hmHowPlay.Size = new System.Drawing.Size(152, 22);
            this.hmHowPlay.Text = "Как играть?";
            // 
            // PanMenu
            // 
            this.PanMenu.Controls.Add(this.MBContinue);
            this.PanMenu.Controls.Add(this.label2);
            this.PanMenu.Controls.Add(this.MBStart);
            this.PanMenu.Location = new System.Drawing.Point(0, 25);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Size = new System.Drawing.Size(300, 160);
            this.PanMenu.TabIndex = 3;
            // 
            // MBContinue
            // 
            this.MBContinue.Enabled = false;
            this.MBContinue.Location = new System.Drawing.Point(155, 70);
            this.MBContinue.Name = "MBContinue";
            this.MBContinue.Size = new System.Drawing.Size(135, 25);
            this.MBContinue.TabIndex = 2;
            this.MBContinue.Text = "Продолжить игру";
            this.MBContinue.UseVisualStyleBackColor = true;
            this.MBContinue.Click += new System.EventHandler(this.MBContinue_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Меню";
            // 
            // MBStart
            // 
            this.MBStart.Location = new System.Drawing.Point(10, 70);
            this.MBStart.Name = "MBStart";
            this.MBStart.Size = new System.Drawing.Size(135, 25);
            this.MBStart.TabIndex = 0;
            this.MBStart.Text = "Начать игру";
            this.MBStart.UseVisualStyleBackColor = true;
            this.MBStart.Click += new System.EventHandler(this.MBStart_Click);
            // 
            // PanEditor
            // 
            this.PanEditor.Controls.Add(this.editorClear);
            this.PanEditor.Controls.Add(this.editorDel);
            this.PanEditor.Controls.Add(this.editorEdit);
            this.PanEditor.Controls.Add(this.editorTxt);
            this.PanEditor.Controls.Add(this.editorAdd);
            this.PanEditor.Enabled = false;
            this.PanEditor.Location = new System.Drawing.Point(0, 25);
            this.PanEditor.Name = "PanEditor";
            this.PanEditor.Size = new System.Drawing.Size(300, 160);
            this.PanEditor.TabIndex = 4;
            this.PanEditor.Visible = false;
            // 
            // editorAdd
            // 
            this.editorAdd.Location = new System.Drawing.Point(10, 121);
            this.editorAdd.Name = "editorAdd";
            this.editorAdd.Size = new System.Drawing.Size(65, 30);
            this.editorAdd.TabIndex = 0;
            this.editorAdd.Text = "Добавить";
            this.editorAdd.UseVisualStyleBackColor = true;
            this.editorAdd.Click += new System.EventHandler(this.editorAdd_Click);
            // 
            // editorTxt
            // 
            this.editorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorTxt.Location = new System.Drawing.Point(10, 10);
            this.editorTxt.Name = "editorTxt";
            this.editorTxt.Size = new System.Drawing.Size(280, 105);
            this.editorTxt.TabIndex = 3;
            this.editorTxt.Text = "";
            // 
            // editorEdit
            // 
            this.editorEdit.Location = new System.Drawing.Point(80, 121);
            this.editorEdit.Name = "editorEdit";
            this.editorEdit.Size = new System.Drawing.Size(69, 30);
            this.editorEdit.TabIndex = 4;
            this.editorEdit.Text = "Изменить";
            this.editorEdit.UseVisualStyleBackColor = true;
            this.editorEdit.Click += new System.EventHandler(this.editorEdit_Click);
            // 
            // editorDel
            // 
            this.editorDel.Location = new System.Drawing.Point(151, 121);
            this.editorDel.Name = "editorDel";
            this.editorDel.Size = new System.Drawing.Size(65, 30);
            this.editorDel.TabIndex = 5;
            this.editorDel.Text = "Удалить";
            this.editorDel.UseVisualStyleBackColor = true;
            this.editorDel.Click += new System.EventHandler(this.editorDel_Click);
            // 
            // editorClear
            // 
            this.editorClear.Location = new System.Drawing.Point(222, 121);
            this.editorClear.Name = "editorClear";
            this.editorClear.Size = new System.Drawing.Size(65, 30);
            this.editorClear.TabIndex = 6;
            this.editorClear.Text = "Очистить";
            this.editorClear.UseVisualStyleBackColor = true;
            this.editorClear.Click += new System.EventHandler(this.editorClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 186);
            this.Controls.Add(this.horMenu);
            this.Controls.Add(this.PanEditor);
            this.Controls.Add(this.PanMenu);
            this.Controls.Add(this.PanGame);
            this.MainMenuStrip = this.horMenu;
            this.Name = "Form1";
            this.Text = "Правда или ложь?";
            this.PanGame.ResumeLayout(false);
            this.horMenu.ResumeLayout(false);
            this.horMenu.PerformLayout();
            this.PanMenu.ResumeLayout(false);
            this.PanEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanGame;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Label LblQ;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.MenuStrip horMenu;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGoodAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hmMenu;
        private System.Windows.Forms.ToolStripMenuItem hmExit;
        private System.Windows.Forms.ToolStripMenuItem вопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hmEditBase;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hmAuthor;
        private System.Windows.Forms.ToolStripMenuItem hmHowPlay;
        private System.Windows.Forms.Panel PanMenu;
        private System.Windows.Forms.Button MBContinue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MBStart;
        private System.Windows.Forms.Panel PanEditor;
        private System.Windows.Forms.Button editorAdd;
        private System.Windows.Forms.Button editorClear;
        private System.Windows.Forms.Button editorDel;
        private System.Windows.Forms.Button editorEdit;
        private System.Windows.Forms.RichTextBox editorTxt;
    }
}

