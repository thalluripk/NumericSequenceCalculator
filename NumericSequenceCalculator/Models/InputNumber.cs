using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumericSequenceCalculator.Models
{
    public class InputNumber
    {
        [Required(ErrorMessage = "Please provide a valid integer number")]
        [Range(1, uint.MaxValue, ErrorMessage = "Integer Number must be greater than zero")]
        [DefaultValue(false)]
        public int Num { get; set; }
    }
}