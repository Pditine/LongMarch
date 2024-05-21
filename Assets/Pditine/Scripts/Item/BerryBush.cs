using System;
using HighlightPlus2D;
using Hmxs.Scripts.Protagonist;
using UnityEngine;

namespace Pditine.Scripts.Item
{
    public class BerryBush : ItemBase
    {
        [SerializeField] private Sprite notBeEatSprite;
        [SerializeField] private Sprite hasBeenEatenSprite;
        private bool _hasBeenEaten;
        private SpriteRenderer SpriteRenderer => GetComponent<SpriteRenderer>();

        public HighlightEffect2D highlightEffect;

        private void Start()
        {
            SpriteRenderer.sprite = notBeEatSprite;
        }

        protected override void PressEAction()
        {
            if (_hasBeenEaten) return;
            _hasBeenEaten = true;
            highlightEffect.highlighted = false;
            BeEaten();
        }

        protected override void PlayerEnterAction()
        {
            highlightEffect.highlighted = true;
        }

        protected override void PlayerExitAction()
        {
            highlightEffect.highlighted = false;
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