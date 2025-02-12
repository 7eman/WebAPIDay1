namespace consumer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            course_dgv = new DataGridView();
            txt_name = new TextBox();
            txt_desc = new TextBox();
            txt_duration = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)course_dgv).BeginInit();
            SuspendLayout();
            // 
            // course_dgv
            // 
            course_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            course_dgv.Location = new Point(171, 242);
            course_dgv.Name = "course_dgv";
            course_dgv.Size = new Size(442, 165);
            course_dgv.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(642, 42);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 1;
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(642, 97);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(100, 23);
            txt_desc.TabIndex = 2;
            // 
            // txt_duration
            // 
            txt_duration.Location = new Point(642, 158);
            txt_duration.Name = "txt_duration";
            txt_duration.Size = new Size(100, 23);
            txt_duration.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(534, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(534, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 166);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = "Duration";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(332, 113);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_duration);
            Controls.Add(txt_desc);
            Controls.Add(txt_name);
            Controls.Add(course_dgv);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)course_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView course_dgv;
        private TextBox txt_name;
        private TextBox txt_desc;
        private TextBox txt_duration;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_add;
    }
}
