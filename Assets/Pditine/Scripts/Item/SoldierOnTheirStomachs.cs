using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pditine.Scripts.Tool;
using UnityEngine.Serialization;

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
<<<<<<< HEAD
<<<<<<< HEAD
        private Animator Animator => GetComponent<Animator>();
=======
>>>>>>> parent of 652754f (test war scene)
=======
        private Animator Animator => GetComponentInChildren<Animator>();
>>>>>>> parent of 5147193 (find coroutine problem)
        private SpriteRenderer SpriteRenderer => GetComponentInChildren<SpriteRenderer>();
        
        private void Start()
        {
            ChangeBulletCount(10);
            Fire();
            ContinuousActionUtility.ContinuousAction(1, 3, ChangeState);
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
            });
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