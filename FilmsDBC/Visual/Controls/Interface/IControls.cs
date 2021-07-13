using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.Visual.Controls
{
    public interface IControls
    {
        bool SetFindedElement(String search);
        void SetDefaultVisualCondition();
        void RefreshData();
    }
}
