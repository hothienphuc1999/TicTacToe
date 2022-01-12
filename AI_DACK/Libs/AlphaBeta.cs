using AI_DACK.libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_DACK.Libs
{
    class AlphaBeta
    {
        //Khai báo biến
        int n = 0;
        const int INFINITY = 100;

        //Khai báo số hàng và số cột
        private int _numOfRow;
        private int _numOfCol;

        //Khai báo bảng điểm và mức độ khó
        private Dictionary<char, int> _scoreTable;
        private int _level;

        public int NumOfRow { get => _numOfRow; set => _numOfRow = value; }
        public int NumOfCol { get => _numOfCol; set => _numOfCol = value; }
        public Dictionary<char, int> ScoreTable { get => _scoreTable; set => _scoreTable = value; }
        public int Level { get => _level; set => _level = value; }

        // Khỏi tạo
        public AlphaBeta(int numOfRow, int numOfCol, int level)
        {
            _numOfRow = numOfRow;
            _numOfCol = numOfCol;
            _level = level;

            // Khỏi tạo bảng điểm
            _scoreTable = new Dictionary<char, int>()
                {
                    {'t',0}, // hòa
                    {'X',5}, // X thắng
                    {'O',-5}, // O thắng
                    {'n',-10}, // Không xác định
                };
        }

        // Kiểm tra thắng thua
        char CheckWin(char[,] content)
        {
            // duyệt theo hàng ngang
            for (int i = 0; i < _numOfRow; i++)
                for (int j = 0; j < _numOfCol - 2; j++)
                    if (content[i, j] == content[i, j + 1] && content[i, j + 1] == content[i, j + 2] && content[i, j] != '-')
                        return content[i, j];

            // duyệt theo hàng dọc
            for (int i = 0; i < _numOfCol; i++)
                for (int j = 0; j < _numOfRow - 2; j++)
                    if (content[j, i] == content[j + 1, i] && content[j + 1, i] == content[j + 2, i] && content[j, i] != '-')
                        return content[j, i];

            // duyệt theo đường chéo
            for (int i = 0; i < _numOfRow - 2; i++)
                for (int j = 0; j < _numOfCol - 2; j++)
                    if (content[i, j] == content[i + 1, j + 1] && content[i + 1, j + 1] == content[i + 2, j + 2] && content[i, j] != '-')
                        return content[i, j];
            for (int i = 0; i < _numOfRow - 2; i++)
                for (int j = _numOfCol - 1; j > 1; j--)
                    if (content[i, j] == content[i + 1, j - 1] && content[i + 1, j - 1] == content[i + 2, j - 2] && content[i, j] != '-')
                        return content[i, j];

            // Chưa xác định
            for (int i = 0; i < _numOfRow; i++)
                for (int j = 0; j < _numOfCol; j++)
                    if (content[i, j] == '-')
                        return 'n'; //null

            return 't'; // hòa
        }

        // Tính điểm
        int Score(char[,] state)
        {   
            // State là trạng thái của bàn cờ

            // checkwin người thắng
            char result = CheckWin(state);
            
            // trả về điểm
            return _scoreTable[result];
        }

        // Tìm các ô trống để đánh
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

        // Alpha Beta Pruning

        int Max_value(char[,] state, int step, ref int alpha, ref int beta)
        {

            n++;

            // độ sâu +1 nếu càng xuống sâu
            step++;
            int scr = Score(state);

            int value = -INFINITY;

            // Nếu bàn cờ đã xác định
            if (scr != -10)
                return _level == 1 ? scr + step : scr; // Nếu độ khó = 1 thì trả về điểm + độ sâu
            
            // Duyệt các nước có thể đi
            foreach (Tuple<int, int> act in Action(state))
            {
                // deep copy mảng: cứ mỗi trạng thái, là 1 deep copy
                char[,] newState = Helper.DeepCopyChar(state);

                // Hàm max gọi hàm Min vào xử lí
                newState[act.Item1, act.Item2] = 'X';
                value = Math.Max(value, Min_value(newState, step, ref alpha, ref beta));
                
                // Tỉa nhánh khi value >= beta
                if (value >= beta)
                    return value;

                // cập nhật alpha
                alpha = Math.Max(alpha, value);
            }
            return value;
        }

        int Min_value(char[,] state, int step, ref int alpha, ref int beta)
        {
            n++;

            step++;
            int scr = Score(state);

            int value = INFINITY;
            if (scr != -10)
                return _level == 1 ? scr + step : scr; // lay max trong tat ca min
            foreach (Tuple<int, int> act in Action(state))
            {
                char[,] newState = Helper.DeepCopyChar(state);

                newState[act.Item1, act.Item2] = 'O';
                value = Math.Min(value, Max_value(newState, step, ref alpha, ref beta));


                if (value <= alpha)
                    return value;

                beta = Math.Min(beta, value);
            }
            return value;
        }


        public Tuple<int, int> AlphaBetaDecision(Board board, char turn)
        {
            int positveInf = 100;
            int negativeInf = -100;

            List<Tuple<string, int>> ketqua = new List<Tuple<string, int>>();
            Tuple<int, int> decision = null;

            if (turn == 'X') // Nếu lượt đi là X thì tìm max trong các Min
            {
                int value = -INFINITY;
                foreach (Tuple<int, int> act in Action(board.Content))
                {
                    char[,] state = Helper.DeepCopyChar(board.Content);
                    state[act.Item1, act.Item2] = 'X';

                    int result = Min_value(state, 1, ref negativeInf, ref positveInf);
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

                    int result = Max_value(state, 1, ref negativeInf, ref positveInf);
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

