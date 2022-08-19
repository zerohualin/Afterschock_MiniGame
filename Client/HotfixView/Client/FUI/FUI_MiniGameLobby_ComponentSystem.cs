/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using Cfg;
namespace ET
{
    public static class FUI_MiniGameLobby_ComponentSystem
    {
        public static void Init(this FUI_MiniGameLobby_Component self)
        {
        }
    }

    [FGUIEvent(FGUIType.AFKBattle)]
    [FriendOf(typeof(FUI_MiniGameLobby_Component))]
    [ComponentOf(typeof(FGUIEntity))]
    [FriendOf(typeof(Btn_Test))]
    public class FUI_MiniGameLobby_ComponentEvent: FGUIEvent<FUI_MiniGameLobby_Component>
    {
        public override void OnCreate(FUI_MiniGameLobby_Component component)
        {
            component.Bnt_Test.self.AddListener(() =>
            {
                Log.Error("我点击了测试哦");
            });
        }
        public override void OnShow(FUI_MiniGameLobby_Component component){}
        public override void OnRefresh(FUI_MiniGameLobby_Component component){}
        public override void OnHide(FUI_MiniGameLobby_Component component){}
        public override void OnDestroy(FUI_MiniGameLobby_Component component){}
    }
}