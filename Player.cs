namespace Polimorfismo
{
    public class Player
    {
        public virtual void Pular(){
            System.Console.WriteLine("O Personagem está pulando normalmente.");
        }

        public virtual void Correr(){
            System.Console.WriteLine("O Personagem está correndo normalmente.");
        }
    }
}