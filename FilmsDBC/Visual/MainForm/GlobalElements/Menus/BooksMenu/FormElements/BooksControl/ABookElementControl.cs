using FilmsDBC.DataAccessLayer.CinemaDataTypes;
using FilmsDBC.Visual.MainForm.GlobalElements.Menus.ACommonElements.ControlsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsDBC.Visual.MainForm.GlobalElements.Menus.BooksMenu.FormElements.BooksControl
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<ABookElementControl, UserControl>))]
    public class ABookElementControl : UserControl, IControls
    {
        public bool HasSelectedGenre(Genre[] selectedGenres)
        {
            throw new NotImplementedException();
        }

        public bool HasWatchedProperty(bool isWached)
        {
            throw new NotImplementedException();
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }

        public bool SetFindedElement(string search)
        {
            throw new NotImplementedException();
        }

        public void SetVisualDefault()
        {
            throw new NotImplementedException();
        }

        public Control ToUpdateControl()
        {
            throw new NotImplementedException();
        }
    }
}
