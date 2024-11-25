using MelonLoader;
using Il2CppSirenix.OdinInspector;
using UnityEngine;
using Il2CppWadality.Core.SOTemplates;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace wadamod
{
    public class MyMod : MelonMod
    {
        
        public override void OnInitializeMelon()
        {
			//     --Verify init--
            LoggerInstance.Msg("WADAMOD V1 | GREETINGS FROM HELL, MICHIGAN");
			//     --create SObjects--
            MenuBoardPage modMenu = SerializedScriptableObject.CreateInstance<MenuBoardPage>();
			SerializedScriptableObject wyNot = SerializedScriptableObject.CreateInstance<MenuBoardPage>();
			WeaponMenu customRadial = SerializedScriptableObject.CreateInstance<WeaponMenu>();
			GameMap inGameStomach = new GameMap();
			inGameStomach.displayName = "Stomach";
			inGameStomach.sceneName = "stomach";
			
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            LoggerInstance.Msg($"Scene {sceneName} with build index {buildIndex} has been loaded!");
        }
    }
}