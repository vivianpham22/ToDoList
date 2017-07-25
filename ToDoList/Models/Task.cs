﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }
        public string Descripton { get; set; }
        public bool IsDone { get; set; }
        public DateTime DueDate { get; set; }


        [ForeignKey("List")]
        public int ListID { get; set; }
        public virtual List List { get; set; }

    }
}