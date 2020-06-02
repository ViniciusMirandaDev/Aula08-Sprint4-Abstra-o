namespace Aula08_Sprint4_Abstra_o
{
    public class CartaoDebito : Cartao
    {
         public float saldo { get; set; }
        public string Transferir(){
            return "Transferência efetudada";
        }
        public string PagarTitulo(){
            return "Título pago";
        }
    }
}