using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisEdu.Model
{
    public class Curso
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public string Prof { get; set; }
        public List<string> Paginas { get; set; }
    }
}
