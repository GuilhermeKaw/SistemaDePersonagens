namespace SistemaDePersonagens
{
    internal class Program
    {

        public static void TocarSomAlarme(string msg) 
        {
            Console.WriteLine("\uD83D\uDD0A" + msg);
        }
        public static void ExibirEfeitoSangueTela(string msg) 
        {
            Console.WriteLine("\uD83E\uDE78" + msg);
        }
        public static void VerificarEstado(Personagem p) 
        {
            if (p == null) return;
            if (p.PontosVida <= 0)
            {
                TocarSomAlarme("O Personagem " + p.Nome + " já foi derrotado!");
            }
            else if (p.PontosVida > 0 && p.PontosVida <= 20) 
            {
                ExibirEfeitoSangueTela("O Personagem " + p.Nome + " está gravemente ferido!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem-Vindo(a) ao DELTORIS");

            // Criando um personagem
            Personagem personagem = new Personagem("Arthas", 25, 100, 1, 0);

            // +120 XP
            personagem.GanharExperiencia(120);

            // +30 DANO
            personagem.ReceberDano(30);
            VerificarEstado(personagem);

            // +60 DANO
            personagem.ReceberDano(60);
            VerificarEstado(personagem);

            // +20 DANO
            personagem.ReceberDano(20);
            VerificarEstado(personagem);

            // Teste de cura
            personagem.Curar(50);
            VerificarEstado(personagem);
        }
    }
}
