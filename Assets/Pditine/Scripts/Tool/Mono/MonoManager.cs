using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Pditine.Scripts.Tool.Mono
{
    public class MonoManager: Singleton<MonoManager>
    {
        private MonoController _controller;

        public MonoManager()
        {
            GameObject obj = new("MonoController");
            _controller = obj.AddComponent<MonoController>();
        }
        
        public void AddUpdateListener(UnityAction fun)
        {
            _controller.AddUpdateListener(fun);
        }

        public void RemoveUpdateListener(UnityAction fun)
        {
            _controller.RemoveUpdateListener(fun);
        }

        public Coroutine StartCoroutine(IEnumerator routine)
        {
            return _controller.StartCoroutine(routine);
        }
    }
}