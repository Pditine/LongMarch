using Hmxs.Toolkit.Flow.FungusTools;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Hmxs.Scripts
{
    public class EventTrigger : MonoBehaviour
    {
        public UnityEvent onPlayerPassed;

        [Title("FlowChatMethod")] [InfoBox("Provide A Quick Method To Invoke Fungus Block")]
        public string blockName;

        private bool _isTriggered;

        private void Start()
        {
            _isTriggered = false;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player") && !_isTriggered)
            {
                _isTriggered = true;
                onPlayerPassed?.Invoke();
            }
        }

        public void InvokeFungusBlock()
        {
            FlowchartManager.ExecuteBlock(blockName);
        }
    }
}