namespace Kaart{
    class KaartItem : Tekenbaar{
        private Coordinaat _locatie;
        private Kaart kaart;
        private char _karakter;

        public KaartItem(Kaart kaart, Coordinaat _locatie, char _karakter){
            this.kaart = kaart;
            this._locatie = _locatie;
            this._karakter = _karakter;
        }
        public Coordinaat Locatie{
            get{return _locatie;}
            set{_locatie = value;}
        }
        public char Karakter{
            get{return _karakter;}
        }
        public void TekenConsole(ConsoleTekener t){
            
        }
    }
}