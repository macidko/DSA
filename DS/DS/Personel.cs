internal partial class Program
{
    public class Personel
    {
        public int SicilNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }


        public Personel(int sicilNo, string name, string surname, decimal salary)
        {
            SicilNo = sicilNo;
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Sicil: {SicilNo,-5} Name: {Name,-10} Surname: {Surname,-15} Salary: {Salary,-10}";
        }
    }
}