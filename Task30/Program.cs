int[] array = new int[8];
array[0] = 2173;
array[4] = 545;
array[7] = 64;

for(int i = 0; i < array.Length; i++) {
    array[i] = i * i;
    Console.Write($"{array[i]} ");
}