//exercício 1

class program
{
    class ContaCorrente
    {
        private float saldo = 0, credito, debito, transacoes;

        public void SetTransacoes(float transferencia)
        {
            transacoes = transferencia;
        }

        public void VerificaTransacoes()
        {
            if (transacoes > 0)
            {
                LancarCredito(transacoes);
            }
            else
            {
                LancarDebito(transacoes);
            }
        }

        public void LancarCredito(float transacoes)
        {
            credito = transacoes;
        }

        public void LancarDebito(float transacoes)
        {
            debito = transacoes;
        }

        public void CalcularSaldo()
        {
            saldo = saldo + debito + credito;
        }

        public void MostraSaldo()
        {
            if (transacoes == 0)
            {
                Console.WriteLine(" o seu crédito foi de {1}R$ e seu débito foi de {2} portanto seu saldo é de {0}R$", saldo, RetornaCredito, RetornaDebito);
            }
            else
            {
                Console.WriteLine("o seu crédito foi de {1}R$, seu débito foi de {2} e você realizou uma transação de {3} portanto seu saldo é de {0}R$", saldo, RetornaCredito, RetornaDebito, Retornatransacoes);
            }
        }

        public float RetornaCredito
        {
            get { return credito; }
        }

        public float RetornaDebito
        {
            get { return debito; }
        }

        public float Retornatransacoes
        {
            get { return transacoes; }
        }
    }

    static void Main(string[] args)
    {
        int conta;
        do
        {
            Console.Write("entre 1 para acessar sua conta corrente e entre 2 para acessar sua conta de investimentos: ");
            conta = int.Parse(Console.ReadLine());
        } while (conta != 1 && conta != 2);

        if (conta == 1)
        {
            corrente();
        }
    }

    static void corrente ()
    {
        float transferencia, credito, debito;
        Console.Write("entre com o valor da transferência: ");
        transferencia = float.Parse(Console.ReadLine());
        ContaCorrente contaCorrente = new ContaCorrente();
        contaCorrente.SetTransacoes(transferencia);
        contaCorrente.VerificaTransacoes();

        Console.Write("entre com seu crédito: ");
        credito = float.Parse(Console.ReadLine());
        contaCorrente.LancarCredito(credito);

        Console.Write("entre com seu débito: ");
        debito = float.Parse(Console.ReadLine());
        if (debito > 0)
        {
            contaCorrente.LancarDebito(0 - debito);
        }
        else
        {
            contaCorrente.LancarDebito(debito);
        }
        contaCorrente.CalcularSaldo();
        contaCorrente.MostraSaldo();
    }
}