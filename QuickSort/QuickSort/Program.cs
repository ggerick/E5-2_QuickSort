using System;
using static System.Math;//C#6.0 para no poner Math. todo el timepo, y porque se ve más fancy


namespace Quick_Sort
{
    class Program
    {

        public static void Quick_Sort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }

            }

        }

        public static int Partition(double[] arr, int left, int right)
        {
            double pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    double temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        public static void InsertarDatos()//Un metodo para la creacion e insertacionde los datos de arreglos creados
        {

            double[] arr =  { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9};// Se crea un arreglo y se le insertan los valores 

            Console.WriteLine("Arreglo original #1: ");
            foreach (var item in arr)//Imprime los valores del arreglo a como se insertaron
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);//Se manda el arreglo, un 0 que representa los valores a la izquierda y el tamaño del arreglo -1, que van a la derecha y los ordena
            Console.WriteLine("\nArreglo ordenado #1: ");

            foreach (var item in arr)//Se imprime el arreglo ya ordenado
            {
                Console.Write(item + " ");
            }

            //Arreglo 2
            double[] arre = { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };//Creacion y llenado del arreglo

            Console.WriteLine("\n\nArreglo original #2: ");
            foreach (var item in arre)
            {
                Console.Write(item + " ");//Impresion del arreglo original
            }
            Console.WriteLine();

            Quick_Sort(arre, 0, arre.Length - 1);//Se mandan al metodo QuickSort el arreglo, 0 y el tamaño -1
            Console.WriteLine("\nSorted array #2: ");

            foreach (var item in arre)//Se imprime ordenadamente
            {
                Console.Write(item + " ");
            }

            //Arreglo 3
            
            double[] arreg =  {3,7,15,1.34,155,100,15,Sqrt(3),5,3,2 };//Creacion y llenado

            Console.WriteLine("\n\nArreglo original #3: ");
            foreach (var item in arreg)
            {
                Console.Write(item + " ");//Impresion original
            }
            Console.WriteLine();

            Quick_Sort(arreg, 0, arreg.Length - 1);//se mandan los datos
            Console.WriteLine("\nSorted array #3: ");

            foreach (var item in arreg)
            {
                Console.Write(item + " ");//Se imprimen ordenados 
            }

            //Arreglo 4

            double[] arreglo = { 8,19,7,3,15,23,34,27,89,101 };

            Console.WriteLine("\n\nArreglo original #4: ");
            foreach (var item in arreglo)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Quick_Sort(arreglo, 0, arreglo.Length - 1);
            Console.WriteLine("\nSorted array #4: ");

            foreach (var item in arreglo)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }


        static void Main(string[] args)
        {

            InsertarDatos();
        }
    }
}