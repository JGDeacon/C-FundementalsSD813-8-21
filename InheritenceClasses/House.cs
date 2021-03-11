using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceClasses
{
    public enum HouseType { Cottage, Duplex, Ranch, Mansion, Appartment }
    enum FlooringType { Hardwood, Carpet, VinylTile, CeramicTile}
    public class House
    {
        public int NumberOfBedRooms { get; set; }
        public int SquareFeet { get; set; }
        public bool DoesItHaveABacement { get; set; }
        public HouseType TypeOfHouse { get; set; }
        public FlooringType TypeOfFlooring { get; set; }


        public House()
        {

        }

    }
}
