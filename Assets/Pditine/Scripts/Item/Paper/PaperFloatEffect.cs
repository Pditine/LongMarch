using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.UI;

namespace Pditine.Scripts.Item.Paper
{
    public class PaperFloatEffect : MonoBehaviour
    {
        private Transform _target;
        private bool _hasDone;
        private void Start()
        {
            _target = GameObject.Find("LogUI").transform;
        }

        private void FixedUpdate()
        {
           Fly();
        }

        private void Fly()
        {
            if (_hasDone) return;
            transform.position = Vector3.Lerp(transform.position, _target.position, 0.04f);
            if (Vector3.SqrMagnitude(transform.position - _target.position) < 50)
            {
                FadeUtility.FadeOut(GetComponent<Image>(),110, () =>
                {
                    Destroy(gameObject);
                });
                _hasDone = true;
            }
        }
    }
}