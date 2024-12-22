using System.Windows.Forms;
using Tyuiu.BilousEYu.Sprint7.Project.V9.Lib;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            FormAddFile formAddFile = new FormAddFile();
            formAddFile.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string[,] data = ds.GetInfo();

            int rows = data.GetLength(0);

            dataGridViewPlaylist.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewPlaylist.Rows[i].Cells[0].Value = data[i, 1];
                dataGridViewPlaylist.Rows[i].HeaderCell.Value = i;
            }
        }

        private void dataGridViewPlaylist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string[,] data = ds.GetInfo();

                string FilePath = data[e.RowIndex, 0];

                if (File.Exists(FilePath))
                {
                    WMP.URL = FilePath;
                    textBoxFilePath.Text = FilePath;
                    textBoxName.Text = data[e.RowIndex, 1];
                    textBoxH.Text = data[e.RowIndex, 2];
                    textBoxM.Text = data[e.RowIndex, 3];
                    textBoxS.Text = data[e.RowIndex, 4];
                    textBoxDesc.Text = data[e.RowIndex, 5];
                }
                else
                {
                    MessageBox.Show("Ôàéë íå ñóùåñòâóåò", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            string[,] data = ds.GetInfo();

            int rows = data.GetLength(0);

            dataGridViewPlaylist.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                dataGridViewPlaylist.Rows[i].Cells[0].Value = data[i, 1];
                dataGridViewPlaylist.Rows[i].HeaderCell.Value = i;
            }
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.DeleteInfo(dataGridViewPlaylist.SelectedCells[0].RowIndex))
                {
                    MessageBox.Show("Ôàéë óñïåøíî óäàëåí", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    WMP.URL = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ôàéë íå áûë óäàëåí", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                string[,] data = ds.GetInfo();

                int rows = data.GetLength(0);

                dataGridViewPlaylist.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    dataGridViewPlaylist.Rows[i].Cells[0].Value = data[i, 1];
                    dataGridViewPlaylist.Rows[i].HeaderCell.Value = i;
                }
            }
            catch
            {
                MessageBox.Show("Ñïèñîê ïóñò èëè ôàéë íå âûáðàí!", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
