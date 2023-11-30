using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Pditine.Scripts.Item
{
    public class PeopleOnTheirStomachs : ItemBase
    {
        private Text _bulletCountUI;
        private int _bulletCount;

        private void Start()
        {
            ChangeBulletCount(10);
            StartCoroutine(ContinuousReduceBulletCount());
        }

        private void ChangeBulletCount(int x)
        {
            if (_bulletCount - x < 0)
            {
                //todo:弹药不够
            }
            else
            {
                _bulletCount += x;
                _bulletCountUI.text = _bulletCount.ToString();
            }
        }

        public void StopFire()
        {
            StopCoroutine(ContinuousReduceBulletCount());
        }
        
        private IEnumerator ContinuousReduceBulletCount()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(0, 2f));
                ChangeBulletCount(-1);
            }
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