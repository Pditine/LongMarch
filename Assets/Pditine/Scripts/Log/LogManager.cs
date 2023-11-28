using System.Collections.Generic;
using Pditine.Scripts.Tool;
using UnityEngine;

namespace Pditine.Scripts.Log
{
    public class LogManager : DDOLMonoSingleton<LogManager>
    {
        [SerializeField] private List<LogData> allData = new();
        private List<LogData> _collectedData = new();

        public void TernLeft()
        {
            
        }

        public void TernRight()
        {
            
        }
        
        public void CollectData(int dataIndex)
        {
            _collectedData.Add(allData[dataIndex]);
        }
        
        
        
    }
}