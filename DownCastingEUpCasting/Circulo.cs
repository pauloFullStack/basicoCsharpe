namespace DownCastingEUpCasting
{
    public class Circulo : Forma
    {
        public Circulo(int x, int y) : base(x, y) { }
        public Circulo() { }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar - Circulo na posição : ({xpos},{ypos})");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintar o círculo");
        }
    }
}
