using UnityEngine;

namespace ExtraSafetyLevels
{
    internal class SafetyLevel
    {
        public GameObject gameObject;
        public SafetyLevel(string safetyName, UnityEngine.Color color, VRC.UserSocialClass socialClass, string description)
        {
            gameObject = GameObject.Instantiate(GameObject.Find("UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor"), GameObject.Find("UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel").transform);
            gameObject.name = $"Button_{safetyName}";
            var image = gameObject.GetComponent<UnityEngine.UI.Image>();
            var text = gameObject.GetComponentInChildren<UnityEngine.UI.Text>();
            var rankToggle = gameObject.GetComponent<UiSafetyRankToggle>();
            image.color = color;
            text.text = safetyName;
            rankToggle.field_Public_UserSocialClass_0 = socialClass;
            rankToggle.field_Public_String_0 = description;
        }
    }
}