using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoJogoRpg.src.entities.classes
{
    internal class Knight : Hero
    {
        private const string TYPE = "Cavaleiro";
        public Knight(string name, int hp, int mp) : base(name, hp, mp)
        {
            
        }

        public override string  Attack()
        {
           
            return @$"{base.Attack()}
                     *  ESPADA DA MORTE";
        }

        public override string ToString()
        {
            return @$"{base.ToString()}
                     *  {Name} é do tipo {TYPE}
                     *{Attack()}
                     *******************************************************";
        }
    }
}
