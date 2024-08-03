﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfListCRUD.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public Professor(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
