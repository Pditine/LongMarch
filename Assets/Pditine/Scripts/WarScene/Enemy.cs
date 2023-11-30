using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pditine.Scripts.WarScene
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private List<Sprite> sprites = new();
        private void Start()
        {
            Destroy(gameObject,Random.Range(2.5f,4f));
            GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count)];
        }

        private void FixedUpdate()
        {
            transform.localScale += new Vector3(0.0017f, 0.0017f, 0);
            transform.position -= new Vector3(0, 0.017f, 0);
        }
        
    }
}