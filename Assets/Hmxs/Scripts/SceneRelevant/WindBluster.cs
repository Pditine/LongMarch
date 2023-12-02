using System;
using UnityEngine;

namespace Hmxs.Scripts.SceneRelevant
{
    public class WindBluster : MonoBehaviour
    {
        public Rigidbody2D protagonistRb;

        public float windIntensity;

        private void FixedUpdate()
        {
            protagonistRb.velocity -= new Vector2(windIntensity, 0);
        }
    }
}