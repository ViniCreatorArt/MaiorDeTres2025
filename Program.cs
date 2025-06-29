Console.WriteLine("- Maior De Três -\n");

Console.Write("Digite o primeiro número...: ");
int Pn = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número....: ");
int Sn = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o terceiro número...: ");
int Tn = Convert.ToInt32(Console.ReadLine());

int maiorNumero;

if (Pn > Sn)
{
    if (Pn > Tn)
    {
        maiorNumero = Pn;
    }
    else
    {
        maiorNumero = Tn;
    }
}
else
{
    if (Sn > Tn)
    {
        maiorNumero = Sn;
    }
    else
    {
        maiorNumero = Tn;
    }
}

Console.WriteLine($"\nMaior número: {maiorNumero}");
