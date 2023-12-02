﻿using System.Collections.Generic;
using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.UI;
namespace Pditine.Scripts
{
    public class ChangeSceneManager : MonoBehaviour
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
                        UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
                    });
                });
            });
        }
        
        
    }
}