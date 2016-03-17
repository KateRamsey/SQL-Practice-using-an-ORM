﻿namespace SQL_Practice_using_an_ORM
{
    public class SalesPeople
    {
        public SalesPeople()
        { }
        public SalesPeople(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Name}";
        }
    }
}