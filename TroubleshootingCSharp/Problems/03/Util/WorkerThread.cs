using System.Threading;

namespace TroubleshootingCSharp.Problems._03.Util {
    public class WorkerThread {
        public int Line { get; set; }
        public int Column { get; set; }
        
        private int[,] MatrixA { get; set; }
        private int[,] MatrixB { get; set; }
        private int[,] MatrixResulting { get; set; }

        private WorkerThread(int[,] matrixA, int[,] matrixB, int[,] matrixResulting) {
            this.MatrixA = matrixA;
            this.MatrixB = matrixB;
            this.MatrixResulting = matrixResulting;
        }

        /* Method factory */
        public static WorkerThread Of(int[,] matrixA, int[,] matrixB, ref int[,] matrixResulting) {
            return new WorkerThread(matrixA, matrixB, matrixResulting);
        }
        
        public Thread Run() {
            return new Thread(Operation);
        }

        private void Operation() {
            this.MatrixResulting[this.Line, this.Column] =
                (this.MatrixA[this.Line, 0] * this.MatrixB[0, this.Column]) +
                (this.MatrixA[this.Line, 1] * this.MatrixB[1, this.Column]);
        }
    }
}