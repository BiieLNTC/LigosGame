using System.ComponentModel;

namespace LigosGame.Models.Enums
{
    public class ConfiguracoesEnum
    {
        public enum EDificuldadeJogo
        {
            [Description("Fácil")]
            Facil = 0,

            [Description("Médio")]
            Medio = 1,

            [Description("Difícil")]
            Dificil = 2,
        }
    }
}
