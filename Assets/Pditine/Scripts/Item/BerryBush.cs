using System;
using UnityEngine;

namespace Pditine.Scripts.Item
{
    public class BerryBush : ItemBase
    {
        [SerializeField] private Sprite notBeEatSprite;
        [SerializeField] private Sprite hasBeenEatenSprite;
        private SpriteRenderer SpriteRenderer => GetComponent<SpriteRenderer>();

        private void Start()
        {
            SpriteRenderer.sprite = notBeEatSprite;
        }

        protected override void PressEAction()
        {
            BeEaten();
        }

        protected override void PlayerEnterAction()
        {
            //todo:玩家头上的E   
        }

        protected override void PlayerExitAction()
        {
            //todo:玩家头上的E   
        }

        protected override void PlayerStayAction()
        {

        }
        

        private void BeEaten()
        {
            //todo:玩家恢复饥饿值
            SpriteRenderer.sprite = hasBeenEatenSprite;
        }
    }
}