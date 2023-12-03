using System;
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

        private void Start()
        {
            SpriteRenderer.sprite = notBeEatSprite;
        }

        protected override void PressEAction()
        {
            if (_hasBeenEaten) return;
            _hasBeenEaten = true;
            BeEaten();
        }

        protected override void PlayerEnterAction()
        {
            ProtagonistController.Instance.ShowInteractInfo();
        }

        protected override void PlayerExitAction()
        {
            ProtagonistController.Instance.HideInteractInfo();
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