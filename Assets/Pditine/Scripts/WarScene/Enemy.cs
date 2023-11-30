using UnityEngine;

namespace Pditine.Scripts.WarScene
{
    public class Enemy : MonoBehaviour
    {
        private void Start()
        {
            Destroy(gameObject,Random.Range(0,4f));
        }

        private void FixedUpdate()
        {
            transform.localScale += new Vector3(0.003f, 0.003f, 0);
            transform.position -= new Vector3(0, 0.03f, 0);
        }
        
    }
}