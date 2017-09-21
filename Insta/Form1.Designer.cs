namespace Insta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountPublication = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subscribers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountFolow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортЭкспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безвозвратноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сТАРТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1201, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 455);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip2;
            this.treeView1.Location = new System.Drawing.Point(6, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(192, 445);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.переименоватьToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(162, 70);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Login,
            this.Pass,
            this.Proxy,
            this.CountPublication,
            this.Subscribers,
            this.CountFolow,
            this.Task,
            this.State,
            this.WorkState,
            this.UserStatus,
            this.Comments});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(968, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 10;
            // 
            // Login
            // 
            this.Login.HeaderText = "Логин";
            this.Login.Name = "Login";
            // 
            // Pass
            // 
            this.Pass.HeaderText = "Пароль";
            this.Pass.Name = "Pass";
            // 
            // Proxy
            // 
            this.Proxy.HeaderText = "Прокси";
            this.Proxy.Name = "Proxy";
            // 
            // CountPublication
            // 
            this.CountPublication.HeaderText = "Публикаций";
            this.CountPublication.Name = "CountPublication";
            // 
            // Subscribers
            // 
            this.Subscribers.HeaderText = "Подписок";
            this.Subscribers.Name = "Subscribers";
            // 
            // CountFolow
            // 
            this.CountFolow.HeaderText = "Подписчиков";
            this.CountFolow.Name = "CountFolow";
            // 
            // Task
            // 
            this.Task.HeaderText = "Задание";
            this.Task.Name = "Task";
            // 
            // State
            // 
            this.State.HeaderText = "Состояние";
            this.State.Name = "State";
            // 
            // WorkState
            // 
            this.WorkState.HeaderText = "Статус Выполнения";
            this.WorkState.Name = "WorkState";
            // 
            // UserStatus
            // 
            this.UserStatus.HeaderText = "Статус";
            this.UserStatus.Name = "UserStatus";
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Комментарий";
            this.Comments.Name = "Comments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.добавитьUserToolStripMenuItem,
            this.добавитьВГруппуToolStripMenuItem,
            this.импортЭкспортToolStripMenuItem,
            this.удалитьToolStripMenuItem1,
            this.проверитьToolStripMenuItem,
            this.сТАРТToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 180);
            // 
            // добавитьUserToolStripMenuItem
            // 
            this.добавитьUserToolStripMenuItem.Name = "добавитьUserToolStripMenuItem";
            this.добавитьUserToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьUserToolStripMenuItem.Text = "Добавить User";
            this.добавитьUserToolStripMenuItem.Click += new System.EventHandler(this.добавитьUserToolStripMenuItem_Click);
            // 
            // добавитьВГруппуToolStripMenuItem
            // 
            this.добавитьВГруппуToolStripMenuItem.Name = "добавитьВГруппуToolStripMenuItem";
            this.добавитьВГруппуToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьВГруппуToolStripMenuItem.Text = "Добавить в Группу";
            this.добавитьВГруппуToolStripMenuItem.MouseHover += new System.EventHandler(this.добавитьВГруппуToolStripMenuItem_MouseHover);
            // 
            // импортЭкспортToolStripMenuItem
            // 
            this.импортЭкспортToolStripMenuItem.Name = "импортЭкспортToolStripMenuItem";
            this.импортЭкспортToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.импортЭкспортToolStripMenuItem.Text = "Импорт/Экспорт Аккаунтов";
            this.импортЭкспортToolStripMenuItem.Click += new System.EventHandler(this.импортЭкспортToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сГруппыToolStripMenuItem,
            this.безвозвратноToolStripMenuItem});
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // сГруппыToolStripMenuItem
            // 
            this.сГруппыToolStripMenuItem.Name = "сГруппыToolStripMenuItem";
            this.сГруппыToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.сГруппыToolStripMenuItem.Text = "С группы";
            this.сГруппыToolStripMenuItem.Click += new System.EventHandler(this.сГруппыToolStripMenuItem_Click);
            // 
            // безвозвратноToolStripMenuItem
            // 
            this.безвозвратноToolStripMenuItem.Name = "безвозвратноToolStripMenuItem";
            this.безвозвратноToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.безвозвратноToolStripMenuItem.Text = "Безвозвратно";
            this.безвозвратноToolStripMenuItem.Click += new System.EventHandler(this.безвозвратноToolStripMenuItem_Click);
            // 
            // проверитьToolStripMenuItem
            // 
            this.проверитьToolStripMenuItem.Name = "проверитьToolStripMenuItem";
            this.проверитьToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.проверитьToolStripMenuItem.Text = "Проверить";
            this.проверитьToolStripMenuItem.Click += new System.EventHandler(this.проверитьToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1193, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1181, 471);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.toolStripMenuItem1.Text = "СТАРТ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // сТАРТToolStripMenuItem
            // 
            this.сТАРТToolStripMenuItem.Name = "сТАРТToolStripMenuItem";
            this.сТАРТToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.сТАРТToolStripMenuItem.Text = "СТАРТ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьUserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountPublication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subscribers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountFolow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkState;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem добавитьВГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортЭкспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безвозвратноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверитьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сТАРТToolStripMenuItem;
    }
}

