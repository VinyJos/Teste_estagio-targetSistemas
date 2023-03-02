
Console.Write("Digite uma palavra: ");
string frase = Console.ReadLine();


var fraseCont = frase.Length;
string novaFraseInvertida = "";

for (int i = fraseCont -1; i >= 0; i--)
{
    novaFraseInvertida += frase[i];
    
}

Console.WriteLine(novaFraseInvertida);
