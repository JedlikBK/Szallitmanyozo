using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szállitmanyozo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = {"ABC-123","ASD-234","FGH-432","BAB-987","SEX-444"};
            List<string> bent = new List<string>();
            string választás;
            // Kiíró eljárás, Melyikek vannak bent jelenleg, Hívd meg az Elmegynél és a Bejönnél
            do
	        {
                // A választási lehetőségek kiírása
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                // Be kell kérni 1 választást
                választás = Console.ReadLine();
                switch (választás)
	            {
                    case "E":Elmegy(választás,teljes); 
                        break;
                    case "B":Bejön(választás,teljes);
                        break;
                    case "K":Kilépés();
                        break;
		            default: Console.WriteLine("Nem megfelelő a választás");
                        break;
	            }
	        } while (választás != "K"); // K = Kilépés 

            Console.ReadKey();
        }
        static void Elmegy (string[] teljes, List<string> bent)
        {
            if (bent.Count > 0)
	        {
                Console.WriteLine("Nincs bent autó");
	        }else
	        {
                Console.Write("Rendszám: ");
                string rendszám = Console.ReadLine();
                for (int i = 0; i < bent.Count; i++)
			    {
                    if (rendszám = bent[i])
	                {
                        bent.Remove(bent[i]);
	                }
			    }
	        }
            
        }
    }
}
