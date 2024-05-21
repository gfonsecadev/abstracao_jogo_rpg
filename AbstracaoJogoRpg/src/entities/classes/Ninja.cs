using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoJogoRpg.src.entities.classes
{
    internal class Ninja : Hero
    {
        private const string TYPE = "NINJA";

        //para utilizarmos a referência da classe herdada utilizamo a instrução base
        public Ninja(string name, int hp, int mp) : base(name, hp, mp)
        {

        }

        //Este metódo foi sobreescrito da classe Hero
        public override string Attack()
        {

            return @$"{base.Attack()}
                     *  Golpe das sombras";
        }

        //O METODO ToString foi sobreescrito com reutilização do ToString da classe Hero utilizando a instrução base
        public override string ToString()
        {
            return @$"{base.ToString()}
                     *  {Name} é do tipo {TYPE}
                     *{Attack()}
                     *******************************************************";
        }
    }
}

