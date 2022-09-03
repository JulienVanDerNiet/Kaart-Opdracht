namespace Kaart{
    struct Coordinaat{
        public readonly int x;
        public readonly int y;

        public Coordinaat(int x, int y){
            this.x = x;
            this.y = y;
        }
        public static Coordinaat operator + (Coordinaat van, Coordinaat naar){
            return van;
        }
    }
}