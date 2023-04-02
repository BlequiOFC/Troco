Console.Clear();

decimal compra, pago, troco;

Console.WriteLine("--- Troco ---");
Console.WriteLine();

Console.Write("Valor da compra (R$)...: ");
compra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago (R$)........: ");
pago = Convert.ToDecimal(Console.ReadLine());

troco = compra - pago;

Console.WriteLine();
Console.WriteLine($"Troco: {troco:C}");