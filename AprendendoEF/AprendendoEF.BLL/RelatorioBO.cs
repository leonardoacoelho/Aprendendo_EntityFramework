using Microsoft.Reporting.WinForms;
using System.IO;

namespace AprendendoEF.BLL
{
    public class RelatorioBO
    {
        public void Exportar(string folder, string fileName, LocalReport report)
        {
            var caminho = $@"C:\Relatorios\{folder}\";
            var existe = Directory.Exists(caminho);

            if (!existe)
                Directory.CreateDirectory(caminho);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            var bytes = report.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream($"{caminho}{fileName}.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
