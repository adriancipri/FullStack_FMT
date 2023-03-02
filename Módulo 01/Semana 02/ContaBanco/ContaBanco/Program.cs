using ContaBanco;

ContaBancaria conta = new ContaBancaria();
conta.numero = 123;
conta.agencia = 01;
conta.titular = "Zé da Silva";
conta.tipoConta = TipoContaEnum.CORRENTE;

conta.Depositar(0);

conta.Sacar(0);

conta.ExibirSaldo();