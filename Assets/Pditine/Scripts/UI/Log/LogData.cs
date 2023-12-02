using UnityEngine;

namespace Pditine.Scripts.Log
{
    [CreateAssetMenu(fileName = "LogData",menuName = "ScriptableObject/LogData")]
    public class LogData : ScriptableObject
    {
        [SerializeField] private Sprite historicalPicture;
        [SerializeField] private string historicalFactHead;
        [SerializeField] private string historicalFactContent;

        public Sprite HistoricalPicture => historicalPicture;

        public string HistoricalFactHead => historicalFactHead;
        
        public string HistoricalFactContent => historicalFactContent;
        
    }
}
