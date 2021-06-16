using System;

namespace FluentValidationDemo
{
    public class UserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool HasCar { get; set; }
        public string PlateNumber { get; set; }
    }
}
