double Total,Reduzir,Retorno,Bonus,Pontos;
Console.WriteLine("\n----- Milhas Bumerangue -----\n");
Console.Write("Percentual de bônus.....: ");
Bonus = double.Parse(Console.ReadLine()!);
Console.Write("Percentual de retorno...: ");
Retorno = double.Parse(Console.ReadLine()!);
Console.Write("Pontos a transferir.....: ");
Pontos = double.Parse(Console.ReadLine()!);
Total = Pontos+(Pontos*(Bonus/100));
Reduzir = Pontos-(Pontos*(Retorno/100));

Console.WriteLine("\nPontos a reduzir na origem........: "+Reduzir);
Console.WriteLine("Pontos a acrescentar no destino...: "+Total);
