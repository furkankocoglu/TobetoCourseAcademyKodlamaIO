﻿using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } 
        public int InstructorId { get; set; }
        public string Name { get; set; }


        public string Title { get; set; }
        //public string  Description { get; set; }
        //public int Price { get; set; }
        //public string ImageUrl { get; set; }

    }
}
