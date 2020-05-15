using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameBasicSetupWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new TheMonoGameGodClass()) {
                game.Run();
            }
        }
    }
}
