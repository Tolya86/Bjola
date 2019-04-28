using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebBjola.Models
{
    public class Test
    {
       
        public Test(string testName)//,string test )
        {
            //this.id = 1;
            this.testName = testName;
            
        }
        
        [Key]
        public int id { get; set; }
        public string testName { get; set; }
       
    }
}
