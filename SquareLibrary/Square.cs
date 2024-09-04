namespace SquareLibrary
{
    /// <summary>
    /// Класс для работы с квадратом.
    /// </summary>
    public class Square
    {
        private double side;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Square"/>.
        /// </summary>
        /// <param name="side"> Сторона квадрата. </param>
        /// <exception cref="ArgumentException">Если сторона меньше или равна 0. </exception>
        public Square(double side)
        {
            this.Id = new Guid();
            this.Side = side;
        }

        public Guid Id { get; }
        public double Side 
        {
            get => this.side;
            set
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона должна больше 0");
                }

                this.side = value;
            } 
        }
        public override string ToString() => $"{this.Side}";
    }
}
