using System;

namespace LINQ
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"{Id} | {FirstName} {LastName} | {City} | {BirthDate.ToShortDateString()} | {Salary}";
            
        }
    }
}
