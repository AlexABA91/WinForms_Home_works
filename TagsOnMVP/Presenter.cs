namespace TagsOnMVP {
    internal class Presenter {
        IView formViev;
        ITag tag;

        public Presenter(ITag _tag, IView form) {
            formViev = form;
            tag = _tag;

            formViev.MixTransfer += new EventHandler<EventArgs>(Mixin!);
            formViev.FieldButtonClick += new EventHandler<EventArgs>(Move!);
            tag.PosChanger += new EventHandler<EventArgs>(PositonChanger!);

            inaitialization();
        }
        void inaitialization() {
            tag.InitArr();
        }
        void Mixin(object sender, EventArgs e) {
            tag.Mixing();
        }

        void PositonChanger(object sender, EventArgs e) {
            formViev.Swap = tag.swap;
            formViev.changeLocationButton();
        }
        void Move(object sender, EventArgs e) {
            tag.currentTabIndex = formViev.CurrentTabIndex;
            tag.Move();
            formViev.InRightPos = tag.InRightPos;
        }
    }
}
