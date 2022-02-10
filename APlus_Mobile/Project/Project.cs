using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace APlus_Mobile
{

    [Table("Projects")]
    public class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
