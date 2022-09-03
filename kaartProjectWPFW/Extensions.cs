namespace ExtensionMethods{
    public static class FloatExtensions{
        public static string metSuffixen(this float flt){
            return (Convert.ToString(flt) + "Suffix hier!");
        }
    }
}