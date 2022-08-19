/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

namespace ET
{
    [FriendOf(typeof(IFGUIComponent))]
    public class FUI_MiniGameLobby_ComponentAwakeSystem : AwakeSystem<FUI_MiniGameLobby_Component>
    {
        protected override void Awake(FUI_MiniGameLobby_Component self)
        {
            var IFGUIComponent = self.AddComponent<IFGUIComponent>();
            IFGUIComponent.UIPackageName = "MiniGame";
            IFGUIComponent.UIResName = "FUI_MiniGameLobby_Component";
            IFGUIComponent.URL = "ui://udfeo6i9o2kn3";
        }
    }
}