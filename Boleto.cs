using System;

namespace Aula08_Sprint4_Abstra_o
{
     public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
            public string bancoEmissor { get; set; }
            public string codDeBarras { get; set; }

            public string registrar(){
                return "Boleto registrado com sucesso!";
            }
    }
}