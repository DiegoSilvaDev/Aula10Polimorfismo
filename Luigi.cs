namespace Polimorfismo
{
    public class Luigi : Player
    {
        public override void Pular(){

            // Aproveitando as ações da Super Classe ou Classe Pai.
            base.Pular();

            // Acrescentando novas ações para o personagem.
            System.Console.WriteLine("O Luigi também pode pular 30% mais alto");

        }
    }
}