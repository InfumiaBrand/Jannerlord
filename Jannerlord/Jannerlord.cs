using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace Jannerlord{

    public class JannerlordSubModule : MBSubModuleBase{

        protected override void OnSubModuleLoad(){
            InformationManager.DisplayMessage(new InformationMessage("Hello world!"));
        }
    }

}