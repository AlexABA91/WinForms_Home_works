using System;
using System.Linq;

namespace TagsOnMVP {
    internal interface IView {

        
        event EventHandler<EventArgs> MixTransfer;
        event EventHandler<EventArgs> FieldButtonClick;

     
        public int CurrentTabIndex { get; set; }
         (int, int) Swap { get; set; }
         int InRightPos { get; set; }

        void changeLocationButton();
    }
}
