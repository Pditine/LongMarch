using System;
using UnityEngine;

namespace Pditine.Scripts.Item
{
    public class BerryBush : MonoBehaviour
    {
        [SerializeField] private Sprite notBeEatSprite;
        [SerializeField] private Sprite hasBeenEatenSprite;
        private SpriteRenderer SpriteRenderer => GetComponent<SpriteRenderer>();
        private bool _canBeEaten;

        private void OnTriggerEnter2D(Collider2D other)
        {

            if (other.CompareTag("Player"))
            {
                //todo:玩家头上的E   
                _canBeEaten = true;
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                //todo:玩家头上的E   
                _canBeEaten = false;
            }

        }

        private void Update()
        {
            if (_canBeEaten)
                BeEaten();
        }

        private void BeEaten()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //todo:玩家恢复饥饿值
                SpriteRenderer.sprite = hasBeenEatenSprite;
            }
        }
    }
}