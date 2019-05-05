namespace MowerKata.Entities
{
    public class Mower
    {
        public Coords CurrentCoords { get; set; }
        public char CurrentDirection { get; set; }

        public Mower(Coords currentCoords, char currentDirection)
        {
            CurrentCoords = currentCoords;
            CurrentDirection = currentDirection;
        }

        public void ToRight()
        {
            if (CurrentDirection == 'N')
                CurrentDirection = 'E';
            else if (CurrentDirection == 'E')
                CurrentDirection = 'S';
            else if (CurrentDirection == 'S')
                CurrentDirection = 'W';
            else if (CurrentDirection == 'W')
                CurrentDirection = 'N';
        }


        public void ToLeft()
        {
            if (CurrentDirection == 'N')
                CurrentDirection = 'W';
            else if (CurrentDirection == 'W')
                CurrentDirection = 'S';
            else if (CurrentDirection == 'S')
                CurrentDirection = 'E';
            else if (CurrentDirection == 'E')
                CurrentDirection = 'N';
        }

        public void Forward()
        {
            if (CurrentDirection == 'N')
            {
                ForwardToNorth();
            }
            else if (CurrentDirection == 'E')
            {
                ForwardToRight();
            }
            else if (CurrentDirection == 'W')
            {
                ForwardToLeft();
            }
            else if (CurrentDirection == 'S')
            {
                ForwardToSouth();
            }
        }

        private void ForwardToSouth()
        {
            CurrentCoords.Y -= 1;
        }

        private void ForwardToLeft()
        {
            CurrentCoords.X -= 1;
        }

        private void ForwardToRight()
        {
            CurrentCoords.X += 1;
        }

        private void ForwardToNorth()
        {
            CurrentCoords.Y += 1;
        }
    }
}