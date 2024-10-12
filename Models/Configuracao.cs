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
