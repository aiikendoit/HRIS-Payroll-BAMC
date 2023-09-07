using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Document
{
    public interface IDocumentTypeView
    {
        void DisplayDocumentype(List<Models.Doctype> documentTypes);
    }
}
