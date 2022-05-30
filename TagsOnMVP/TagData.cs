using System.Diagnostics;

namespace TagsOnMVP {
    public class TagData : ITag {
      
        
        public event EventHandler<EventArgs>? PosChanger;

        public (int, int) swap { get; set; }
        public int currentTabIndex { get; set; }
        public int InRightPos { get; set; }

        const int FS = 4;
        const int WIN = FS * FS - 1;
        int[,] arrField;
      
        enum movederection : int { UP = 0, LEFT, DOWN, RIGHT }

        public TagData() {
            arrField = new int[FS, FS];
        }

        public void InitArr() {
            Array.Clear(arrField, 0, FS);
            int index = 1;
            for (int i = 0; i < FS; i++)
                for (int j = 0; j < FS; index++, j++) {
                    arrField[i, j] = index;
                    if (index == FS * FS - 1) break;
                }
        }
        public void Mixing() {
            Mixer(0, 100, (FS - 1, FS - 1));
        }

        int Mixer(int moveSite, int mixStepCount, (int y, int x) posInArr) {

            if (mixStepCount == 0) return mixStepCount;

            Random r = new Random();
            moveSite = r.Next(0, 4);

            switch ((movederection)moveSite) {
                case movederection.UP:
                    var (y, x) = posInArr;
                    if (!(y - 1 < 0)) {
                        var newPosInArr = (y - 1, x);
                        PositionSwopArr(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;

                case movederection.LEFT:
                    (y, x) = posInArr;
                    if (!(x + 1 > FS - 1)) {
                        var newPosInArr = (y, x + 1);
                        PositionSwopArr(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;
                case movederection.DOWN:
                    (y, x) = posInArr;
                    if (!(y + 1 > FS - 1)) {
                        var newPosInArr = (y + 1, x);
                        PositionSwopArr(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;
                case movederection.RIGHT:
                    (y, x) = posInArr;
                    if (!(x - 1 < 0)) {
                        var newPosInArr = (y, x - 1);
                        PositionSwopArr(posInArr, newPosInArr);
                        posInArr = newPosInArr;
                        --mixStepCount;
                    }
                    break;
            }
            Mixer(moveSite, mixStepCount, posInArr);
            return 0;
        }
        void PositionSwopArr((int y, int x) posInArr, (int y, int x) newPosInArr) {
            var oldPos = arrField[posInArr.y, posInArr.x];
            var newPos = arrField[newPosInArr.y, newPosInArr.x];

            arrField[posInArr.y, posInArr.x] = newPos;
            arrField[newPosInArr.y, newPosInArr.x] = oldPos;

            swap = (oldPos, newPos);
            PosChanger?.Invoke(this, EventArgs.Empty);
        }

        public void Move() {
            var posInArr = GetPositionInArr();
            if (TryChange(posInArr)) {
                 RightPositionCheckr();
            };
        }
        
        (int, int) GetPositionInArr() {
            for (int i = 0; i < FS; i++)
                for (int j = 0; j < FS; j++) {
                    if (arrField[i, j] == currentTabIndex) {
                        return (i, j);
                    }
                }
            throw new ArgumentNullException("Somtens Wron Whit ", nameof(currentTabIndex));


        }
        bool TryChange((int y, int x) t) {

            var (y, x) = t;
            if (y - 1 >= 0)
                if (arrField[y - 1, x] == 0) {
                    var newPosInArr = (y - 1, x);
                    PositionSwopArr(t, newPosInArr);
                    return true;
                }

            if (y + 1 < FS)
                if (arrField[y + 1, x] == 0) {
                    var newPosInArr = (y + 1, x);
                    PositionSwopArr(t, newPosInArr);
                    return true;
                }

            if (x - 1 >= 0)
                if (arrField[y, x - 1] == 0) {
                    var newPosInArr = (y, x - 1);
                    PositionSwopArr(t, newPosInArr);
                    return true;
                }

            if (x + 1 < FS)
                if (arrField[y, x + 1] == 0) {
                    var newPosInArr = (y, x + 1);
                    PositionSwopArr(t, newPosInArr);
                    return true;
                }
            return false;
        }
        void RightPositionCheckr() {
            int count = 0;
            int index = 1; ;
            for (int i = 0; i < FS; ++i)
                for (int j = 0; j < FS; ++index, ++j) {
                    if (arrField[i, j] == index)
                        ++count;
                }
            InRightPos = count;
        }
    }
}