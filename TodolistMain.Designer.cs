
namespace Todolist
{
    partial class TodolistMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load_todolist = new System.Windows.Forms.Button();
            this.todolist_grid_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.todolist_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load_todolist
            // 
            this.btn_load_todolist.Location = new System.Drawing.Point(12, 415);
            this.btn_load_todolist.Name = "btn_load_todolist";
            this.btn_load_todolist.Size = new System.Drawing.Size(181, 23);
            this.btn_load_todolist.TabIndex = 0;
            this.btn_load_todolist.Text = "Load Todo List";
            this.btn_load_todolist.UseVisualStyleBackColor = true;
            this.btn_load_todolist.Click += new System.EventHandler(this.button1_Click);
            // 
            // todolist_grid_view
            // 
            this.todolist_grid_view.AllowUserToAddRows = false;
            this.todolist_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todolist_grid_view.Location = new System.Drawing.Point(12, 24);
            this.todolist_grid_view.Name = "todolist_grid_view";
            this.todolist_grid_view.RowTemplate.Height = 23;
            this.todolist_grid_view.Size = new System.Drawing.Size(776, 385);
            this.todolist_grid_view.TabIndex = 1;
            this.todolist_grid_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todolist_grid_view_CellContentClick);
            // 
            // TodolistMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.todolist_grid_view);
            this.Controls.Add(this.btn_load_todolist);
            this.Name = "TodolistMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.todolist_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load_todolist;
        private System.Windows.Forms.DataGridView todolist_grid_view;
    }
}

