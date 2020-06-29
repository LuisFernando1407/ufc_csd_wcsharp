namespace TroubleshootingCSharp.Problems._01 {
    /*
        Sort an array in the simplest way
    */
   public class BubbleSort {
       private const int ArrayInitial = 1;
       private const int ArraySorted = 2;
       
       private bool _isSortedArray = false;
       private readonly int[] _arrayFixed;
       
       private BubbleSort() {
           this._arrayFixed = new[] {2, 1, 20, 5, 9, 10, 7, 8, 6, 0, 11};
       }
       
       /* Method factory */
       public static BubbleSort Of(){
           return new BubbleSort();
       }

       public void Execute() {
           this.Show(ArrayInitial);
           /* Descending loop */
           for (var i = (this._arrayFixed.Length - 1); i > 0; i--) { 
               for (var j = 0; j < i; j++) {
                   if (this._arrayFixed[j] > this._arrayFixed[j + 1])
                       Swap(ref this._arrayFixed[j], ref this._arrayFixed[j + 1]);
               }
           }
           this._isSortedArray = true;
       }
       
       public void Show(int state = ArraySorted) { 
           System.Console.Write((state == ArraySorted && this._isSortedArray) ? "Sorted array => " : "Array initial => "); 
           foreach (var value in this._arrayFixed) System.Console.Write($" [{value}]");
           System.Console.WriteLine();
       }

        /* Swapping value from x to y and from y to x */
       private static void Swap(ref int x, ref int y) { 
           var aux = x; 
           x = y; 
           y = aux;
       }
   }
}