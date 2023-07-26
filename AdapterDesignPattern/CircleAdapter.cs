namespace AdapterDesignPattern
{
    public class CircleAdapter : IShape
    {
        private readonly Circle _circle;
        public CircleAdapter(Circle circle)
        {
            _circle = circle;
        }

        public void Move()
        {
            Console.WriteLine("change in circle move");
            _circle.Move();
        }
    }
}
