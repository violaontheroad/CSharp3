namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get;  set; }

        public static int TotalDeContasCriadas {get; private set;}
        
        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;

            }
        }

        private int _numero;
        public int Numero
        { 
        get
        {
            return _numero;
        }
        set
        {
            if(value <= 0)
            {
                    return;
            }

            _numero = value;
            }
        }
        private double _saldo = 300;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if(_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }
        public void Depositar (double valor)
        {
        _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

