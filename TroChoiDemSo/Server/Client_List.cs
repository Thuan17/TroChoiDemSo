using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Client_List
    {


        public string Name { get; set; }


        public int Diem { get; set; }

        // Constructor để khởi tạo một đối tượng Person
        public Client_List(string name, int diem)
        {
            Name = name;
            Diem = diem;

        }


        public Client_List()
        { }



    }
}
