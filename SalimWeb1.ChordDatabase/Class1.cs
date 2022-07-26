using SalimWeb1.CModel;
namespace SalimWeb1.ChordDatabase
{
    public class DataChord
    {
        List<ChModel> allChords;
        public DataChord()
        {
            allChords = new List<ChModel>()
            {
                new ChModel() { id = 1, songTitle="Kono Ovijog Nei", singerName = "AB", 
                    songChord= "(D)Kono Ovijog Nei Je Amar\r\n(G)Kono Ovijog Nei E(D)khon\r\n" +
                    "(D)Nei Kono Aj Proshno Buke\r\n(G)Kono Chawa Pawa Nei A(D)\r\n" +
                    "(Em)Holona(G)Tomake Kache Pa(D)wa\r\nNa Tumi (Em)Janona\r\n" +
                    "(G)Songi Aj Bedo(D)na\r\nA(A)mar\r\n" +
                    "Kichu (D)Bolona A(G)mai\r\n(Em)Tumi Chara Ami (A)Ekaki Hai\r\n" +
                    "Ki je (D)Jontrona A(G)mar\r\n(Em)Evabe Ki Beche (A)Thaka Jai\r\n" +
                    "(D)Hooooooooo\r\n" +
                    "(D)Nibir Premer Nirob Smriti\r\nShishir Ghashe Ka(F#m)de\r\n" +
                    "Tumi (Em)Janle na Je (G)Dukkho (D)Tar\r\n"+
                    "Kichu (D)Bolona A(G)mai\r\n(Em)Tumi Chara Ami (A)Ekaki Hai\r\n" +
                    "Ki je (D)Jontrona A(G)mar\r\n(Em)Evabe Ki Beche (A)Thaka Jai\r\n" +
                    "(D)Hooooooooo\r\n"},
                new ChModel() { id = 2, songTitle="Baba", singerName = "James", songChord= "asdafasd"},
                new ChModel() { id = 3, songTitle="Shei Tumi", singerName = "AB", songChord= "asdafasd"},
                new ChModel() { id = 4, songTitle="Nirobe", singerName = "AB", songChord= "asdafasd"},
                new ChModel() { id = 5, songTitle="Tarai Tarai", singerName = "james", songChord= "asdafasd"},
                new ChModel() { id = 6, songTitle="Mukhorito Jibon", singerName = "Souls", songChord= "asdafasd"}
            };
        }
        public List<ChModel> GetAllChords()
        {
            return allChords;
        }
        public string SongFullChord(string cId)
        {
            
            foreach(var c in allChords)
            {
                if (c.id==Convert.ToInt16(cId))
                    return c.songChord;
            }
            return "Chord cant be found";
        }
    }
}