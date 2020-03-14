using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Cwiczenia2
{
    [Serializable]
    public class Uczelnia
    {
        public string CreatedAt {
            get => DateTime.Now.ToString("dd.MM.yyyy");
            set { }
        }
        public string Author { get; set; }
        public List<Student> Studenci { get; set; } = new List<Student>();
    }
}
