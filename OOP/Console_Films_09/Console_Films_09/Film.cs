namespace Console_Films_09
{
    class Film
    {
        protected string tytul;
        protected int liczbaWypozyczen;

        public Film()
        {
            tytul = "";
            liczbaWypozyczen = 0;
        }

        public string Tytul
        {
            get { return tytul; }
            set
            {
                if (value.Length > 20)
                {
                    throw new Exception("Tytuł powinien zawierac maksymalnie 20 znaków");
                }
                tytul = value;
            }
        }

        public int LiczbaWypozyczen
        {
            get { return liczbaWypozyczen; }
        }

        public void inkrementuj()
        {
            liczbaWypozyczen++;
        }
    }
}
