using System.Windows.Forms;
using System.IO; // Thêm thư viện đọc file
namespace PlayFair_RSA
{
    public partial class PlayFair_RSA : Form
    {
        public PlayFair_RSA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayMatrix();
            string plaintext = textBox_PlainText.Text;
            string key = textBox_Key.Text;

            string ciphertext = EncryptPlayfair(plaintext, key);
            textBox_CypherText.Text = ciphertext;
        }


        // Khởi tạo ma trận Playfair
        private char[,] GeneratePlayfairMatrix(string key)
        {
            key = key.ToUpper().Replace("J", "I"); // Playfair thường thay J bằng I
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string matrixKey = new string(key.Distinct().ToArray()) + alphabet;
            matrixKey = new string(matrixKey.Distinct().ToArray()).Substring(0, 25);

            char[,] matrix = new char[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = matrixKey[i * 5 + j];

            return matrix;
        }

        // Hiển thị ma trận lên DataGridView
        private void DisplayMatrix(DataGridView dataGridView, char[,] matrix)
        {
            dataGridView.ColumnCount = 5;
            dataGridView.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        // Thêm phương thức gọi các hàm và hiển thị ma trận
        private void GenerateAndDisplayMatrix()
        {
            string key = textBox_Key.Text;
            char[,] matrix = GeneratePlayfairMatrix(key); // Thay YOURKEY bằng khóa thực tế
            DisplayMatrix(dataGridView1, matrix);
        }
        private string EncryptPlayfair(string plaintext, string key)
        {
            char[,] matrix = GeneratePlayfairMatrix(key);
            plaintext = plaintext.ToUpper().Replace("J", "I");

            // Chia văn bản thành từng cặp ký tự
            List<string> pairs = new List<string>();
            for (int i = 0; i < plaintext.Length; i += 2)
            {
                if (i + 1 < plaintext.Length)
                    pairs.Add(plaintext[i].ToString() + plaintext[i + 1].ToString());
                else
                    pairs.Add(plaintext[i].ToString() + "X"); // Thêm X nếu thiếu ký tự
            }

            // Thực hiện mã hóa từng cặp ký tự
            string encryptedText = "";
            foreach (string pair in pairs)
            {
                encryptedText += EncryptPair(pair[0], pair[1], matrix);
            }

            return encryptedText;
        }
        private string EncryptPair(char c1, char c2, char[,] matrix)
        {
            int row1 = 0, col1 = 0, row2 = 0, col2 = 0;

            // Xác định vị trí từng ký tự trong ma trận
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c1) { row1 = i; col1 = j; }
                    if (matrix[i, j] == c2) { row2 = i; col2 = j; }
                }
            }

            // Áp dụng quy tắc Playfair
            if (row1 == row2) // Cùng hàng
            {
                col1 = (col1 + 1) % 5;
                col2 = (col2 + 1) % 5;
            }
            else if (col1 == col2) // Cùng cột
            {
                row1 = (row1 + 1) % 5;
                row2 = (row2 + 1) % 5;
            }
            else // Khác hàng, khác cột
            {
                int temp = col1;
                col1 = col2;
                col2 = temp;
            }

            return matrix[row1, col1].ToString() + matrix[row2, col2].ToString();
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(openFileDialog.FileName);
                textBox_PlainText.Text = fileContent; // Hiển thị nội dung file vào textBox
            }
        }

        private void button_randomkey_Click(object sender, EventArgs e)
        {
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            Random rnd = new Random();

            // Xáo trộn bảng chữ cái để tạo khóa ngẫu nhiên
            string randomKey = new string(alphabet.OrderBy(c => rnd.Next()).ToArray());

            textBox_Key.Text = randomKey.Substring(0, 5); // Chỉ lấy 5 ký tự đầu làm khóa
        }
    }
}
