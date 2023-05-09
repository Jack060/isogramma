# Isogramma

Determina se una parola o una frase è un isogramma.

Per come lo intendiamo in questo esercizio, un isogramma è una parola o una frase che non ha lettere ripetute.
Sono ammessi spazi e segni di punteggiatura ripetuti.

Esempi di isogrammi:

- lumberjacks
- background
- downstream
- six-year-old

Gli isogrammi possono essere utili come chiavi di cifratura dato che la corrispondenza fra lettere è univoca. 

Isogrammi di 10 lettere, per esempio PATHFINDER, DUMBWAITER o BLACKHORSE, possono essere utilizzate da venditori di beni il cui prezzo può essere negoziato, come macchine usate, gioielli e antichità.

Per esempio le cifre decimali possono essere mappate secondo questo schema:

P	A	T	H	F	I	N	D	E	R

1	2	3	4	5	6	7	8	9	0

Ammettiamo che il prezzo indicato fosse 1200 € ma nel cartellino ci fossero anche le lettere FRR, il venditore saprebbe che il prezzo originale era 500 € in modo da non scendere sotto quella soglia.

Un isogramma di 12 lettere si può usare per mappare i mesi dell'anno.

[Wikipedia sugli Isogrammi](https://it.wikipedia.org/wiki/Isogramma)

<details>
  <summary>come modificare una stringa:</summary>
  
   ```c#
      string parola = word.Replace("-", "");
      parola = parola.Replace(" ", "");
      parola = parola.ToLower();
   ```
  questa parte di codice è utile per togliere eventuali spazi, trattini o lettere maiuscole.
  
</details>

<details>
  <summary>come trasformare le stringhe in char array:</summary>
  
   ```c#
      bool iso = true;
      char[] vet = parola.ToCharArray();
      char[] controllo = parola.ToCharArray();
   ```
  qua vengono creata una variabile booleana e due char array con le posizioni riempite di caratteri dalla variabile parola (che sarebbe la stringa in input) utili per controllare che non ci siano lettere ripetute.
  
</details>


<details>
  <summary>controllo lettera per lettera:</summary>
  
   ```c#
       for(int i = 0; i < parola.Length-1; i++)
        {
            for(int j = i+1; j < parola.Length; j++){
                    if(vet[i]==controllo[j]){
                    iso = false;
                }
            }
        }
        return iso;
   ```
  questi due cicli for servono per controllare lettera per lettera l'array di caratteri, stando attenti che il secondo ciclo parta dalla posizione del primo +1; se non si fa questo il programma controlla che nella stessa posizione ci sia la lettera uguale e di conseguenza entra nel costrutto di selezione if attribuendo alla variabile booleana (precedentemente inizializzata come true) il valore "false". Finiti i due for ritorna iso: in caso rimanga positivo vuol dire che la parola o la frase sono isogrammi, se invece ritorna negativo vuol dire che il codice ha trovato almeno due lettere uguali.
  
</details>

