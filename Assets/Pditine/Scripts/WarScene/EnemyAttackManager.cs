using System.Collections.Generic;
using Pditine.Scripts.Tool;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Pditine.Scripts.WarScene
{
    public class EnemyAttackManager : MonoBehaviour
    {
        [SerializeField] private List<Transform> attackPoints = new();
        private GameObject _attackRing;
        private Coroutine _fireCoroutine;
        private void Start()
        {
            _attackRing = Resources.Load<GameObject>("Prefabs/AttackRing");
            _fireCoroutine = ContinuousActionUtility.ContinuousAction(5f, 8f, Attack);
        }

        public void StopFire()
        {
            StopCoroutine(_fireCoroutine);
        }
        
        private void Attack()
        {
            Instantiate(_attackRing, attackPoints[Random.Range(0, attackPoints.Count)].position, quaternion.identity,
                transform);
        }
    }
}