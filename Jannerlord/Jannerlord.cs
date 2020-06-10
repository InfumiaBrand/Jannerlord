using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace Jannerlord{

    public class JannerlordSubModule : MBSubModuleBase {

        protected override void OnSubModuleLoad(){
            Module.CurrentModule.AddInitialStateOption(
                new InitialStateOption("TestMainMenuOption", new TextObject("Click me!", null), 9990, () => {
                    InformationManager.DisplayMessage(new InformationMessage("Hello world!"));
                }, false));
        }

    }

}