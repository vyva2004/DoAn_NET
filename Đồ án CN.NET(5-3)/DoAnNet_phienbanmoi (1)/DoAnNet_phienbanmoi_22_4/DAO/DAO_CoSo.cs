using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_CoSo
    {
        private string _Macoso;
        private string _Tencoso;
        private string _Diachi;
        private string _Sodienthoai;
        private string _email;

        public DAO_CoSo(string macoso, string tencoso, string diachi, string sodienthoai, string email)
        {
            Macoso = macoso;
            Tencoso = tencoso;
            Diachi = diachi;
            Sodienthoai = sodienthoai;
            Email = email;
        }

        public string Macoso { get => _Macoso; set => _Macoso = value; }
        public string Tencoso { get => _Tencoso; set => _Tencoso = value; }
        public string Diachi { get => _Diachi; set => _Diachi = value; }
        public string Sodienthoai { get => _Sodienthoai; set => _Sodienthoai = value; }
        public string Email { get => _email; set => _email = value; }
        public DAO_CoSo() { }
    }
}
