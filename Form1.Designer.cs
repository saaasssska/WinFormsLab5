using System.Windows.Forms;

namespace WinFormsLab5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RoadBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label2 = new Label();
            RoadBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RoadBox1
            // 
            RoadBox1.BackColor = Color.FromArgb(192, 255, 192);
            RoadBox1.Controls.Add(pictureBox1);
            RoadBox1.Location = new Point(23, 37);
            RoadBox1.Name = "RoadBox1";
            RoadBox1.Size = new Size(900, 700);
            RoadBox1.TabIndex = 0;
            RoadBox1.TabStop = false;
            RoadBox1.Text = "Дорога";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 255, 192);
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 600);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1053, 81);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 1;
            button1.Text = "Вперед";
            button1.UseVisualStyleBackColor = true;
            button1.Click += forwardButton;
            // 
            // button2
            // 
            button2.Location = new Point(946, 135);
            button2.Name = "button2";
            button2.Size = new Size(119, 50);
            button2.TabIndex = 2;
            button2.Text = "Влево";
            button2.UseVisualStyleBackColor = true;
            button2.Click += leftButton;
            // 
            // button3
            // 
            button3.Location = new Point(1157, 135);
            button3.Name = "button3";
            button3.Size = new Size(119, 50);
            button3.TabIndex = 3;
            button3.Text = "Вправо";
            button3.UseVisualStyleBackColor = true;
            button3.Click += rightButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(946, 37);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 4;
            label1.Text = "Кнопки управления";
            // 
            // button4
            // 
            button4.Location = new Point(1053, 191);
            button4.Name = "button4";
            button4.Size = new Size(119, 50);
            button4.TabIndex = 5;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += backButton;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(946, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(330, 404);
            dataGridView1.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(946, 694);
            button5.Name = "button5";
            button5.Size = new Size(330, 43);
            button5.TabIndex = 7;
            button5.Text = "Выгрузить в файл";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(946, 253);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 8;
            label2.Text = "Координаты";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1312, 772);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RoadBox1);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            RoadBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox RoadBox1;
        public PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
        private Label label2;
    }
}
