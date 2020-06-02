namespace Aula08_Sprint4_Abstra_o
{
    public class Cartao : Pagamento
    {
        protected string token= "82387d78sdsd78f78s7f88s7d8s7d8d";
        public string titular { get; set; }
        public int numero { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }
        public bool ValidarToken(){
            if(token!=null){
                return true;
            }
            return false;
        }
    }
}