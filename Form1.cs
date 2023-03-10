using iText.Html2pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RelatorioInHTMLToPDF
{
    public partial class Form1 : Form
    {
        public static string path_base = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string path_base2 = System.AppDomain.CurrentDomain.ToString();
        Config config_ = new Config();

        public Form1()
        {
            InitializeComponent();
            configSettings();
            this.Text = config_.TitleProgram;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Random rInt = new Random();

            StructTest tTest = new StructTest();
            tTest.type = "TESTE";
            tTest.realized_at = DateTime.Now;
            tTest.idTest = rInt.Next(0, 1000000);

            generateTestInPDF(tTest);
        }

        private void generateTestInPDF(StructTest obj)
        {
            string templateFileHTML = @config_.PathTemplateReport;


            if (File.Exists(templateFileHTML))
            {
                var html = File.ReadAllText(templateFileHTML, Encoding.UTF8);
                html = html.Replace("|!@[LOGO]@!|", HttpUtility.HtmlDecode(@"<img src='" + config_.PathAndNameLogoReport + "' / >"));
                html = html.Replace("|!@[TYPER_TEST]@!|", HttpUtility.HtmlEncode(obj.type == "AIR" ? "AIR" : "HYDRAULIC"));
                html = html.Replace("|!@[DATE]@!|", obj.realized_at.ToString());
                html = html.Replace("|!@[YEAR]@!|", DateTime.Now.Year.ToString());

                string outputFilePDF = @config_.PathLocalToSaveReport + obj.idTest.ToString() + ".pdf";

                string nameFile = obj.idTest.ToString() + ".pdf";
                using (FileStream pdfDest = File.Open(outputFilePDF, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    converterProperties.SetCharset("UTF-8");
                    HtmlConverter.ConvertToPdf(html, pdfDest, converterProperties);

                    // Lógica de tentativa em gerar o PDF por diversos meios e formas.
                    if (!openPDFFileWithoutProgram(nameFile))
                        if (!openPDFFileWithProgram(nameFile))
                        {
                            //Save a version in HTML AND OPEN FILE
                            string outputFileHTML = @config_.PathLocalToSaveReport + obj.idTest.ToString() + ".html";
                            File.WriteAllText(outputFileHTML, html, Encoding.UTF8);
                            openHTMLFileLikeReport(nameFile.Replace(".pdf", ".html"));
                        }
                   
                    // Recurso para gerar o arquivo de diversas maneiras
                    /*
                     * openPDFFileWithoutProgram(nameFile);
                    openPDFFileWithProgram(nameFile);
                    //Save a version in HTML AND OPEN FILE
                    string outputFileHTML = @config_.PathLocalToSaveReport + obj.idTest.ToString() + ".html";
                    File.WriteAllText(outputFileHTML, html, Encoding.UTF8);
                    openHTMLFileLikeReport(nameFile.Replace(".pdf", ".html"));
                    */

                }
            }
            else
            {
                MessageBox.Show("Template file does not exist or was not found in directory");
            }

        }


        public bool openPDFFileWithoutProgram(string file)
        {
            bool success = false;
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = @config_.PathLocalToSaveReport + file; //@"C:\\reports\\" + file;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                process.WaitForExit();
                success = process.HasExited;
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException) //catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool openPDFFileWithProgram(string file)
        {
            bool success = false;
            try
            {
                Process process = new Process();
                // Configure the process using the StartInfo properties.
                process.StartInfo.FileName = @config_.PathProgramView;
                process.StartInfo.Arguments = @config_.PathLocalToSaveReport + file; //@"C:\\reports\\" + file;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                success = process.HasExited;
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException) //catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool openHTMLFileLikeReport(string file)
        {
            bool success = false;
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = @config_.PathBaseReport + file; //@"C:\\reports\\" + file;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.Start();
                process.WaitForExit();
                success = process.HasExited;
            }
            catch (Exception ex) when (ex is Win32Exception || ex is FileNotFoundException) //catch (Win32Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            return success;
        }
        public void configSettings()
        {
            if (File.Exists(@path_base + "config.json"))
            {
                try
                {
                    var configJSON = "";


                    using (StreamReader sr = new StreamReader(@path_base + "config.json")) //using (StreamReader sr = new StreamReader(@"c:\facens\projetos\Progeral\Progeral\config.json"))
                    {
                        configJSON = sr.ReadToEnd();
                    }
                    config_ = Config.JsonDesserializar(configJSON);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail: " + ex.Message + ". \nConfig Settings Not Founded.");
                }
            }
            else
            {
                MessageBox.Show("The config file does not exist . Add and restart the system.");
            }
        }
    }
}
