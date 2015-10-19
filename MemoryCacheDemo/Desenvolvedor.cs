namespace MemoryCacheDemo
{
    public class Desenvolvedor
    {
        public string Nome { get; set; }
        public string Linguagem { get; set; }
        public int AnosExperiencia { get; set; }

        public override string ToString() => $"Nome: {Nome} / Linguagem: {Linguagem} / Anos Experiência: {AnosExperiencia}";
    }
}
