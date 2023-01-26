double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, others = 19849.53;
double total = sp + rj + mg + es + others;

Console.WriteLine("Porcentagem de participação de SP: " + ((double)(sp * 100) / (double)total) + "%");
Console.WriteLine("Porcentagem de participação de RJ: " + ((double)(rj * 100) / (double)total) + "%");
Console.WriteLine("Porcentagem de participação de MG: " + ((double)(mg * 100) / (double)total) + "%");
Console.WriteLine("Porcentagem de participação de ES: " + ((double)(es * 100) / (double)total) + "%");
Console.WriteLine("Porcentagem de participação de Outros: " + ((double)(others * 100) / (double)total) + "%");