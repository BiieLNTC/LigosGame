using LigosGame.Models.Enums;
using System.ComponentModel;

namespace LigosGame.Models
{
    public class Configuracao
    {
        [DisplayName("Dificuldade")]
        public ConfiguracoesEnum.EDificuldadeJogo Dificuldade { get; set; }

        [DisplayName("Temas")]
        public List<Tema> ListaTema { get; set; }

        public Configuracao()
        {
            Dificuldade = ConfiguracoesEnum.EDificuldadeJogo.Facil;
            ListaTema = new List<Tema>()
            {
                new Tema()
                {
                    Nome = "Fruta"
                },
                 new Tema()
                {
                    Nome = "Cor"
                },
                  new Tema()
                {
                    Nome = "CEP"
                },
                  new Tema()
                {
                    Nome = "Profissões"
                },
                new Tema()
                {
                    Nome = "Pessoas Famosas"
                },
                new Tema()
                {
                    Nome = "Nomes Femininos"
                },
                new Tema()
                {
                    Nome = "Nomes Masculinos"
                },
                new Tema()
                {
                    Nome = "Times de Futebol"
                },
                new Tema()
                {
                    Nome = "Países"
                },
                new Tema()
                {
                    Nome = "Minha sogra é"
                },
                new Tema()
                {
                    Nome = "Meu namorado(a) é"
                },
            };
        }

        #region Functions

        public int ObterSegundosRodada()
        {
            return Dificuldade switch
            {
                ConfiguracoesEnum.EDificuldadeJogo.Facil => 15,
                ConfiguracoesEnum.EDificuldadeJogo.Medio => 10,
                ConfiguracoesEnum.EDificuldadeJogo.Dificil => 5,
                _ => 15
            };
        }

        #endregion
    }
}
