using Hmxs.Toolkit.Base.Singleton;
using UnityEngine;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level1SceneManager : SingletonMono<Level1SceneManager>
    {
        public void FailByDead()
        {
            ChangeSceneManager.Instance.RePlayLevel("失败——待在敌人的攻击范围外");
        }
    }
}