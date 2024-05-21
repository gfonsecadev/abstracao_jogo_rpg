using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstracaoJogoRpg.src.entities.classes
{
    internal class Wizard : Hero
    {
        private const string TYPE = "Mago";
        public Wizard(string name, int hp, int mp) : base(name, hp, mp)
        {

        }

        public override string Attack()
        {

            return @$"{base.Attack()}
                     *  Magia das trevas";
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

