using System.Collections.Generic;
using Hmxs.Toolkit.Base.Singleton;
using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Pditine.Scripts
{
    public class ChangeSceneManager : SingletonMono<ChangeSceneManager>
    {
        private Image BlackPanel =>GameObject.Find("BlackPanel").GetComponent<Image>();
        private Text LevelHead =>GameObject.Find("LevelHead").GetComponent<Text>();
        [SerializeField] private List<string> levelHeads = new();
        
        private void Start()
        {
            FadeUtility.FadeOut(BlackPanel,80);
        }

        public void ChangeScene(int levelIndex)
        {
            FadeUtility.FadeInAndStay(BlackPanel,80, () =>
            {
                LevelHead.text = levelHeads[levelIndex];
                FadeUtility.FadeInAndStay(LevelHead,80, () =>
                {
                    FadeUtility.FadeOut(LevelHead,50, () =>
                    {
                        SceneManager.LoadScene(levelIndex);
                    });
                });
            });
        }
        
        public void RePlayLevel(string message,UnityAction callBack)
        {
            FadeUtility.FadeInAndStay(BlackPanel,80, () =>
            {
                LevelHead.text = message;
                FadeUtility.FadeInAndStay(LevelHead,80, () =>
                {
                    FadeUtility.FadeOut(LevelHead,50, () =>
                    {
                        FadeUtility.FadeOut(BlackPanel,80,callBack);
                    });
                });
            });
        }
        
    }
}