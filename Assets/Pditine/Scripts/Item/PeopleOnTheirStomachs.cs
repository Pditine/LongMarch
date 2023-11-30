using UnityEngine;
using UnityEngine.UI;
using Pditine.Scripts.Tool;

namespace Pditine.Scripts.Item
{
    public class PeopleOnTheirStomachs : ItemBase
    {
        [SerializeField]private Text bulletCountUI;
        private int _bulletCount;
        private Coroutine _fireCoroutine;
        
        private void Start()
        {
            ChangeBulletCount(10);
            _fireCoroutine = ContinuousActionUtility.ContinuousAction(0.5f,3, () =>
            {
                ChangeBulletCount(-1);
            });
        }

        private void ChangeBulletCount(int x)
        {
            if (_bulletCount + x < 0)
            {
                //todo:弹药不够
            }
            else
            {
                _bulletCount += x;
                bulletCountUI.text = "弹药量:"+_bulletCount;
            }
        }

        public void StopFire()
        {
            StopCoroutine(_fireCoroutine);
        }
        
        protected override void PressEAction()
        {
            //todo:check player has ammo or not
            ChangeBulletCount(5);
        }

        protected override void PlayerEnterAction()
        {

        }

        protected override void PlayerExitAction()
        {

        }

        protected override void PlayerStayAction()
        {

        }
    }
}