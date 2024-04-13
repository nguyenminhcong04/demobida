using System.Text.RegularExpressions;



namespace QL_DV_Bida
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em.@"^[a-zA-Z0-9_]{3,20}@gmail.com(.vn|)$");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tentk = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            string xnmatkhau = txtxacnhanmatkhau.Text;
            string email = txtemail.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nh?p tên tài kho?n dài 6-24 ký t?, v?i các ký t? ch? và s?, ch?u hoa và ch? th??ng! "); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nh?p tên m?t kh?u dài 6-24 ký t?, v?i các ký t? ch? và s?, ch?u hoa và ch? th??ng! "); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nh?n m?t kh?u chính xác!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nh?p ?úng ??nh d?ng email!"); return; }
            if ((modify.TaiKhoans("select * from TaiKhoan where email = '" + email + "'").Count != 0) { MessageBox.Show("Email này ?ã ???c ??ng ký, vui lòng ??ng ký email khác"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email"')";
                modify.Command(query);
                if (MessageBox.Show("??ng ký thành công! B?n óc mu?n ??ng nh?p luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài kho?n này ?ã ???c ??ng ký!, vui lòng ??ng ký tên tài kho?n khác!");
            }


        }

        private void btndangky_Click(object sender, EventArgs e)
        {

        }
    }
}
