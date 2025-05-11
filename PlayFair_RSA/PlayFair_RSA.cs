namespace PlayFair_RSA
{
    public partial class PlayFair_RSA : Form
    {
        public PlayFair_RSA()
        {
            InitializeComponent();
            CreatePlayfairSquare();
        }
        private void CreatePlayfairSquare()
        {
            char[,] playfairSquare = {
                {'G', 'R', 'A', 'V', 'I'},
                {'T', 'Y', 'F', 'L', 'S'},
                {'B', 'C', 'D', 'E', 'H'},
                {'K', 'M', 'N', 'O', 'P'},
                {'Q', 'U', 'W', 'X', 'Z'}
            };

            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = playfairSquare[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
