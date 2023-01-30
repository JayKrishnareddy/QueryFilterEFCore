using System.ComponentModel.DataAnnotations;

namespace QueryFilterEFCore
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long ContactNo { get; set; }
        public bool IsActive { get; set; }
    }
}
