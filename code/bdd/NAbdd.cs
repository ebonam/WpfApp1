using SQLite;

namespace code.bdd
{
    [Table("NA")]
    class NAbdd
    {

        [PrimaryKey, AutoIncrement]
        public int _Id { get; set; }
        [Column("lib")]
        public string _Lib { get; set; }
        [Column("lib")]
        public int _Loc { get; set; }
        [Column("loca")]
        public bool _motcomplet { get; set; }
        [Column("secteur")]
        public string _secteur { get; set; }

        public int sort1(NAbdd na) {

            if (_Loc > na._Loc)
            {
                return 1;
            }
            else if (_Loc < na._Loc) {
                return -1;
            }
            else return 0;

        }
    }
}
