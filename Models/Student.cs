﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfListCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public Student(int id, string name, string branch)
        {
            Id = id;
            Name = name;
            Branch = branch;
        }
    }
}
