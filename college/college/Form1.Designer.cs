namespace college
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
            this.pl_gb = new System.Windows.Forms.GroupBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.pl_answ_gb = new System.Windows.Forms.GroupBox();
            this.pl_rb_equal = new System.Windows.Forms.RadioButton();
            this.pl_rb_less = new System.Windows.Forms.RadioButton();
            this.pl_rb_grather = new System.Windows.Forms.RadioButton();
            this.pl_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pl_list = new System.Windows.Forms.ListBox();
            this.eazy_rb = new System.Windows.Forms.RadioButton();
            this.hard_rbtn = new System.Windows.Forms.RadioButton();
            this.new_game = new System.Windows.Forms.Button();
            this.cmp_gb = new System.Windows.Forms.GroupBox();
            this.cmp_answ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eazy_rbtn = new System.Windows.Forms.RadioButton();
            this.pl_wins = new System.Windows.Forms.ListBox();
            this.cmp_wins = new System.Windows.Forms.ListBox();
            this.res_gb = new System.Windows.Forms.GroupBox();
            this.pl_num_gb = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pl_gb.SuspendLayout();
            this.pl_answ_gb.SuspendLayout();
            this.cmp_gb.SuspendLayout();
            this.res_gb.SuspendLayout();
            this.pl_num_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_gb
            // 
            this.pl_gb.Controls.Add(this.pl_num_gb);
            this.pl_gb.Controls.Add(this.ok_btn);
            this.pl_gb.Controls.Add(this.pl_answ_gb);
            this.pl_gb.Controls.Add(this.label5);
            this.pl_gb.Controls.Add(this.pl_list);
            this.pl_gb.ForeColor = System.Drawing.Color.DarkKhaki;
            this.pl_gb.Location = new System.Drawing.Point(43, 12);
            this.pl_gb.Name = "pl_gb";
            this.pl_gb.Size = new System.Drawing.Size(324, 426);
            this.pl_gb.TabIndex = 0;
            this.pl_gb.TabStop = false;
            this.pl_gb.Text = "YOU";
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.ok_btn.ForeColor = System.Drawing.Color.Olive;
            this.ok_btn.Location = new System.Drawing.Point(10, 199);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(73, 37);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.UseWaitCursor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // pl_answ_gb
            // 
            this.pl_answ_gb.Controls.Add(this.pl_rb_equal);
            this.pl_answ_gb.Controls.Add(this.pl_rb_less);
            this.pl_answ_gb.Controls.Add(this.pl_rb_grather);
            this.pl_answ_gb.Location = new System.Drawing.Point(10, 97);
            this.pl_answ_gb.Name = "pl_answ_gb";
            this.pl_answ_gb.Size = new System.Drawing.Size(104, 96);
            this.pl_answ_gb.TabIndex = 5;
            this.pl_answ_gb.TabStop = false;
            this.pl_answ_gb.Text = " ";
            // 
            // pl_rb_equal
            // 
            this.pl_rb_equal.AutoSize = true;
            this.pl_rb_equal.ForeColor = System.Drawing.Color.Olive;
            this.pl_rb_equal.Location = new System.Drawing.Point(5, 19);
            this.pl_rb_equal.Name = "pl_rb_equal";
            this.pl_rb_equal.Size = new System.Drawing.Size(68, 17);
            this.pl_rb_equal.TabIndex = 1;
            this.pl_rb_equal.TabStop = true;
            this.pl_rb_equal.Text = "EQUALS";
            this.pl_rb_equal.UseVisualStyleBackColor = true;
            // 
            // pl_rb_less
            // 
            this.pl_rb_less.AutoSize = true;
            this.pl_rb_less.ForeColor = System.Drawing.Color.Olive;
            this.pl_rb_less.Location = new System.Drawing.Point(5, 65);
            this.pl_rb_less.Name = "pl_rb_less";
            this.pl_rb_less.Size = new System.Drawing.Size(52, 17);
            this.pl_rb_less.TabIndex = 1;
            this.pl_rb_less.TabStop = true;
            this.pl_rb_less.Text = "LESS";
            this.pl_rb_less.UseVisualStyleBackColor = true;
            // 
            // pl_rb_grather
            // 
            this.pl_rb_grather.AutoSize = true;
            this.pl_rb_grather.ForeColor = System.Drawing.Color.Olive;
            this.pl_rb_grather.Location = new System.Drawing.Point(5, 42);
            this.pl_rb_grather.Name = "pl_rb_grather";
            this.pl_rb_grather.Size = new System.Drawing.Size(78, 17);
            this.pl_rb_grather.TabIndex = 1;
            this.pl_rb_grather.TabStop = true;
            this.pl_rb_grather.Text = "GRATHER";
            this.pl_rb_grather.UseVisualStyleBackColor = true;
            // 
            // pl_num
            // 
            this.pl_num.BackColor = System.Drawing.Color.Gainsboro;
            this.pl_num.Location = new System.Drawing.Point(69, 12);
            this.pl_num.Name = "pl_num";
            this.pl_num.Size = new System.Drawing.Size(75, 20);
            this.pl_num.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUMBER :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "YOU";
            // 
            // pl_list
            // 
            this.pl_list.BackColor = System.Drawing.Color.Gainsboro;
            this.pl_list.ForeColor = System.Drawing.Color.Olive;
            this.pl_list.FormattingEnabled = true;
            this.pl_list.Location = new System.Drawing.Point(164, 51);
            this.pl_list.Name = "pl_list";
            this.pl_list.Size = new System.Drawing.Size(137, 342);
            this.pl_list.TabIndex = 0;
            // 
            // eazy_rb
            // 
            this.eazy_rb.Location = new System.Drawing.Point(0, 0);
            this.eazy_rb.Name = "eazy_rb";
            this.eazy_rb.Size = new System.Drawing.Size(104, 24);
            this.eazy_rb.TabIndex = 5;
            // 
            // hard_rbtn
            // 
            this.hard_rbtn.AutoSize = true;
            this.hard_rbtn.ForeColor = System.Drawing.Color.Olive;
            this.hard_rbtn.Location = new System.Drawing.Point(710, 109);
            this.hard_rbtn.Name = "hard_rbtn";
            this.hard_rbtn.Size = new System.Drawing.Size(60, 17);
            this.hard_rbtn.TabIndex = 0;
            this.hard_rbtn.Text = "hard lv.";
            this.hard_rbtn.UseVisualStyleBackColor = true;
            // 
            // new_game
            // 
            this.new_game.BackColor = System.Drawing.Color.Gainsboro;
            this.new_game.ForeColor = System.Drawing.Color.Olive;
            this.new_game.Location = new System.Drawing.Point(689, 31);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(99, 49);
            this.new_game.TabIndex = 1;
            this.new_game.Text = "NEW GAME";
            this.new_game.UseVisualStyleBackColor = false;
            this.new_game.Click += new System.EventHandler(this.new_game_Click);
            // 
            // cmp_gb
            // 
            this.cmp_gb.Controls.Add(this.cmp_answ);
            this.cmp_gb.Controls.Add(this.label4);
            this.cmp_gb.Controls.Add(this.label2);
            this.cmp_gb.Controls.Add(this.eazy_rb);
            this.cmp_gb.ForeColor = System.Drawing.Color.DarkKhaki;
            this.cmp_gb.Location = new System.Drawing.Point(407, 12);
            this.cmp_gb.Name = "cmp_gb";
            this.cmp_gb.Size = new System.Drawing.Size(157, 163);
            this.cmp_gb.TabIndex = 0;
            this.cmp_gb.TabStop = false;
            this.cmp_gb.Text = "COMPUTER";
            // 
            // cmp_answ
            // 
            this.cmp_answ.AutoSize = true;
            this.cmp_answ.ForeColor = System.Drawing.Color.Olive;
            this.cmp_answ.Location = new System.Drawing.Point(106, 55);
            this.cmp_answ.Name = "cmp_answ";
            this.cmp_answ.Size = new System.Drawing.Size(10, 13);
            this.cmp_answ.TabIndex = 3;
            this.cmp_answ.Text = " ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "COMPUTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMBER :";
            // 
            // eazy_rbtn
            // 
            this.eazy_rbtn.AutoSize = true;
            this.eazy_rbtn.Checked = true;
            this.eazy_rbtn.ForeColor = System.Drawing.Color.Olive;
            this.eazy_rbtn.Location = new System.Drawing.Point(710, 86);
            this.eazy_rbtn.Name = "eazy_rbtn";
            this.eazy_rbtn.Size = new System.Drawing.Size(61, 17);
            this.eazy_rbtn.TabIndex = 0;
            this.eazy_rbtn.TabStop = true;
            this.eazy_rbtn.Text = "eazy lv.";
            this.eazy_rbtn.UseVisualStyleBackColor = true;
            // 
            // pl_wins
            // 
            this.pl_wins.BackColor = System.Drawing.Color.Gainsboro;
            this.pl_wins.ForeColor = System.Drawing.Color.Olive;
            this.pl_wins.FormattingEnabled = true;
            this.pl_wins.Location = new System.Drawing.Point(19, 33);
            this.pl_wins.Name = "pl_wins";
            this.pl_wins.Size = new System.Drawing.Size(40, 108);
            this.pl_wins.TabIndex = 0;
            // 
            // cmp_wins
            // 
            this.cmp_wins.BackColor = System.Drawing.Color.Gainsboro;
            this.cmp_wins.ForeColor = System.Drawing.Color.Olive;
            this.cmp_wins.FormattingEnabled = true;
            this.cmp_wins.Location = new System.Drawing.Point(70, 33);
            this.cmp_wins.Name = "cmp_wins";
            this.cmp_wins.Size = new System.Drawing.Size(40, 108);
            this.cmp_wins.TabIndex = 0;
            // 
            // res_gb
            // 
            this.res_gb.Controls.Add(this.label6);
            this.res_gb.Controls.Add(this.label3);
            this.res_gb.Controls.Add(this.cmp_wins);
            this.res_gb.Controls.Add(this.pl_wins);
            this.res_gb.ForeColor = System.Drawing.Color.DarkKhaki;
            this.res_gb.Location = new System.Drawing.Point(604, 145);
            this.res_gb.Name = "res_gb";
            this.res_gb.Size = new System.Drawing.Size(145, 293);
            this.res_gb.TabIndex = 3;
            this.res_gb.TabStop = false;
            this.res_gb.Text = "RESULTS";
            // 
            // pl_num_gb
            // 
            this.pl_num_gb.Controls.Add(this.pl_num);
            this.pl_num_gb.Controls.Add(this.label1);
            this.pl_num_gb.Location = new System.Drawing.Point(9, 39);
            this.pl_num_gb.Name = "pl_num_gb";
            this.pl_num_gb.Size = new System.Drawing.Size(149, 41);
            this.pl_num_gb.TabIndex = 6;
            this.pl_num_gb.TabStop = false;
            this.pl_num_gb.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "YOU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(67, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "COMP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res_gb);
            this.Controls.Add(this.pl_gb);
            this.Controls.Add(this.cmp_gb);
            this.Controls.Add(this.new_game);
            this.Controls.Add(this.hard_rbtn);
            this.Controls.Add(this.eazy_rbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pl_gb.ResumeLayout(false);
            this.pl_answ_gb.ResumeLayout(false);
            this.pl_answ_gb.PerformLayout();
            this.cmp_gb.ResumeLayout(false);
            this.cmp_gb.PerformLayout();
            this.res_gb.ResumeLayout(false);
            this.res_gb.PerformLayout();
            this.pl_num_gb.ResumeLayout(false);
            this.pl_num_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox pl_gb;
        private System.Windows.Forms.ListBox pl_list;
        private System.Windows.Forms.RadioButton pl_rb_equal;
        private System.Windows.Forms.RadioButton pl_rb_less;
        private System.Windows.Forms.RadioButton pl_rb_grather;
        private System.Windows.Forms.RadioButton eazy_rb;
        private System.Windows.Forms.RadioButton hard_rbtn;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.GroupBox cmp_gb;
        private System.Windows.Forms.Label cmp_answ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox pl_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton eazy_rbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox pl_wins;
        private System.Windows.Forms.ListBox cmp_wins;
        private System.Windows.Forms.GroupBox pl_answ_gb;
        private System.Windows.Forms.GroupBox res_gb;
        private System.Windows.Forms.GroupBox pl_num_gb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

