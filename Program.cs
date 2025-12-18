namespace sõled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string lause = "Tere hommikust, mul on monster otsas, kas ma võin veel magada?";
            //Console.WriteLine("lause pikkus on: " + lause.Length);
            //Console.WriteLine("See tekst on capslockis:" + lause.ToUpper());
            //Console.WriteLine("See tekst on väiketähtedes:" + lause.ToLower());
            //Console.WriteLine("Kas lauses on sõna \"magada\"+",lause.ToLower().Contains("magada"));

            List<string> list = new List<string>() { "auto", "kraav", "kruus" };
            string listkoos = "";
            foreach (var sõne in list)
            {
                listkoos += (" "+sõne.ToUpper()+",");
            }
            Console.WriteLine(listkoos);

            string eesnimi = "Julius";
            string perekonnanimi = "Caesar";
            string amet = "Ohver";
            string kuuluskeiser = string.Concat(eesnimi, perekonnanimi, amet);
            Console.WriteLine(kuuluskeiser);
        }
    }
}
