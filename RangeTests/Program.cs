using static System.Console;
using static System.String;

var lista = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Print(lista, ..);
// Print(lista, ..3);
// Print(lista, 3..);
// Print(lista, 3..5);
// Print(lista, ^7..);
// Print(lista, ..^4);
// Print(lista, 3..^4);
Print(lista, ^4..^1);

void Print(int[] lista, Range range)
    => WriteLine(Join(", ", lista[range]));