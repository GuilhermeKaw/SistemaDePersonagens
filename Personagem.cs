using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePersonagens
{
    public class Personagem
    {
        #region Atributos
        private string _nome;
        private int _pontosVida;
        private int _nivel;
        private int _experiencia;
        private int _poderAtaque;

        public string Nome
        {
            get { return _nome; }
            private set { _nome = value; }
        }
        public int PontosVida
        {
            get { return _pontosVida; }
            private set
            {
                if (value < 0)
                {
                    _pontosVida = 0;
                }
                if (value > 100) 
                {
                    _pontosVida = 100;
                }
                else
                {
                    _pontosVida = value;
                }
            }
        }
        public int Nivel
        {
            get { return _nivel; }
            private set { _nivel = value; }
        }
        public int Experiencia
        {
            get { return _experiencia; }
            private set { _experiencia = value; }
        }
        public int PoderAtaque
        {
            get { return _poderAtaque; }
            private set { _poderAtaque = value; }
        }
        #endregion
        #region Construtor
        public Personagem(string nome, int poderAtaque, int pontosVida, int nivel, int experiencia)
        {
            Nome = nome;
            PoderAtaque = 25;
            PontosVida = 100;
            Nivel = 1;
            Experiencia = 0;
        }
        #endregion
        public void Curar(int quantidade)
        {
            if (quantidade > 0) ;
            {
                PontosVida += quantidade;
                Console.WriteLine($"{Nome} curou-se em {quantidade} HP. Vida atual: {PontosVida}/100");
            }
        }
        public void ReceberDano(int dano)
        {
            if (PontosVida == 0)
            {
                Console.WriteLine($"{Nome} já está derrotado.");
                return;
            }
            else 
            {
                PontosVida -= dano;
                Console.WriteLine($"{Nome} sofreu {dano} de dano! Vida restante: {PontosVida}/100");
            }
        }
        public void GanharExperiencia(int xp)
        {
            Experiencia += xp;

            while (Experiencia >= 100)
            {
                Experiencia -= 100;
                Nivel++;
                PoderAtaque += 5;
                Console.WriteLine($"{Nome} subiu para o nível {Nivel}! Poder de ataque agora é {PoderAtaque}.");
            }
        }
    }
}
