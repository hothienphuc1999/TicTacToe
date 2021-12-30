using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_DACK.libs
{
    public class Board
    {
        private int _width;
        private int _height;
        private int _marginX;
        private int _marginY;
        private int _crossSpace;
        private int _barSpace;
        private int _numOfCol;
        private int _numOfRow;
        private char[,] _content;
        private char _turn;

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
        public int MarginX { get => _marginX; set => _marginX = value; }
        public int MarginY { get => _marginY; set => _marginY = value; }
        public int CrossSpace { get => _crossSpace; set => _crossSpace = value; }
        public int BarSpace { get => _barSpace; set => _barSpace = value; }
        public int NumOfCol { get => _numOfCol; set => _numOfCol = value; }
        public int NumOfRow { get => _numOfRow; set => _numOfRow = value; }
        public char Turn { get => _turn; set => _turn = value; }
        public char[,] Content { get => _content; set => _content = value; }

        public Board(int horizontal, int vertical, int numOfColAndRow)
        {
            int dimension = (horizontal + vertical - Math.Abs(horizontal - vertical)) / 2;
            _width = dimension;
            _height = dimension;
            _marginX = (horizontal - dimension) / 2;
            _marginY = (vertical - dimension) / 2;
            _crossSpace = _height / numOfColAndRow;
            _barSpace = _width / numOfColAndRow;
            _numOfCol = numOfColAndRow;
            _numOfRow = numOfColAndRow;
            _content = new char[_numOfCol, _numOfRow];
            for (int i = 0; i < _numOfRow; i++)
            {
                for (int j = 0; j < _numOfCol; j++)
                {
                    _content[i, j] = '-';
                }
            }
            _turn = 'X';
        }

        public bool IsInside(int x, int y)
        {
            // width == height
            int dimension = _width;
            if (x <= _marginX || x >= dimension + _marginX || y <= _marginY || y >= dimension + _marginY)
                return false;
            else
                return true;
        }

        public void ChangeTurn()
        {
            if (_turn == 'X')
                _turn = 'O';
            else
                _turn = 'X';
        }

        public Tuple<int, int> ConvertPositionXYtoIJ(int posX, int posY)
        {
            if (IsInside(posX, posY))
            {
                int j = (posX - _marginX) / _barSpace;
                int i = (posY - _marginY) / _crossSpace;
                return Tuple.Create<int, int>(i, j);
            }
            return null;
        }
        public Tuple<int, int> ConvertPositionIJtoXY(int posI, int posJ)
        {
            int x = _marginX + _barSpace * posJ;
            int y = _marginY + _crossSpace * posI;
            return Tuple.Create<int, int>(x, y);
        }

        public void ChangeSize(int horizontal, int vertical)
        {
            int dimension = (horizontal + vertical - Math.Abs(horizontal - vertical)) / 2;
            _width = dimension;
            _height = dimension;
            _marginX = (horizontal - dimension) / 2;
            _marginY = (vertical - dimension) / 2;
            _crossSpace = _height / _numOfRow;
            _barSpace = _width / _numOfCol;
        }

        public void ResetContent()
        {
            for (int i = 0; i < _numOfRow; i++)
            {
                for (int j = 0; j < _numOfCol; j++)
                {
                    _content[i, j] = '-';
                }
            }
            _turn = 'X';
        }

        public void TickAt(int posX, int posY, char turn)
        {
            _content[posX, posY] = turn;
        }

        public char CheckWin()
        {
            // ngang
            for (int i = 0; i < _numOfRow; i++)
                for (int j = 0; j < _numOfCol - 2; j++)
                    if (_content[i, j] == _content[i, j + 1] && _content[i, j + 1] == _content[i, j + 2] && _content[i, j] != '-')
                        return _content[i, j];

            // doc
            for (int i = 0; i < _numOfCol; i++)
                for (int j = 0; j < _numOfRow - 2; j++)
                    if (_content[j, i] == _content[j + 1, i] && _content[j + 1, i] == _content[j + 2, i] && _content[j, i] != '-')
                        return _content[j, i];

            // cheo 1
            for (int i = 0; i < _numOfRow - 2; i++)
                for (int j = 0; j < _numOfCol - 2; j++)
                    if (_content[i, j] == _content[i + 1, j + 1] && _content[i + 1, j + 1] == _content[i + 2, j + 2] && _content[i, j] != '-')
                        return _content[i, j];

            // cheo 2 
            for (int i = 0; i < _numOfRow - 2; i++)
                for (int j = _numOfCol - 1; j > 1; j--)
                    if (_content[i, j] == _content[i + 1, j - 1] && _content[i + 1, j - 1] == _content[i + 2, j - 2] && _content[i, j] != '-')
                        return _content[i, j];

            // not win
            for (int i = 0; i < _numOfRow; i++)
                for (int j = 0; j < _numOfCol; j++)
                    if (_content[i, j] == '-')
                        return 'n'; //null

            return 't'; // tie
        }
    }
}
