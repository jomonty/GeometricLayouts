namespace Calculator.Models
{
    public class GridRef
    {
        public string StrRef { get; set; }
        public char Row { get; }
        public int Col { get; }
        
        public GridRef(string strRef)
        {
            // Parse string GridRef of form "A1", "F12" to
            // respective char (row) and int (col) representations
            this.StrRef = strRef;
            this.Row = char.Parse(strRef.Substring(0, 1).ToUpper());
            this.Col = int.Parse(strRef.Substring(1));
        }
    }
}
