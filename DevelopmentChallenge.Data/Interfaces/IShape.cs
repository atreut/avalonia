namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IShape
    {
        string ShapeName { get; }
        decimal Area();
        decimal Perimeter();
        ShapeType Type { get; }
        
    }
}
