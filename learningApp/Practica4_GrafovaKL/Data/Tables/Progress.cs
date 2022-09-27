using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_GrafovaKL
{
    public class Progress
    {        
        public int Id { get; set; }

        public int IdUser { get; set; }

        public User user { get; set; }


        public string TeoryProgress { get; set; }

        public string PracticeProgress { get; set; }

        public string TestProgress { get; set; }
    }
}
