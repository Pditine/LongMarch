using System.Collections;
using Hmxs.Toolkit.Flow.Timer;
using Pditine.Scripts.Tool;
using UnityEngine;

namespace Pditine.Scripts.WarScene
{
    public class EnemyManager : MonoBehaviour
    {
        [SerializeField] private GameObject enemy;
        [SerializeField] private Transform leftPoint;
        [SerializeField] private Transform rightPoint;
        [SerializeField] private Transform brithPoint;
        private Coroutine _createEnemyCoroutine;

        private void Start()
        {
            _createEnemyCoroutine = ContinuousActionUtility.ContinuousAction(0f,2f, CreateEnemy);
            //Timer.Register(2, CreateEnemy, isLooped: true);
        }

        // public void StopCreateEnemy()
        // {
        //     StopCoroutine(_createEnemyCoroutine);
        // }

        private void CreateEnemy()
        {
            Instantiate(enemy,
                new Vector3(Random.Range(leftPoint.position.x, rightPoint.position.x), brithPoint.position.y, 0),
                Quaternion.identity, transform);
        }
        
    }
}