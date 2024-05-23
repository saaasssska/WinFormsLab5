using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsLab5
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int y = 600;
        public string rot = "forward";
        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\fedye\\source\\repos\\WinFormsLab5\\DBLab5.accdb");
        OleDbDataAdapter adapter = new OleDbDataAdapter();


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.FormClosed += MyClosedHandler;
            getDatas();
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
                string query = "DELETE FROM Car"; // Change TRUNCATE to DELETE
                OleDbCommand command = new OleDbCommand(query, myConn);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn != null && myConn.State == System.Data.ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                forwardButton(sender, e);
            }
            else if (e.KeyCode == Keys.A)
            {
                leftButton(sender, e);
            }
            else if (e.KeyCode == Keys.D)
            {
                rightButton(sender, e);
            }
            else if (e.KeyCode == Keys.S)
            {
                backButton(sender, e);
            }
        }

        private void forwardButton(object sender, EventArgs e)
        {
            if (!checkWall(x, y - 5))
            {
                return;
            }
            y -= 5;
            pictureBox1.Location = new Point(x, y);
            insertData();
            rotare("forward");
        }

        private void leftButton(object sender, EventArgs e)
        {
            if (!checkWall(x - 5, y))
            {
                return;
            }
            x -= 5;
            pictureBox1.Location = new Point(x, y);
            insertData();
            rotare("left");
        }

        private void rightButton(object sender, EventArgs e)
        {
            if (!checkWall(x + 5, y))
            {
                return;
            }
            x += 5;
            pictureBox1.Location = new Point(x, y);
            insertData();
            rotare("right");
        }

        private void backButton(object sender, EventArgs e)
        {
            if (!checkWall(x, y + 5))
            {
                return;
            }
            y += 5;
            pictureBox1.Location = new Point(x, y);
            insertData();
            rotare("back");
        }

        private bool checkWall(int x1, int y1)
        {
            if (x1 < 0 || y1 > 600)
            {
                MessageBox.Show("Вы врезались");
                return false;
            }
            else if (x1 > 800 || y1 < 0)
            {
                MessageBox.Show("Вы врезались");
                return false;
            }
            return true;
        }

        private void getDatas()
        {
            string query = "SELECT * FROM Car";
            OleDbCommand command = new OleDbCommand(query, myConn);
            adapter.SelectCommand = command;
            getInfo();
        }

        private void insertData()
        {
            myConn.Open();
            string query = "INSERT INTO Car (x, y) VALUES (?, ?)";
            OleDbCommand command = new OleDbCommand(query, myConn);
            command.Parameters.AddWithValue("?", x);
            command.Parameters.AddWithValue("?", y);
            command.ExecuteNonQuery();
            myConn.Close();
            getDatas();
        }

        private void clearDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void getInfo()
        {
            myConn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            clearDataGridView();
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            myConn.Close();
        }

        private void rotare(string r)
        {
            if (r == rot)
            {
                return;
            }

            Image img = pictureBox1.Image;

            if (rot == "forward")
            {
                if (r == "right")
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (r == "left")
                {
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (r == "back")
                {
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
            }
            else if (rot == "right")
            {
                if (r == "forward")
                {
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (r == "left")
                {
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (r == "back")
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
            }
            else if (rot == "left")
            {
                if (r == "forward")
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                else if (r == "right")
                {
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (r == "back")
                {
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
            }
            else if (rot == "back")
            {
                if (r == "forward")
                {
                    img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                else if (r == "right")
                {
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (r == "left")
                {
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
            }

            pictureBox1.Image = img;
            rot = r;
        }

        private void ExportDataToTextFile(string filePath)
        {
            try
            {
                myConn.Open();
                string query = "SELECT * FROM Car";
                OleDbCommand command = new OleDbCommand(query, myConn);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Открытие файла в режиме создания или перезаписи для его очистки
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string line = string.Join(",", row.ItemArray);
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show("Данные успешно экспортированы в " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (myConn != null && myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\fedye\source\repos\WinFormsLab5\output.txt";
            ExportDataToTextFile(filePath);
        }
    }
}
