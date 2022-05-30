using ExtraSafetyLevels;
using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VRC;

[assembly: MelonInfo(typeof(ExtraSafetyLevelsMod), "Extra Safety Levels", "1.0.0", "Majora")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.Green)]


namespace ExtraSafetyLevels
{
    public class ExtraSafetyLevelsMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(Initialize());
        }
        internal static IEnumerator Initialize()
        {
            while (GameObject.Find("UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/") == null) yield return null;
            var horizontalLayoutGroup = GameObject.Find("UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel").GetComponent<HorizontalLayoutGroup>();
            horizontalLayoutGroup.childControlWidth = true;
            horizontalLayoutGroup.childForceExpandWidth = true;
            new SafetyLevel("Nuisance", Color.grey, UserSocialClass.NegativeTrustLevel1, "<i>Nuisances</i> are confirmed trolls that have been reported/blocked/muted a lot. <i>Nuisances</i> should have the least amount of avatar features visible.").gameObject.transform.SetAsFirstSibling();
            new SafetyLevel("Staff", Color.red, UserSocialClass.DeveloperTrustLevel, "VRChat Team are people who work for VRChat, they are verified Staff.");
            yield return null;
        }
    }
}


