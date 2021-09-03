using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public  class DTO_Lop
    {
        string maLop, tenLop;
        int soSV;

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int SoSV { get => soSV; set => soSV = value; }
    }
}
