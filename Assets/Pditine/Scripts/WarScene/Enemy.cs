using UnityEngine;

namespace Pditine.Scripts.WarScene
{
    public class Enemy : MonoBehaviour
    {
        private void Start()
        {
            Destroy(gameObject,Random.Range(0,5f));
        }

        private void FixedUpdate()
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0);
            transform.position -= new Vector3(0, 0.12f, 0);
        }
        
    }
}