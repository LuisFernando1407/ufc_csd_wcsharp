using TroubleshootingCSharp.Problems._01;
using TroubleshootingCSharp.Problems._02;
using TroubleshootingCSharp.Problems._03;
using TroubleshootingCSharp.Problems._03.Model;

namespace TroubleshootingCSharp {
    internal class MainApplication {
        public static void Main(string[] args) {
            /* Problem 01 = Bubble Sort */      
            System.Console.WriteLine("Problem 01 = Bubble Sort");
            var bubbleSort = BubbleSort.Of();
            bubbleSort.Execute();
            bubbleSort.Show();
            /*
             * Console 
             * Array initial =>  [2] [1] [20] [5] [9] [10] [7] [8] [6] [0] [11]
             * Sorted array =>  [0] [1] [2] [5] [6] [7] [8] [9] [10] [11] [20]
             */
            
            
            /* Problem 02 = Array pair */
            System.Console.WriteLine("\nProblem 02 = Array pair");
            var arrayPair = ArrayPair.Of();
            arrayPair.Execute();
            arrayPair.Show();
            /*
            * Console 
            * Result =>  [7]
            */
            
            /* Problem 03 = Matrix Parallel */
            System.Console.WriteLine("\nProblem 03 = Matrix Parallel");
            
            /* Matrix settings */
            var matrix = Matrix.Of(
                lineA: 2,
                columnA: 2,
                lineB: 2,
                columnB: 2
            );

            var matrixParallel = MatrixParallel.Of(matrix);
            
            /* Factor (Optional) */
            matrixParallel.FactorA = 10;
            matrixParallel.FactorB = 20;
            
            matrixParallel.Execute();
            matrixParallel.Show();
            /*
            * Console: Example A(2x2), B(2x2)
            * Parallel - Elements of Matrix A
            *   [0, 0] = 9
            *   [0, 1] = 2
            *   [1, 0] = 7
            *   [1, 1] = 4
            *  Parallel - Elements of Matrix B
            *   [0, 0] = 18
            *   [0, 1] = 16
            *   [1, 0] = 18
            *   [1, 1] = 3
            *  Parallel - Elements of Matrix Resulting (A X B)
            *   [0, 0] = 198
            *   [0, 1] = 150
            *   [1, 0] = 198
            *   [1, 1] = 124
            */
        }
    }
}