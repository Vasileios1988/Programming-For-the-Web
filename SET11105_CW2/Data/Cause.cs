using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SET11105_CW2.Models
{
    public class Cause

    {
        // attributes of the cause class with getter and setters
        public int ID { get; set; }

        [MaxLength(50)]
        public string subject { get; set; }

      
        [DataType(DataType.MultilineText)]
        public string description { get; set; }

        public int numOfSignatures { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime timeOfPublish { get; set; }


        public Cause()
        {

        }


    }
}
