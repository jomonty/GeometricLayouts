namespace Calculator.Models
{
    public class GridRef
    {
        public string StrRef { get; set; }
        public char Row { get; }
        public int Col { get; }
        

        public GridRef(string strRef)
        {
            this.StrRef = strRef;
            this.Row = char.Parse(strRef.Substring(0, 1).ToUpper());
            this.Col = int.Parse(strRef.Substring(1));
        }
    }
}
