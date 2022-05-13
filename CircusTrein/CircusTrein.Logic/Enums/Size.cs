namespace CircusTrein.Logic.Enums
{
    public class Size
    {
        public enum SizeEnum
        {
            Small,
            Medium,
            Large
        }
        public SizeEnum GenerateSize()
        {
            Random rnd = new Random();
            int size = rnd.Next(0, 3);
            return (SizeEnum)size;
        }
    }
}
