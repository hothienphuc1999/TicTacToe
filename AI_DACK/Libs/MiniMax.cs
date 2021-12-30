using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AI_DACK.libs;

namespace AI_DACK.Libs
{
    public class MiniMax
    {
        int n = 0;
        const int INFINITY = 100;
        private int _numOfRow;
        private int _numOfCol;
        private Dictionary<char, int> _scoreTable;
        private int _level;

        public int NumOfRow { get => _numOfRow; set => _numOfRow = value; }
        public int NumOfCol { get => _numOfCol; set => _numOfCol = value; }
        public Dictionary<char, int> ScoreTable { get => _scoreTable; set => _scoreTable = value; }
        public int Level { get => _level; set => _level = value; }

        public MiniMax(int numOfRow, int numOfCol, int level)
        {
            _numOfRow = numOfRow;
            _numOfCol = numOfCol;
            _level = level;
            if (level == 0)
            {
                _scoreTable = new Dictionary<char, int>()
                {
                    {'t',0},
                    {'X',1},
                    {'O',-1},
                    {'n',-10},
                };
            }
            else
            {
                _scoreTable = new Dictionary<char, int>()
                {
                    {'t',0},
                    {'X',5},
                    {'O',-5},
                    {'n',-10},
                };
            }
        }

        char CheckWin(char[,] content)
        {
            // ngang
            for (int i = 0; i < _numOfRow; i++)
                for (int j = 0; j < _numOfCol - 2; j++)
                    if (content[i, j] == content[i, j + 1] && content[i, j + 1] == content[i, j + 2] && content[i, j] != '-')
                        return content[i, j];

            // doc
            for (int i = 0; i < _numOfCol; i++)
                for (int j = 0; j < _numOfRow - 2; j++)
                    if (content[j, i] == content[j + 1, i] && content[j + 1, i] == content[j + 2, i] && content[j, i] != '-')
                        return content[j, i];

            // cheo 1
            for (int i = 0; i < _numOfRow - 2; i++)
                for (int j = 0; j < _numOfCol - 2; j++)
                    if (content[i, j] == content[i + 1, j + 1] && content[i + 1, j + 1] == content[i + 2, j + 2] && content[i, j] != '-')
                        return content[i, j];

            // cheo 2 
            for (int i = 0; i < _numOfRow - 2; i++)
                for (int j = _numOfCol - 1; j > 1; j--)
                    if (content[i, j] == content[i + 1, j - 1] && content[i + 1, j - 1] == content[i + 2, j - 2] && content[i, j] != '-')
                        return content[i, j];

            // not win
            for (int i = 0; i < _numOfRow; i++)
                for (int j = 0; j < _numOfCol; j++)
                    if (content[i, j] == '-')
                        return 'n'; //null

            return 't'; // tie
        }

        int Score(char[,] state)
        {
            char result = CheckWin(state);
            return _scoreTable[result];
        }

        List<Tuple<int, int>> Action(char[,] state)
        {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            for (int i = 0; i < _numOfRow; i++)
            {
                for (int j = 0; j < _numOfCol; j++)
                {
                    if (state[i, j] == '-')
                    {
                        result.Add(Tuple.Create<int, int>(i, j));
                    }
                }
            }
            return result;
        }

        int Max_value(char[,] state, int step)
        {
            //n++;
            step++;
            int scr = Score(state);

            int value = -INFINITY;
            if (scr != -10)
                return _level == 1 ? scr + step : scr;
            foreach (Tuple<int, int> act in Action(state))
            {
                char[,] newState = Helper.DeepCopyChar(state);

                newState[act.Item1, act.Item2] = 'X';
                value = Math.Max(value, Min_value(newState, step));
            }
            return value;
        }

        int Min_value(char[,] state, int step)
        {
            //n++;
            step++;
            int scr = Score(state);

            int value = INFINITY;
            if (scr != -10)
                return _level == 1 ? scr + step : scr;
            foreach (Tuple<int, int> act in Action(state))
            {
                char[,] newState = Helper.DeepCopyChar(state);

                newState[act.Item1, act.Item2] = 'O';
                value = Math.Min(value, Max_value(newState, step));
            }
            return value;
        }

        public Tuple<int, int> MinimaxDecision(Board board, char turn)
        {
            List<Tuple<string, int>> ketqua = new List<Tuple<string, int>>();
            Tuple<int, int> decision = null;

            if (turn == 'X')
            {
                int value = -INFINITY;
                foreach (Tuple<int, int> act in Action(board.Content))
                {
                    char[,] state = Helper.DeepCopyChar(board.Content);
                    state[act.Item1, act.Item2] = 'X';

                    int result = Min_value(state, 1);
                    if (result > value)
                    {
                        value = result;
                        decision = act;
                    }
                }
            }
            else
            {
                int value = INFINITY;
                foreach (Tuple<int, int> act in Action(board.Content))
                {
                    char[,] state = Helper.DeepCopyChar(board.Content);
                    state[act.Item1, act.Item2] = 'O';

                    int result = Max_value(state, 1);
                    ketqua.Add(new Tuple<string, int>(act.ToString(), result));
                    if (result < value)
                    {
                        value = result;
                        decision = act;
                    }
                }
            }
            return decision;
        }
    }
}







