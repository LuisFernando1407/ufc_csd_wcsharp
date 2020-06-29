using System;
using System.Threading;
using TroubleshootingCSharp.Problems._03.Model;

namespace TroubleshootingCSharp.Problems._03 {
    /*
        Parallel Matrix Multiplication
    */
    public class MatrixParallel {
        private readonly Matrix _matrixSettings;
        private readonly Thread[,] _threads;
        private int[,] _matrixA;
        private int[,] _matrixB;
        private int[,] _matrixResulting;
        
        /* Optional */
        public int FactorA { get; set; } = 100;
        public int FactorB { get; set; } = 200;

        private MatrixParallel(Matrix matrixSettings) {
            this._matrixSettings = matrixSettings;
            this._matrixResulting = new int[this._matrixSettings.LineA, this._matrixSettings.ColumnB];
            this._threads = new Thread[this._matrixSettings.LineA, this._matrixSettings.ColumnB];
        }

        /* Method factory */
        public static MatrixParallel Of(Matrix matrixSettings) {
            return new MatrixParallel(matrixSettings);
        }

        public void Execute() {
            this._matrixA = 
                GenerateRandomMatrix(this.FactorA, this._matrixSettings.LineA, this._matrixSettings.ColumnA);
            this._matrixB = 
                GenerateRandomMatrix(this.FactorB, this._matrixSettings.LineB, this._matrixSettings.ColumnB);

            /* Creates (lineA * columnB) Worker threads. Each thread Calculates a Matrix Value and sets it to matrixResulting */
            for (var i = 0; i < this._matrixSettings.LineA; i++) {
                for (var j = 0; j < this._matrixSettings.ColumnB; j++) {
                    /* Define worker thread */
                    var workerThread = 
                        Util.WorkerThread.Of(this._matrixA, this._matrixB, ref this._matrixResulting);
                    workerThread.Line = i;
                    workerThread.Column = j;
                   
                    /* Execution */
                    this._threads[i, j] = workerThread.Run(); 
                    this._threads[i, j].Start();
                }
            }
        }

        public void Show() {
            System.Console.WriteLine("Parallel - Elements of Matrix A");
            PrintMatrix(this._matrixSettings.LineA, this._matrixSettings.ColumnA, this._matrixA);

            System.Console.WriteLine("Parallel - Elements of Matrix B");
            PrintMatrix(this._matrixSettings.LineB, this._matrixSettings.ColumnB, this._matrixB);

            System.Console.WriteLine("Parallel - Elements of Matrix Resulting (A X B)");
            PrintMatrix(this._matrixSettings.LineA, this._matrixSettings.ColumnB, this._matrixResulting);
        }
        
        private static int[,] GenerateRandomMatrix(int factor, int line, int column) {
            var matrix = new int[line, column];
            for (var i = 0; i < line; i++) {
                for (var j = 0; j < column; j++) {
                    matrix[i, j] = new Random().Next(1, factor);
                }
            }

            return matrix;
        }

        private static void PrintMatrix(int line, int column, int[,] matrix){
            for (var i = 0; i < line; i++){
                for (var j = 0; j < column; j++){
                    System.Console.WriteLine($"[{i}, {j}] = {matrix[i, j]}");
                }
            }
        }

    }
}