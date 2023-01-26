Random randNum = new Random();
int selectedNumber = randNum.Next(100);
int[] fibonacci = new int[100];
bool validated = false;

fibonacci[0] = 0;
fibonacci[1] = 1;

if (selectedNumber == fibonacci[0] || selectedNumber == fibonacci[1]) {
    validated = true;
}
else {
    for(int i = 2; i < 100; i++) {
        fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];

        if (fibonacci[i] == selectedNumber) {
            validated = true;
            break;
        }
        else if (fibonacci[i] > selectedNumber) {
            validated = false;
            break;
        }
    }
}

Console.WriteLine("Numero selecionado: " + selectedNumber + ". Esse número" + (validated ? "" : " não")  + " está na sequência de Fibonacci");


