using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.UI;

namespace Pditine.Scripts.SceneManager
{
    public class Level1SceneManager : MonoSingleton<Level1SceneManager>
    {
        [SerializeField] private Image blackPanel;
        [SerializeField] private Text levelHead;
        
        public void FailByDead()
        {
            ChangeSceneManager.Instance.ChangeScene("失败——站在敌人攻击范围外");
        }

        public void FireByNoAmmo()
        {
            ChangeSceneManager.Instance.ChangeScene("失败——我军战士缺少子弹");
        }
    }
}