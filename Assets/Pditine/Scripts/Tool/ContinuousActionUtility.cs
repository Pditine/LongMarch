using System.Collections;
using Pditine.Scripts.Tool.Mono;
using UnityEngine;
using UnityEngine.Events;

namespace Pditine.Scripts.Tool
{
    public static class ContinuousActionUtility
    {
        public static Coroutine ContinuousAction(float minTime, float maxTime ,UnityAction action)
        {
            return MonoManager.Instance.StartCoroutine(DoContinuousAction(minTime,maxTime, action));
        }

        public static void StopCoroutine(Coroutine enumerator)
        {
            MonoManager.Instance.StopCoroutine(enumerator);
        }
        
        private static IEnumerator DoContinuousAction(float minTime, float maxTime ,UnityAction action)
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minTime, maxTime));
                action?.Invoke();
            }
        }
    }
}