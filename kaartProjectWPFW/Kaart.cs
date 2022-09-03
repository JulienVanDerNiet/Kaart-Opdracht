namespace Kaart{
    public class Kaart{
        public readonly int Breedte;
        public readonly int Hoogte;

        private List<Pad> paden;

        private List<KaartItem> KaartItems;

        public Kaart(int Breedte, int Hoogte){
            this.Breedte = Breedte;
            this.Hoogte = Hoogte;
            this.KaartItems = new List<KaartItem>();
        }
        public void Teken(Tekener t){
            //NEED TO FIX

        }
        public void VoegItemToe(KaartItem item){
            this.KaartItems.Add(item);

        }
    }
}