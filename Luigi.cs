namespace Polimorfismo
{
    public class Luigi : Player
    {
        public override void Pular(){

            // Manter as ações do método Pai.
            base.Pular();

            // Acrescentando uma nova ação para o personagem.
            System.Console.WriteLine("Luigi agora está pulando com uma altura 30% mais alta");

        }
    }
}