using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 实训4_3
{
    public partial class Exp4_3 : Form
    {
       
        public Exp4_3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 创建一个账户类，设计其成员变量、属性和方法
        /// </summary>
        
        public class Account {
            private int creditNo;
            private decimal balance;
            public string message;
            public Account() {
                Random r = new Random();
                creditNo = r.Next(100000,500000);//产生一个100000到500000的随机数
                balance = 100;
            }
            public decimal Balance {
                get { return this.balance; }
            }
            public int CreditNo {
                get { return this.creditNo; }
            }
            /// <summary>
            /// 设计账户类的方法
            /// </summary>
            /// <param name="money"></param>
            /// <param name="message"></param>
            /// <returns></returns>
            
            public bool WithDraw(decimal money, out string message) {
                if (money < 0)
                {
                    message = "操作失败！\n输入金额不正确!";
                    return false;
                }
                else if (balance >= money)
                {
                    balance -= money;
                    message = "操作成功!\n取款" + money + "元";
                    return true;
                }
                else
                {
                    message = "操作失败!\n余额不足!";
                    return false;
                }
            }
            public bool DepoMoney(decimal money,out string message) {
                if (money < 0)
                {
                    message = "操作失败！\n输入金额不正确！";
                    return false;
                }
                else
                {
                    balance += money;
                    message = "操作成功！\n存款" + money + "元";
                    return true;
                }
            }
        }
        /// <summary>
        /// (1)创建账户
        /// </summary>
        Account account;//定义一个账户类对象
        private void btnCreat_Click(object sender, EventArgs e)
        {
            account = new Account();//实例化储蓄卡用户账户
            lblShow.Text = "储蓄卡账户：\n" + account.CreditNo.ToString() + "\n当前余额为：\n" + account.Balance;
        }

        /// <summary>
        ///（2）取款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null)
                message = "请先创建账户!";
            else if (txtWithdraw.Text == "")
                message = "请输入取款金额!";
            else
            {
                decimal money = decimal.Parse(txtWithdraw.Text);
                account.WithDraw(money, out message);
            }
            lblShow.Text = "\n" + message + "\n";

        }

        /// <summary>
        /// (3)存款
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string message;
            if (account == null)
                message = "请先创建账户!";
            else if (txtboxSave.Text == "")
                message = "请输入存款金额!";
            else {
                decimal money = decimal.Parse(txtboxSave.Text);
                account.DepoMoney(money,out message);
            }
            lblShow.Text ="\n"+message+"\n";
        }

        /// <summary>
        /// (4)查询余额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnQuery_Click(object sender, EventArgs e)
        {
            lblShow.Text = "\n储蓄卡账户：" + account.CreditNo.ToString() + "\n当前余额为：\n" + account.Balance.ToString();
        }
        private void txtboxSave_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
