int selectedNumber;

// Código para imput de um numero
/*
Console.WriteLine("Enter a number: ");
selectedNumber = Convert.ToInt32(Console.ReadLine());
*/
// Código para testes rápidos, gerando numeros aleatórios

Random randNum = new Random();
selectedNumber = randNum.Next(100);

int n1 = 0, n2 = 1, n3;
bool validated = false;

do {
    n3 = n1 + n2;
    n1 = n2;
    n2 = n3;

    Console.Write(n3 + " ");
}while (n3 != selectedNumber && n3 < selectedNumber);

if (n3 > selectedNumber) validated = false;
else if (n3 == selectedNumber) validated = true;

Console.WriteLine("\n\nNumero selecionado: " + selectedNumber + ".\nEsse número" + (validated ? "" : " não")  + " está na sequência de Fibonacci");


