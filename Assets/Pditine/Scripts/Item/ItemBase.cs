using System;
using UnityEngine;
using UnityEngine.Events;

namespace Pditine.Scripts.Item
{
    public abstract class ItemBase : MonoBehaviour
    {
        protected abstract void PressEAction();
        protected abstract void PlayerEnterAction();
        protected abstract void PlayerExitAction();
        protected abstract void PlayerStayAction();
        private bool _canStayAction;
        
        private void Update()
        {
            if (_canStayAction)
            {
                PlayerStayAction();
            }
            if (_canStayAction&& Input.GetKeyDown(KeyCode.E))
            {
                PressEAction();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.CompareTag("Player"))
            {
                _canStayAction = true;
                PlayerEnterAction();
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if(other.CompareTag("Player"))
            {
                _canStayAction = false;
                PlayerExitAction();
            }
        }
        
    }
}