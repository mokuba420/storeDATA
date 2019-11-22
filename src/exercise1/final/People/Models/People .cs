using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace People.Models
{
    public class People
    {
        [Table("people")]
        public class Person
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [MaxLength(250), Unique]
            public string Name { get; set; }


        }
    }
}
