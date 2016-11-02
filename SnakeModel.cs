using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;

namespace BrainMonitor
{
    class SnakeModel
    {
        private PointPairList body;
        private Direction currentDirection;
        private Action currentAction;
        private Snake snakeGame;
        private int step = 5;
        private int growRate;
        private bool isgameOver, enlarge;
        

        public SnakeModel(Snake snakeGame)
        {
            this.snakeGame = snakeGame;
            body = new PointPairList();
            //must be a list of minimum two points because of drawing
            addToBody(new PointPair(snakeGame.getBorders()[0] / 2, snakeGame.getBorders()[1] / 2));
            addToBody(new PointPair(snakeGame.getBorders()[0] / 2, (snakeGame.getBorders()[1]/ 2)+5));
            addToBody(new PointPair(snakeGame.getBorders()[0] / 2, (snakeGame.getBorders()[1] / 2)+10 ));
            addToBody(new PointPair(snakeGame.getBorders()[0] / 2, (snakeGame.getBorders()[1] / 2) + 15));
            addToBody(new PointPair(snakeGame.getBorders()[0] / 2, (snakeGame.getBorders()[1] / 2) + 20));
            currentDirection = Direction.EAST;
            currentAction = Action.FORWARD;
            isgameOver = false;
            enlarge = false;
            growRate = 50;
            
            
        }

        public Point[] getDrawableSnake()
        {
            Point[] xy = new Point[body.Count];
            int i = 0;
            foreach (PointPair pp in body)
            {
                xy[i] = new Point((int)pp.X, (int)pp.Y);
                i++;
            }

            return xy;
        }


        private void addToBody(PointPair p){
            body.Add(p);
        }

        public void setDirection(Direction dir)
        {
            currentDirection = dir;
        }

        public void setAction(Action act){
            currentAction = act;
        }

        public void moveBody()
        {
            PointPair head = null;
            PointPair temp = new PointPair(100, 100);
            switch (currentAction){         
                case Action.FORWARD:
                    head = body.ElementAt(body.Count-1);
                    switch(currentDirection)
                    {
                        case Direction.EAST:
                            temp = new PointPair(head.X+step, head.Y);
                            break;
                        case Direction.SOUTH:
                            temp = new PointPair(head.X, head.Y + step);
                            break;
                        case Direction.WEST:
                            temp = new PointPair(head.X - step, head.Y);
                            break;
                        case Direction.NORTH:
                            temp = new PointPair(head.X, head.Y - step);
                            break;
                    };
                    break;
                case Action.LEFT:
                    head = body.ElementAt(body.Count-1);
                    switch(currentDirection)
                    {
                        case Direction.EAST:
                            temp = new PointPair(head.X, head.Y-step);
                            break;
                        case Direction.SOUTH:
                            temp = new PointPair(head.X + step, head.Y);
                            break;
                        case Direction.WEST:
                            temp = new PointPair(head.X, head.Y + step);
                            break;
                        case Direction.NORTH:
                            temp = new PointPair(head.X - step, head.Y);
                            break;
                    };
                    updateDirection(-1);                 
                    break;
                case Action.RIGHT:
                    head = body.ElementAt(body.Count-1);
                    switch(currentDirection)
                    {
                        case Direction.EAST:
                            temp = new PointPair(head.X, head.Y + step);
                            break;
                        case Direction.SOUTH:
                            temp = new PointPair(head.X-step, head.Y);
                            break;
                        case Direction.WEST:
                            temp = new PointPair(head.X, head.Y - step);
                            break;
                        case Direction.NORTH:
                            temp = new PointPair(head.X + step, head.Y);
                            break;
                    };
                    updateDirection(1);
                    break;               
            };
            isCollision(temp);
            wallCheck(temp);
            addToBody(temp);
            if (!enlarge)
            {
                body.RemoveAt(0);
            }
            else
            {
                growRate--;
                if (growRate < 0)
                {
                    growRate = 50;
                    enlarge = false;
                }
            }
        }

        private void updateDirection(int dir){
            currentDirection += dir;
            if ((int)currentDirection < 0) currentDirection = Direction.WEST;
            else if ((int)currentDirection > (int)Direction.WEST) currentDirection = Direction.NORTH;
        }

        private void isCollision(PointPair p)
        {
            foreach (PointPair bp in body)
            {
                if (bp.X == p.X && bp.Y == p.Y){
                    isgameOver = true;
                }
            }
        }

        public void wallCheck(PointPair p)
        {
            if (p.X > snakeGame.getBorders()[0]) p.X = 0;
            else if (p.X < 0) p.X = snakeGame.getBorders()[0];
            if(p.Y > snakeGame.getBorders()[1]) p.Y = 0;
            else if( p.Y<0) p.Y = snakeGame.getBorders()[1];
        }

        public bool hitApple(int x, int y, int radius)
        {
            PointPair bp = body.ElementAt(body.Count - 1);
                for (int i = x - radius; i < x + radius; i++)
                {
                    for (int j = y - radius; j < y + radius; j++)
                    {
                        if (bp.X == i && bp.Y == j) return true;
                    }
                }        
            return false; 
        }

        public bool gameOver()
        {
            return isgameOver;
        }

        public void growTheSnake()
        {
            enlarge = true;
        }

        public enum Action
        {
            FORWARD,
            LEFT,
            RIGHT,
        }

        public enum Direction
        {
            NORTH,          
            EAST,
            SOUTH,
            WEST,
        }

    }
}
