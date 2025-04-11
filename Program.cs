using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace prefeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] rend;
            double[] filhos;
            double rcf, rc, r1000, mR, mRend = 0, mFilhos = 0, cF;
            rend = new double[100];
            filhos = new double[100];
            rc = 0;
            r1000 = 0;
            int i = 0;
            cF = 0;
            for (i = 0; i <= 99; i++)
            {
                Console.WriteLine("Digite o rendimento da " + (i + 1) + "° familia (ou Digite 0 para terminar o programa): ");
                rend[i] = Convert.ToDouble(Console.ReadLine());
                if (rend[i] == 0)
                    break;
                else if (rend[i] >= 1000)
                {
                    r1000 = rc + 1;
                    rc = r1000;
                }
                Console.WriteLine("Digite a quantidade de filhos da " + (i + 1) + "° familia: ");
                filhos[i] = Convert.ToDouble(Console.ReadLine());
                mFilhos = filhos[i] + mFilhos;
                mRend = rend[i] + mRend;

            }
            rcf = (r1000 / i) * 100;
            mR = mRend / i;
            cF = mFilhos / i;
            Console.WriteLine("Media do numero de filhos: " + cF);
            Console.WriteLine("Media dos rendimentos da população: " + mR);
            Console.WriteLine("Percentual de familias com rendimento (= ou >) que 1000: " + rcf + "%");


            Console.ReadKey();

        }
    }
}
