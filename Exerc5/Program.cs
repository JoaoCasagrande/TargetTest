string testString = "Hello! How are you?";
string reverseString = "";

for (int i = testString.Length - 1; i >= 0; i--) {
    reverseString += testString[i];
}

Console.WriteLine(reverseString);