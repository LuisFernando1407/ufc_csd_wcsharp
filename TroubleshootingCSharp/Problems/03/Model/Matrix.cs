namespace TroubleshootingCSharp.Problems._03.Model {
    public class Matrix
    {
        private Matrix(int lineA, int columnA, int lineB, int columnB) {
            this.LineA = lineA;
            this.ColumnA = columnA;
            this.LineB = lineB;
            this.ColumnB = columnB;
        }

        /* Method factory */
        public static Matrix Of(int lineA, int columnA, int lineB, int columnB) {
            return new Matrix(lineA, columnA, lineB, columnB);
        }
        
        /* Getters and Setters */
        public int LineA { get; private set; }

        public int LineB { get; private set; }

        public int ColumnA { get; private set; }

        public int ColumnB { get; private set; }
    }
}