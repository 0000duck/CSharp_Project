using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperateEngineering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //实现查询操作  （8分）
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //将查询的SQL语句传递到DatabaseHelper类的查询方法，并接受DataTable。

            //配置dataGridView
           
        }

        //实现添加操作  （4分）
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //将添加的SQL语句传递到DatabaseHelper类的相关方法




        }

        //实现修改/更新操作  （4分）
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //将修改/更新的SQL语句传递到DatabaseHelper类的相关方法



        }

        //实现删除操作  （4分）
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //将删除的SQL语句传递到DatabaseHelper类的相关方法






        }
    }
}
