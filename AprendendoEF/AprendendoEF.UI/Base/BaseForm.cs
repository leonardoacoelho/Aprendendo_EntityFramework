using System.Windows.Forms;

namespace AprendendoEF.UI.Base
{
    public class BaseForm : Form
    {
        public BaseForm()
        {

        }

        public BaseForm(Form form)
        {
            MdiParent = form.MdiParent ?? form;
        }
    }
}
