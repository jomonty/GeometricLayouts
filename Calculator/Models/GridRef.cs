using System.Text.Json.Serialization;

namespace Calculator.Models
{
    public class GridRef
    {
        public string StrRef { get; set; }
        public char Row { get; }
        public int Col { get; }

        public GridRef(string strRef)
        {
            // Construct from string GridRef of form "A1", "F12",
            // parse to respective char (row) and int (col) representations
            this.StrRef = strRef;
            this.Row = char.Parse(strRef.Substring(0, 1).ToUpper());
            this.Col = int.Parse(strRef.Substring(1));
        }

        public GridRef(char row, int col)
        {
            // Parse from char row and int col references,
            // parse to string representation
            this.Row = row;
            this.Col = col;
            this.StrRef = row.ToString() + col.ToString();
        }
    }
}
