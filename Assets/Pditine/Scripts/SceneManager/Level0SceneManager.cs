using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Pditine.Scripts.SceneManager
{
    public class Level0SceneManager : MonoBehaviour
    {
        [SerializeField] private Image logUI;
        [SerializeField] private Image playUI;
        [SerializeField] private Image exitUI;

        public void Play()
        {
            FadeUtility.FadeInAndStay(logUI,60);
            FadeUtility.FadeOut(playUI,100);
            FadeUtility.FadeOut(exitUI,100);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}