using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DTO
{
    class DoDocDTO
    {
        private string MaDoc { set; get; }
        private string MucDoDoc { set; get; }
        private string LuuY { set; get; }


        public DoDocDTO() { }
        public DoDocDTO(string MaDoc,string MucDoDoc,string LuuY)
        {
            this.MaDoc = MaDoc;
            this.MucDoDoc = MucDoDoc;
            this.LuuY = LuuY;
        }
        public DoDocDTO(DoDocDTO d)
        {
            MaDoc = d.MaDoc;
            MucDoDoc = d.MucDoDoc;
            LuuY = d.LuuY;
            
        }

        

    }
}
