using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace college
{
    public partial class Form1 : Form
    {
        private bool turn = true;
        private int rnd_num;
        private int my_num = -1;
        private Random rnd = new Random();
        private bool lvl = true; // true - eazy/ false - hard
        private int start = -1, end = -1;
        private List<bool> ls_nums = Enumerable.Repeat(false, 101).ToList<bool>();
        private int ls_nums_count = 0;
        public Form1()
        {
            InitializeComponent();
            pl_gb.Visible = false;
            cmp_gb.Visible = false;
        }

        
        private void eazy()
        {
            
            if (turn) {
                int num;
                if (pl_num.Text.Length == 0 || !int.TryParse(pl_num.Text, out num) || num > 100 || num < 0)
                {
                    MessageBox.Show("Input Number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pl_num.Text = "";
                    return;
                }
                else
                {
                    if (num > my_num)
                    {
                        pl_list.Items.Add("X < " + num.ToString());
                        MessageBox.Show("X < " + num.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (num < my_num)
                    {
                        pl_list.Items.Add("X > " + num.ToString());
                        MessageBox.Show("X > " + num.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        end_game(true);
                        pl_list.Items.Clear();
                        return;
                    }
                    pl_num_gb.Visible = false;
                    pl_num.Text = "";
                    pl_answ_gb.Visible = true;


                    if (ls_nums_count == 101)
                        end_game();
                    do
                    {
                        rnd_num = rnd.Next(0, 101);
                    } while (ls_nums[rnd_num]);
                    ++ls_nums_count;
                    cmp_answ.Text = rnd_num.ToString();

                }
                turn = false;
            }
            else
            {
                if (pl_rb_equal.Checked)
                {
                    end_game();
                    pl_rb_equal.Checked = false;
                }
                else
                {
                    ls_nums[rnd_num] = true;
                    if (pl_rb_grather.Checked)
                        pl_rb_grather.Checked = false;
                    else
                        pl_rb_less.Checked = false;
                }
                turn = true;
                pl_answ_gb.Visible = false;
                cmp_answ.Text = "";
                pl_num_gb.Visible = true;
            }
            
        }
        private void hard() {
            if (turn)
            {
                if(start == -1)
                    start = 0; end = 100;
                int num;
                if (pl_num.Text.Length == 0 || !int.TryParse(pl_num.Text, out num) || num > 100 || num < 0)
                {
                    MessageBox.Show("Input Number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pl_num.Text = "";
                    return;
                }
                else
                {
                    if (num > my_num)
                    {
                        MessageBox.Show("X < " + num.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (num < my_num)
                    {
                        MessageBox.Show("X > " + num.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        end_game(true);
                        pl_list.Items.Clear();
                        return;
                    }
                    pl_num.Text = "";
                    if (start != end)
                    {
                        rnd_num = (start + end) / 2;
                    }
                    else
                    {
                        end_game();
                    }
                    cmp_answ.Text = rnd_num.ToString();
                    pl_answ_gb.Visible = true;
                    pl_num_gb.Visible = false;
                    turn = false;
                }
               
            }
            else
            {
                if (pl_rb_equal.Checked)
                {
                    end_game();
                    pl_rb_equal.Checked = false;
                }
                else
                {
                    if (pl_rb_grather.Checked)
                    {
                        start = rnd_num + 1;
                        pl_rb_grather.Checked = false;
                    }
                    else
                    {
                        end = rnd_num - 1;
                        pl_rb_less.Checked = false;
                    }
                }
                turn = true;
                pl_answ_gb.Visible = false;
                pl_num_gb.Visible = true;
                cmp_answ.Text = "";
            }



            
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (lvl)
                eazy();
            else
                hard();
        }
        private void end_game(bool pl_win = false)
        {
            
            if(pl_win)
            {
                pl_wins.Items.Add(1);
                cmp_wins.Items.Add(0);
            }
            else
            {
                pl_wins.Items.Add(0);
                cmp_wins.Items.Add(1);
            }
            ls_nums_count = 0;
            ls_nums = Enumerable.Repeat(false, 101).ToList<bool>();
            pl_list.Visible = false;
            rnd_num = rnd.Next(0, 101);
             
            start = end = -1;
            pl_list.Visible = false;
            rnd_num = 50;
            

            pl_gb.Visible = false;
            cmp_gb.Visible = false;
            pl_list.Items.Clear();
            pl_num.Text = "";
            cmp_answ.Text = "";
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            pl_gb.Visible = true;
            cmp_gb.Visible = true;
            pl_num_gb.Visible = true;
            pl_answ_gb.Visible = false;
            turn = true;
            if (eazy_rbtn.Checked)
            {
                if (start!=-1 || pl_list.Items.Count !=0)
                {
                    
                    if (ls_nums_count != 0)
                        end_game();
                    else
                        end_game(true);
                }
                lvl = true;
                pl_list.Visible = true;

            }
            else
            {
                if (start != -1 || pl_list.Items.Count != 0)
                {
                    if (start == -1)
                        end_game(true);
                    else
                        end_game();
                }
                lvl = false;
                pl_list.Visible = false;
            }
            my_num = rnd.Next(0, 101);
            MessageBox.Show(my_num.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
