using FilmsDBC.CinemaDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsDBC.VisualElements.FilmControls.Interface
{
    public interface IControls
    {
        bool SetFindedElement(String search);
        void SetVisualDefault();
        void RefreshData();
        bool HasSelectedGenre(Genre[] selectedGenres);
        bool HasWatchedProperty(bool isWached);
    }
}
