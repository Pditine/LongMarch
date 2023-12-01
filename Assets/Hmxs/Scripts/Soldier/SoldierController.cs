using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hmxs.Scripts.Soldier
{
    public class SoldierController : MonoBehaviour
    {
        public float speed;

        public List<Transform> movePoint;

        private Vector3 _direction;
        private int _currentTargetPointIndex;

        private void Start()
        {
            _currentTargetPointIndex = 0;
        }

        private void Update()
        {
            _direction = (movePoint[_currentTargetPointIndex].position - transform.position).normalized;
            transform.Translate(_direction * (Time.deltaTime * speed));

            if (Vector3.Distance(transform.position, movePoint[_currentTargetPointIndex].position) < 0.05f)
            {
                if (_currentTargetPointIndex == movePoint.Count - 1)
                    Destroy(gameObject.transform.parent.gameObject);
                else
                    _currentTargetPointIndex += 1;
            }
        }
    }
}