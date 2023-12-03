using Sirenix.OdinInspector;
using UnityEngine;

namespace Pditine.Scripts.Log
{
    [CreateAssetMenu(fileName = "LogData",menuName = "ScriptableObject/LogData")]
    public class LogData : ScriptableObject
    {
        [SerializeField] [PreviewField(75, ObjectFieldAlignment.Center)]
        private Sprite historicalPicture;

        [SerializeField]
        private string historicalFactHead;

        [SerializeField]
        [Title("Historical Fact Content", bold: false)]
        [HideLabel]
        [MultiLineProperty(30)]
        private string historicalFactContent;

        public Sprite HistoricalPicture => historicalPicture;

        public string HistoricalFactHead => historicalFactHead;
        
        public string HistoricalFactContent => historicalFactContent;
        
    }
}
