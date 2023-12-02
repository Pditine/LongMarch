using System;
using System.Collections.Generic;
using Hmxs.Toolkit.Base.Singleton;
using Pditine.Scripts.Item;
using UnityEngine;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level1SceneManager : SingletonMono<Level1SceneManager>
    {
        private bool _warIsOver;
        [SerializeField] private List<SoldierOnTheirStomachs> soldiers = new();

        private void Start()
        {
            Invoke(nameof(WarIsOver),80);
        }

        public void FailByDead()
        {
            if (_warIsOver) return;
            _warIsOver = true; 
            ChangeSceneManager.Instance.RePlayLevel("失败——待在敌人的攻击范围外", () =>
            {
                _warIsOver = false;
                foreach (var soldier in soldiers)
                {
                    soldier.ChangeBulletCount(10);
                }
            });
        }

        public void FailByAmmo()
        {
            if (_warIsOver) return;
            _warIsOver = true; 
            ChangeSceneManager.Instance.RePlayLevel("失败——我军战士需要弹药", () =>
            {
                _warIsOver = false;
                foreach (var soldier in soldiers)
                {
                    soldier.ChangeBulletCount(10);
                }
            });
        }

        private void WarIsOver()
        {
            if (_warIsOver) return;
            _warIsOver = true; 
            ChangeSceneManager.Instance.ChangeScene(2);
        }
    }
}