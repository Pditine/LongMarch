using Pditine.Scripts.Log;
using Unity.Mathematics;
using UnityEngine;

namespace Pditine.Scripts.Item.Paper
{
    public class PaperItem : MonoBehaviour
    {
        [SerializeField] private int dataIndex;
        private GameObject _floatingEffect;
        private Transform _canvas;

        private void Start()
        {
            _floatingEffect = Resources.Load<GameObject>("Prefabs/PaperFloatingEffect");
            _canvas = GameObject.Find("Canvas").transform;
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
            Instantiate(_floatingEffect, Camera.main.WorldToScreenPoint(transform.position) , quaternion.identity,_canvas);
            Destroy(gameObject);
        }
        
    }
}