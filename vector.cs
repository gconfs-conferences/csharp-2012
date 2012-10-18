public class Vector
{
    public int x;
    public int y;

    public function Add(R2Vector vect)
    {
        x += vect.x;
        y += vect.y;
    }
    public function Print()
    {
        Console.writeLine(
            "X: " + x.ToString() + 
            " Y: " + y.ToString());
    }
}
