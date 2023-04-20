using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personagem
{
    public class Personagem
    {
        //Exemplo
    //   public string nome = "tony Stark" ;
    //   public int idade = 35;
    //   public string armadura = "bleeding Edge";
    //   public string ia = "Jarvis";

    public string nome;
    public int idade;
    public string armadura;
    public string ia;

      
        public void Atacar()    
        {
        Console.WriteLine($"o personagem atacou");   
        }
        public string Defender()
        {
            return "O personagem defendeu!";
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou armadura!");
        }
    }
        
}