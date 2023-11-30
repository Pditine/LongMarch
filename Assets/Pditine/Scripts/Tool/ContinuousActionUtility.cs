using System.Collections;
using Pditine.Scripts.Tool.Mono;
using UnityEngine;
using UnityEngine.Events;

namespace Pditine.Scripts.Tool
{
    public static class ContinuousActionUtility
    {
        public static Coroutine ContinuousAction(float timeRange ,UnityAction action)
        {
            return MonoManager.Instance.StartCoroutine(DoContinuousAction(timeRange, action));
        }
        
        private static IEnumerator DoContinuousAction(float timeRange ,UnityAction action)
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(0f, timeRange));
                action?.Invoke();
            }
        }
    }
}