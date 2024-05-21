using AbstracaoJogoRpg.src.entities.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracaoJogoRpg.src.entities.classes
{
    internal class Hero : IPower
    {
        public string Name { get; private set; }
        public int Hp { get; private set; }
        public int Mp { get; private set; }


        public Hero(string name, int hp, int mp)
        {
            Name = name;
            Hp = hp;
            Mp = mp;
        }

        public override string ToString()
        {
            return @$"
                     ******************************************************
                     *  Este personagem se chama {Name}                      
                     *  Atualmente {Name} possui:                            
                     *  HP máximo de {Hp}                                    
                     *  Mp máximo de {Mp}";
        }

        //Este metódo possui a liberdade de ser sobreescrito
        public virtual string Attack()
        {
           return $"  {Name} possui como principal ataque: ";
        }
    }
}
