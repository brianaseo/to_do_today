using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Todolist
{

    public partial class TodolistMain : Form
    {
        public TodolistMain()
        {
            InitializeComponent();

            todolist_grid_view.Columns.Clear();

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Finished";
            checkBoxColumn.Name = "checkBoxColumn";

            todolist_grid_view.RowHeadersVisible = false;

            todolist_grid_view.Columns.Add(checkBoxColumn);
            todolist_grid_view.Columns.Add("todo", "To do");

            List<Todo> todoList = new List<Todo>();
            loadTodoListFromFile(todoList, "..\\..\\data\\todolist_data.txt");
        }

        void loadTodoListFromFile(List<Todo> todoList, string filePath)
        {
            try
            {
                // 파일에서 한 줄씩 읽어와서 파싱하여 Todo 객체 생성
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('/');
                        if (parts.Length == 2)
                        {
                            string todoItem = parts[0];
                            bool finished;
                            bool.TryParse(parts[1], out finished);
                            Todo todo = new Todo(todoItem, finished);
                            todoList.Add(todo);

                            /*
                             finished 여부 대신, 체크박스를 넣음.
                             */
                        }
                    }
                }

                // DataGridView에 데이터 출력
                foreach (Todo todo in todoList)
                {
                    // DataGridView에 행 추가
                    int rowIndex = todolist_grid_view.Rows.Add();
                    // DataGridView의 체크박스에 값 설정
                    todolist_grid_view.Rows[rowIndex].Cells["checkBoxColumn"].Value = todo.Finished;
                    // DataGridView의 할 일 컬럼에 값 설정
                    todolist_grid_view.Rows[rowIndex].Cells["todo"].Value = todo.TodoItem;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        /*
         * function: button1_click
            버튼을 누르면 todolist가 기록된 파일을 읽어와 표출한다.
            추후 db방식으로 변경.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //btn_load_todolist.Text = "clicked";

            

        }

        private void todolist_grid_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


    class Todo
    {
        public string TodoItem { get; set; }
        public bool Finished { get; set; }

        public Todo(string todoItem, bool finished)
        {
            TodoItem = todoItem;
            Finished = finished;
        }
    }

}
