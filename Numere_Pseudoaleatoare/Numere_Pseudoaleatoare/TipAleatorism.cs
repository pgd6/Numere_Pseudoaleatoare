namespace Numere_Pseudoaleatoare
{
    public enum TipAleatorism
    {
        Eroare,
        Nesatisfacator,
        Bun,
        Foarte_Bun
    }

    static class MetodeTipAleatorism
    {
        public static string ToString(this TipAleatorism tip)
        {
            if (tip == TipAleatorism.Bun)
            {
                return "Tip Aleatorism: Bun";
            }
            else if (tip == TipAleatorism.Foarte_Bun)
            {
                return "Tip Aleatorism: Bun";
            }
            else if(tip==TipAleatorism.Nesatisfacator)
            {
                return "Tip Aleatorism: Nesatisfacator";
            }
            return "Eroare!";
        }
    }
}
