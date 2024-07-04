using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class City : IComparable<City>
    {
        // City sınıfının özellikleri.
        public int? PlakaNo { get; set; }
        public string? Name { get; set; }

        // City sınıfının yapıcı metodu.
        public City(int? plakaNo, string? name)
        {
            PlakaNo = plakaNo ?? throw new ArgumentNullException(nameof(plakaNo));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        // City sınıfının ToString metodu.
        public override string ToString()
        {
            return $"Plaka No: {PlakaNo,5}, Şehir Adı: {Name,15}";
        }

        // City sınıfının CompareTo metodu.
        public int CompareTo(City? other)
        {
            //if (other == null) return 1;
            if (this.PlakaNo < other.PlakaNo) return -1;
            else if (this.PlakaNo == other.PlakaNo) return 0;
            else return 1;
        }
    }

}
