using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.UI;

namespace Pditine.Scripts.UI
{
    public class SceneText : MonoBehaviour
    {
        private Text Text => GetComponentInChildren<Text>();

        public void ShowText()
        {
            FadeUtility.FadeInAndStay(Text,50);
        }
    }
}