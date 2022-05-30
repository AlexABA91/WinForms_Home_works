using System;
using System.Linq;

namespace TagsOnMVP {
    internal interface ITag {
        
        int currentTabIndex { get; set; }
        (int, int) swap { get; set; }
        int InRightPos { get; set; }

        event EventHandler<EventArgs> PosChanger;

        void InitArr();
        void Mixing();
        void Move();
    }
}
