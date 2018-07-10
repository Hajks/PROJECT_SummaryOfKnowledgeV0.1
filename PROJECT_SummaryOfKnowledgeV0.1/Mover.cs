using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PROJECT_SummaryOfKnowledgeV0._1
{
    enum Direction
    {
        Up,
        Down,
        Right,
        Left,
    }
    abstract class Mover
    {
        protected Game game;
        protected Point location;
        public Point Location { get { return location; } }

        public Mover (Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }
        public bool Nearby (Point locationToCheck, int distance)
        {
            if (Math.Abs(Location.X - locationToCheck.X) < distance && (Math.Abs(Location.Y - locationToCheck.Y) < distance))
                return true;
            else
                return false;
        }
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch(direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                        break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval >= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval >= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }
    }
}
