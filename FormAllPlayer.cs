using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        //List<> v = new List<>();
        Player selectedPlayer;

        private Stream playerFilePath;

        public string Name 
        { 
            get; set; 
        }

        public string LastName 
        { 
            get; set; 
        }

        public FormAllPlayer()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadData()
        {
            string path = "data.txt";
            if (File.Exists(path))
            {
                List<Player> players = new List<Player>();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string name = parts[0];
                        string lastname = parts[1];
                        string id = parts[2];
                        string major = parts[3];
                        string displayname = parts[4];
                        string mail = parts[5];
                        string phone = parts[6];
                        int age = int.Parse(parts[7]);
                        Player player = new Player(name, lastname, id, major, displayname, mail, phone, age);
                        players.Add(player);
                    }
                }
                dataGridView1.DataSource = players;
            }
        }

        private void SaveData()
        {
            string path = "data.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) //µ√«® Õ∫«Ë“‰¡Ë„™Ë·∂«„À¡Ë
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

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK) 
            {
                Player newPlayer = formInfo.getPlayer();
                //Add new Player to List
                this.listPlayer.Add(newPlayer);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                //Add list to Datagrid view
                formInfo.Close();
            }
        }


        // ‡´ø‰ø≈Ï
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save data from list to CSV file
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
        

        // ‡ª‘¥‰ø≈Ï
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
                this.dataGridView1.DataSource = players;
            }
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void FormAllPlayer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string lastname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                Name = name;
                LastName = lastname;

                this.Close();

            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }
    }
}
