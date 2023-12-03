using System;
using Hmxs.Scripts.Protagonist;
using Hmxs.Toolkit.Flow.FungusTools;
using Hmxs.Toolkit.Module.Audios;
using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.UI;
using AudioType = Hmxs.Toolkit.Module.Audios.AudioType;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level0SceneManager : MonoBehaviour
    {
        [SerializeField] private Image logUI;
        [SerializeField] private Image playUI;
        [SerializeField] private Image exitUI;
        //[SerializeField] private ProtagonistController player;

        private void Start()
        {
            AudioCenter.Instance.AudioPlaySync(new AudioAsset(AudioType.BGM,"纯音乐 - 红星照我去战斗", isLoop: true));
        }

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
            ProtagonistController.Instance.enabled = true;
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}