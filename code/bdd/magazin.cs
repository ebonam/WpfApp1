using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.bdd
{
    class magazin
    {

        [PrimaryKey, AutoIncrement]
        public int Nligne{ get; set; }
        [Column("lib")]
        public string _lib { get; set; }
        [Column("motcomplet")]
        public string ean { get; set; }
        [Column("secteur")]
        public int _codeAchat { get; set; }
        public int _Typearticl { get; set; }
        public int _Alle { get; set; }
        public int _Trave { get; set; }
        public int _Niveau { get; set; }
        public int _Rang { get; set; }



    }
}
