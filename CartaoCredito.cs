namespace Aula08_Sprint4_Abstra_o
{
   public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public void AumentarLimite(float acrescimo){
            token="27262726763736";
            limite=limite+acrescimo;
        }
    }
}