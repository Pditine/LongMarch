using System;
using UnityEngine;

namespace Hmxs.Scripts.Soldier
{
    public class SoldierController : MonoBehaviour
    {
        public float speed;

        public float xLimit;

        private void Update()
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

            if (transform.position.x > xLimit)
                Destroy(gameObject);
        }
    }
}