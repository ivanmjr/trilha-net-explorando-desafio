namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                        
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new System.ArgumentException("Quantidade de Hospedes acima da capacidade da Suite!");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)                    
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária            
            decimal valor = 0;                 
            // conceder um desconto de 10% quando dia maiores ou iguais a 10            
            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria) -  ((Suite.ValorDiaria * DiasReservados) * 0.10M);
            }else{
                 valor = DiasReservados * Suite.ValorDiaria;
            }
            return valor;
        }
    }
}