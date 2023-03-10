using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioInHTMLToPDF
{
    public class StructTest
    {
        public int idTest = 0;
        public string type = "";
        public string codeTypeTest = "";
        public string traceNumber = "";
        public string loteNumber = "";
        public string codeProduct = "";
        public int qtProduced = 0;
        public int qtSample = 0;
        public string standard = "";
        public string inspectionType = "";
        public int timeTest = 0;
        public DateTime created_at;
        public int turn = 0;
        public string status = "";
        public string rnc = "";
        public int idUserOperator = 0;
        public string nameUserOperator = "";
        public string dataResultTest = "";
        public float bar = 0;
        public float fallBar = 0;
        public float? sec = 0;
        public float? addBar = 0;
        public float? addSec = 0;
        public string codErro = "";
        public DateTime? realized_at;

    }



    public class ReturnStructTest
    {
        public int idTest = 0;
        public string situation = "";
        public string data = "";
    }

    public class SearchStructTest
    {
        public int? idTest;
        public string Trace;
        public string test;
        public DateTime? date_1;
        public DateTime? date_2;
        public bool? status;
    }


}
