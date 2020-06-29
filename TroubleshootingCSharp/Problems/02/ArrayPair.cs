namespace TroubleshootingCSharp.Problems._02 {
    /*
     A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
     For example, in array A such that: 
        A[0] = 9 A[1] = 3 A[2] = 9 
        A[3] = 3 A[4] = 9 A[5] = 7 
        A[6] = 9

     the elements at indexes 0 and 2 have value 9,
     the elements at indexes 1 and 3 have value 3,
     the elements at indexes 4 and 6 have value 9,
     the element at index 5 has value 7 and is unpaired.
     Write a function

     Given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element. 
     For example, given array A such that: 
        A[0] = 9 A[1] = 3 A[2] = 9 
        A[3] = 3 A[4] = 9 A[5] = 7 
        A[6] = 9

     The function should return 7, as explained in the example above.
     Write an efficient algorithm for the following assumptions:
     Space complexity O(1) 
     Time complexity O(n) 
     */
    public class ArrayPair {
        /* Input: disregard asymptotic notation */
        private readonly int[] _arrayFixed;
        /* Output */
        private int _oXor; 

        private ArrayPair() {
            this._arrayFixed = new[] {9, 3, 9, 3, 9, 7, 9};
            this._oXor = 0;
        }

        /* Method factory */
        public static ArrayPair Of(){
            return new ArrayPair();
        }
        
        /*
         > Xor
            It is a logical operation between two operands that results in a true logical value if and only if the two operands are different
         > Commutativity
            A xor B = B xor A
         > Note (Xor)
            1º Two equal numbers returns 0
            2º Tells if two bits are different
            3º It is possible to do the reverse operation thus taking the value that underwent operation
        */
        public void Execute() {
            foreach (var value in this._arrayFixed) { //O(n) Time
                this._oXor ^= value; //O(1) Space
            }
        }

        public void Show() {
            System.Console.WriteLine($"Result => [{this._oXor}]");
        }
    }
}