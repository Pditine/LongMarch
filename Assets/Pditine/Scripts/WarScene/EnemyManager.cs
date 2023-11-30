using System.Collections;
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
            InvokeRepeating(nameof(CreateEnemy),1,3);
            _createEnemyCoroutine = ContinuousActionUtility.ContinuousAction(4, CreateEnemy);
        }

        public void StopCreateEnemy()
        {
            StopCoroutine(_createEnemyCoroutine);
        }

        private void CreateEnemy()
        {
            Instantiate(enemy,
                new Vector3(Random.Range(leftPoint.position.x, rightPoint.position.x), brithPoint.position.y, 0),
                Quaternion.identity, transform);
        }
        
    }
}