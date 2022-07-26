using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using SalimWeb1.CModel;
using SalimWeb1.ChordDatabase;

namespace SalimWeb1.Pages
{
    public class ChordModel : PageModel
    {
        public List<ChModel> _AllChords;
        DataChord _dataChord;
        public ChordModel()
        {
            _AllChords = new List<ChModel>();   
            _dataChord = new DataChord();
        }
        public void OnGet()
        {
            _AllChords = _dataChord.GetAllChords();
        }
    }
}
