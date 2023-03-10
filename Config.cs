using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RelatorioInHTMLToPDF
{
    class Config
    {
        public string MainColor { get; set; }
        public string Manufacturer { get; set; }
        public string PathBaseReport { get; set; }
        public string PathTemplateReport { get; set; }
        public string PathTemplateReportRNC { get; set; }
        public string PathAndNameLogoReport { get; set; }
        public string PathLocalToSaveReport { get; set; }
        public string PathProgramView { get; set; }
        public string TitleProgram { get; set; }
        public string TitleLogin { get; set; }

        public string JsonSerilizar(Config config)
        {
            return JsonConvert.SerializeObject(config);
        }
        public static Config JsonDesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<Config>(Json);
        }
    }
}
