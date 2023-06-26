using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace People.Models
{
    [SQLite.Table("people")]
    public class MC_Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [SQLite.MaxLength(250), Unique]
        public string Name { get; set; }

        public int edad { get; set; }
    }
}