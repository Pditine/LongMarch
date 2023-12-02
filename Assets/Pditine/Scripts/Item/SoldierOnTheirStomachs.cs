using System.Collections.Generic;
using Pditine.Scripts.LevelSceneManager;
using UnityEngine;
using UnityEngine.UI;
using Pditine.Scripts.Tool;
using Random = UnityEngine.Random;

namespace Pditine.Scripts.Item
{
    internal enum SoldierState
    {
        Fire,Rest
    }
    public class SoldierOnTheirStomachs : ItemBase
    {
        [SerializeField]private Text bulletCountUI;
        private int _bulletCount;
        private Coroutine _fireCoroutine;
        [SerializeField] private List<Sprite> sprites = new();
        private SoldierState _state = SoldierState.Fire;
        private Animator Animator => GetComponentInChildren<Animator>();
        private SpriteRenderer SpriteRenderer => GetComponentInChildren<SpriteRenderer>();
        private float _bulletCountIsZeroTime;
        
        private void Start()
        {
            ChangeBulletCount(5);
            Fire();
            ContinuousActionUtility.ContinuousAction(1, 3, ChangeState);
        }

        private void FixedUpdate()
        {
            CheckBulletIsZero();
        }

        private void CheckBulletIsZero()
        {
            if (_bulletCount > 0)
            {
                _bulletCountIsZeroTime = 0;
                return;
            }

            _bulletCountIsZeroTime += Time.deltaTime;
            if(_bulletCountIsZeroTime>3)
                Level1SceneManager.Instance.FailByAmmo();
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

        private void ChangeState()
        {
            if (_state == SoldierState.Fire)
            {
                _state = SoldierState.Rest;
                SpriteRenderer.sprite = sprites[Random.Range(1, sprites.Count)];
                StopFire();
            }
            else
            {
                _state = SoldierState.Fire;
                SpriteRenderer.sprite = sprites[0];
                Fire();
            }
            
        }

        public void Fire()
        {
            _fireCoroutine = ContinuousActionUtility.ContinuousAction(0f,2f, () =>
            {
                ChangeBulletCount(-1);
                Animator.SetTrigger("Fire");
            });
        }

        public void FireOver()
        {
            Animator.SetTrigger("FireOver");
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