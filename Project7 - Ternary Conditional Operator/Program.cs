// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// int i = 10;
// i < discount ? discount = 10 : discount = 50;

Random CoinFlip = new();
int CoinFace = CoinFlip.Next(1, 2);
Console.WriteLine($"{(CoinFace == 1 ? "heads" : "tails")}");
