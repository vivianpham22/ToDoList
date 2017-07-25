using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class List
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public DateTime CurrentDate { get; set; }

        //private DateTime _currentDate = DateTime.Now;
        //public DateTime CurrentDate { get; set; }
        //{
        //    get { return DateTime.Now; }
        //    set { _currentDate = value; }
        //}

        

    }
}