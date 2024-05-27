// Main()

using InterfaceTributavel;

ContaCorrente cc = new ContaCorrente();
cc.Saldo = 100;
//ITributavel t = cc;

SeguroDeVida sdv = new SeguroDeVida();
//ITributavel t = sdv;

TotalizadordeTributos tdt = new TotalizadordeTributos();
tdt.Adiciona(cc);
tdt.Adiciona(sdv);
Console.WriteLine("Total: " + tdt.Total);

