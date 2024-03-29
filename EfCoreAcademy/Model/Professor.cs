﻿namespace EfCoreAcademy.Model
{
    public class Professor : BaseEntity
    {
        public string FirsName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public List<Class> Classes { get; set; } = default!;
        public Address Address { get; set; } = default!;
    }
}