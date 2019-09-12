using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet3
{
    class Student
    {
        [Key]
        public int Id { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string PunoIme { get; set; }
    }
}
