using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormTeamInfo : Form
    {
        List<Player> listPlayer = new List<Player>();
        public FormTeamInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer formAllPlayer = new FormAllPlayer())
            {
                formAllPlayer.ShowDialog();

                if (!string.IsNullOrEmpty(formAllPlayer.Name))
                {

                    string SLD1 = formAllPlayer.Name;
                    string SLD2 = formAllPlayer.LastName;

                    textBox1.Text = SLD1;
                    textBox6.Text = SLD2;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer formAllPlayer = new FormAllPlayer())
            {
                formAllPlayer.ShowDialog();

                if (!string.IsNullOrEmpty(formAllPlayer.Name))
                {

                    string SLD1 = formAllPlayer.Name;
                    string SLD2 = formAllPlayer.LastName;

                    textBox2.Text = SLD1;
                    textBox7.Text = SLD2;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer formAllPlayer = new FormAllPlayer())
            {
                formAllPlayer.ShowDialog();

                if (!string.IsNullOrEmpty(formAllPlayer.Name))
                {

                    string SLD1 = formAllPlayer.Name;
                    string SLD2 = formAllPlayer.LastName;

                    textBox3.Text = SLD1;
                    textBox8.Text = SLD2;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FormAllPlayer formAllPlayer = new FormAllPlayer())
            {
                formAllPlayer.ShowDialog();

                if (!string.IsNullOrEmpty(formAllPlayer.Name))
                {

                    string SLD1 = formAllPlayer.Name;
                    string SLD2 = formAllPlayer.LastName;

                    textBox4.Text = SLD1;
                    textBox9.Text = SLD2;

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using (FormAllPlayer formAllPlayer = new FormAllPlayer())
            {
                formAllPlayer.ShowDialog();

                if (!string.IsNullOrEmpty(formAllPlayer.Name))
                {

                    string SLD1 = formAllPlayer.Name;
                    string SLD2 = formAllPlayer.LastName;

                    textBox5.Text = SLD1;
                    textBox10.Text = SLD2;

                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if 
                (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text)
                || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text)
                || string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text) || string.IsNullOrWhiteSpace(textBox10.Text))

            {

                MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {   

                string[] row = new string[] { tbName.Text, textBox1.Text, textBox6.Text };
                dataGridView2.Rows.Add(row);
                string[] row2 = new string[] { tbName.Text, textBox2.Text, textBox7.Text };
                dataGridView2.Rows.Add(row2);
                string[] row3 = new string[] { tbName.Text, textBox3.Text, textBox8.Text };
                dataGridView2.Rows.Add(row3);
                string[] row4 = new string[] { tbName.Text, textBox4.Text, textBox9.Text };
                dataGridView2.Rows.Add(row4);
                string[] row5 = new string[] { tbName.Text, textBox5.Text, textBox10.Text };
                dataGridView2.Rows.Add(row5);

            }
            tbName.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT|*.txt|CSV|*.csv"; ;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                List<Player> players = new List<Player>();
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        string lastname = fields[1];
                        string studentid = fields[2];
                        string major = fields[3];
                        string displayname = fields[4];
                        string mail = fields[5];
                        string phone = fields[6];
                        int age = int.Parse(fields[7]);
                        Player player = new Player(name, lastname, studentid, major, displayname, mail, phone, age);
                        players.Add(player);
                        line = reader.ReadLine();
                    }
                }
                this.dataGridView2.DataSource = players;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Player item in listPlayer)
                    {

                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                            item.Name,
                            item.Lastname,
                            item.Id,
                            item.Major,
                            item.Displayname,
                            item.Mail,
                            item.Phone,
                            item.Age));

                    }
                }
            }
        }

        private void SaveData()
        {
            string path = "data.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow) //ตรวจสอบว่าไม่ใช่แถวใหม่
                    {

                        string name = row.Cells[0].Value.ToString();
                        string lastname = row.Cells[1].Value.ToString();
                        string id = row.Cells[2].Value.ToString();
                        string major = row.Cells[3].Value.ToString();
                        string displayname = row.Cells[4].Value.ToString();
                        string mail = row.Cells[5].Value.ToString();
                        string phone = row.Cells[6].Value.ToString();
                        int age = int.Parse(row.Cells[7].Value.ToString());
                        string line = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", name, lastname, id, major, displayname, mail, phone, age);
                        writer.WriteLine(line);

                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }
    }
}
