using System;
using Hmxs.Toolkit.Base.Singleton;
using UnityEngine;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level1SceneManager : SingletonMono<Level1SceneManager>
    {
        private bool _warIsOver;

        private void Start()
        {
            Invoke(nameof(WarIsOver),100);
        }

        public void FailByDead()
        {
            if (_warIsOver) return;
            _warIsOver = true; 
            ChangeSceneManager.Instance.RePlayLevel("失败——待在敌人的攻击范围外");
        }

        public void FailByAmmo()
        {
            if (_warIsOver) return;
            _warIsOver = true; 
            ChangeSceneManager.Instance.RePlayLevel("失败——我军战士需要弹药");
        }

        private void WarIsOver()
        {
            if (_warIsOver) return;
            _warIsOver = true; 
            ChangeSceneManager.Instance.ChangeScene(2);
        }
    }
}