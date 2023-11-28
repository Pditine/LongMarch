using Pditine.Scripts.Log;
using Unity.Mathematics;
using UnityEngine;

namespace Pditine.Scripts.Item.Paper
{
    public class PaperItem : MonoBehaviour
    {
        [SerializeField] private int dataIndex;
        private GameObject _floatingEffect;

        private void Start()
        {
            _floatingEffect = Resources.Load<GameObject>("Prefabs/PaperFloatingEffect");
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                BeCollected();
            }
        }

        private void BeCollected()
        {
            LogManager.Instance.CollectData(dataIndex);
            Instantiate(_floatingEffect, transform.position, quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}