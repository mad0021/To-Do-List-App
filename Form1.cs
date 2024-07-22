using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List_App
{
    public partial class TodoList : Form
    {
        public TodoList()
        {
            InitializeComponent();
        }

        DataTable todoList= new DataTable();

        bool isEditing = false;

        private void TodoList_Load(object sender, EventArgs e)
        {
            //Create colums
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            //Point our datagridview to our datasource

            toDoListView.DataSource = todoList;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
        }
    }
}
