using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solution.Infrastructure.Entitys
{
    public class TextEntity
    {
        public long Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
