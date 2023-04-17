namespace Calculator.Models
{
    public class GridRef
    {
        public string StrRef { get; set; }
        public char Column { get; }
        public int Row { get; }

        public GridRef(string strRef)
        {
            this.StrRef = strRef;
            this.Column = char.Parse(strRef.Substring(0, 1));
            this.Row = int.Parse(strRef.Substring(1));
        }
    }
}
