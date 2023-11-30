using UnityEngine;
using UnityEngine.Events;

namespace Pditine.Scripts.Tool.Mono
{
    public class MonoController: MonoBehaviour
    {
        private event UnityAction UpdateEvent;
        
        
        
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            UpdateEvent?.Invoke();
        }

        public void AddUpdateListener(UnityAction fun)
        {
            UpdateEvent += fun;
        }

        public void RemoveUpdateListener(UnityAction fun)
        {
            UpdateEvent -= fun;
        }
    }
}