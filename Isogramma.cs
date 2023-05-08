using System;
using System.Linq;

public static class Isogramma
{
    public static bool Verifica(string word)
    {
        string parola = word.Replace("-", "");
        parola = parola.Replace(" ", "");
        parola = parola.ToLower();      
        bool iso = true;
        char[] vet = parola.ToCharArray();
        char[] controllo = parola.ToCharArray();
        for(int i = 0; i < parola.Length-1; i++)
        {
            for(int j = i+1; j < parola.Length; j++){
                    if(vet[i]==controllo[j]){
                    iso = false;
                    j=word.Length-1;
                    i=word.Length-1;
                }
            }
        }
        return iso;
    }
}
