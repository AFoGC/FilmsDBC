using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface
{
    public interface IControls
    {
        bool SetFindedElement(String search);
        void SetVisualDefault();
        void RefreshData();
        Control ToUpdateControl();
    }
}
