using Hmxs.Scripts.Protagonist;
using Hmxs.Toolkit.Flow.FungusTools;
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
        [SerializeField] private ProtagonistController player;

        public void Play()
        {
            FadeUtility.FadeInAndStay(logUI,60);
            FadeUtility.FadeOut(playUI,100);
            FadeUtility.FadeOut(exitUI,100);
            Invoke(nameof(PlayerCanMove),4f);
            FlowchartManager.ExecuteBlock("GameStart");
        }

        private void PlayerCanMove()
        {
            player.enabled = true;
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}