/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
namespace ET
{
    [FriendOf(typeof(IFGUIComponent))]
    public sealed partial class Btn_Test : Entity, IAwake
    {
        public string UIPackageName => this.GetComponent<IFGUIComponent>().UIPackageName;
        public string UIResName => this.GetComponent<IFGUIComponent>().UIResName;
        public string URL => this.GetComponent<IFGUIComponent>().URL;

        [FGUISelfObjectAttribute]
        public GButton self;

        [FGUIObject]
        public GImage Bg;
    }
}