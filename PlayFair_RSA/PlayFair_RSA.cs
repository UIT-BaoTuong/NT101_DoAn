using System.Windows.Forms;
using System.IO; // Thêm thư viện đọc file
using System.Numerics;
namespace PlayFair_RSA
{
    public partial class PlayFair_RSA : Form
    {
        BigInteger p, q, n, phi, f, d;
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
        // Code giải thuật RSA :
       
        //Kiểm tra ước chung lớn nhất giữa e và phi(n)
        private bool IsPrime(BigInteger num)
        {
            if (num < 2) return false;
            for (BigInteger i = 2; i * i <= num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        private BigInteger FindPublicExponent(BigInteger phi)
        {
            BigInteger e = 17; // Cố định e = 17 để khớp với tính tay của bạn
            if (GCD1(e, phi) != 1)
            {
                e = 3; // Nếu e = 17 không thỏa mãn, quay lại tìm từ 3
                while (GCD1(e, phi) != 1)
                {
                    e++;
                }
            }
            return e;
        }
        //Tìm ước chung lớn nhất
        private BigInteger GCD1(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;
            if (m == 1) return 0;
            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }
            if (x1 < 0)
                x1 += m0;
            return x1;
        }
        //Tạo khóa từ số nguyên P , Q
        private void btnGenerateKeys_Click_1(object sender, EventArgs e)
        {
            try
            {
                p = BigInteger.Parse(txtP.Text);
                q = BigInteger.Parse(txtQ.Text);

                if (p == q)
                {
                    MessageBox.Show("p và q phải là hai số nguyên tố khác nhau.");
                    return;
                }

                if (!IsPrime(p) || !IsPrime(q))
                {
                    MessageBox.Show("p và q phải là số nguyên tố.");
                    return;
                }

                n = p * q;
                phi = (p - 1) * (q - 1);
                f = FindPublicExponent(phi);
                d = ModInverse(f, phi);

                txtPublicKey.Text = $"Public Key (e, n): ({f}, {n})";
                txtPrivateKey.Text = $"Private Key (d, n): ({d}, {n})";
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ.");
            }
        }
        //Xử lí mã hóa dữ liệu
        private void btnEncrypted_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger m = BigInteger.Parse(txtMessage.Text);

                BigInteger c = BigInteger.ModPow(m, f, n);
                txtEncrypted.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Thông điệp không hợp lệ hoặc chưa tạo khóa.");
            }
        }
        //Xử lí giải mã dữ liệu
        private void btnDecrypted_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger c = BigInteger.Parse(txtEncrypted.Text);
                if (c >= n || c < 0)
                {
                    MessageBox.Show("Bản mã phải nằm trong khoảng [0, n-1].");
                    return;
                }
                BigInteger m = BigInteger.ModPow(c, d, n);
                txtDecrypted.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Giải mã thất bại.");
            }
        }
    }
}
