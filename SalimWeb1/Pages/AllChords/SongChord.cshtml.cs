using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SalimWeb1.ChordDatabase;

namespace SalimWeb1.Pages.AllChords
{
    public class SongChordModel : PageModel
    {
        public string sChord;
        DataChord dChord;
        
        public SongChordModel()
        {
            dChord = new DataChord();
            sChord = "";
        }

        public void OnGet(string id)
        {
            
            sChord = dChord.SongFullChord(id);
        }
    }
}
