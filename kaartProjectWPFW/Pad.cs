namespace Kaart{
    class Pad : Tekenbaar{
        private Kaart kaart;
        private Coordinaat van;
        private Coordinaat naar;
        private float lengteBerekend;

        public Pad(Kaart kaart, Coordinaat van, Coordinaat naar, float lengteBerekend)
        {
            this.kaart = kaart;
            this.van = van;
            this.naar = naar;
            this.lengteBerekend = lengteBerekend;
        }
        public float Lengte(){
            //TODO!!
            return 0;
        }
        public void TekenConsole(ConsoleTekener t){

        }
    }
}