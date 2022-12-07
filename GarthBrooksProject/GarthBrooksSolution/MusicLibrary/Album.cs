using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class Album
    {
        public int ID { get; set; }
        public string? AlbumName { get; set; }   
        public string? AlbumArtist { get; set; }
        public int? AlbumYear { get; set; }  
        public string? AlbumURL { get; set; }
        public string? AlbumDesc { get; set; }
    }
}
