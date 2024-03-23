using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LinQ_2
{
    internal class Position
    {
        public int position_id { set; get; }
        public string position_name { set; get; }
        public string position_desc { set; get; }
        
        public Position()
        {
        }

        public Position(int position_id, string position_name, string desc)
        {
            this.position_id = position_id;
            this.position_name = position_name;
            this.position_desc = desc;
        }

        public List<Position> getPositions()
        {
            return new List<Position>
            {
                new Position(1, "Truong phong", "Truong phong"),
                new Position(2, "Nhan vien", "Nhan vien")
            };
        }

        public override string ToString()
        {
            return "ID: " + position_id + " - Name: " + position_name + " - Description: " + position_desc;
        }
    }
}
