using Controller;
using Entities;

namespace Helper
{
    public static class SetHelper
    {
        public static Moeda MoedaSelecionada { get; private set; }

        public static void SetarMoeda(Moeda moeda)
        {
            MoedasBLL moedasBLL = new MoedasBLL();
            MoedaSelecionada = moedasBLL.PegarValorMoeda(moeda);
        }
    }
}
