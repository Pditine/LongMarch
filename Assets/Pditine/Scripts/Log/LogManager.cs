using System.Collections.Generic;
using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.UI;

namespace Pditine.Scripts.Log
{
    public class LogManager : DDOLMonoSingleton<LogManager>
    {
        [SerializeField] private Image historicalPicture;
        [SerializeField] private Text historicalFactHead;
        [SerializeField] private Text historicalFactContent;
        
        [SerializeField] private List<LogData> allData = new();
        private List<LogData> _collectedData = new();
        private int _currentIndex;
        public void TernLeft()
        {
            if (_collectedData.Count == 0) return;
            _currentIndex--;
            if (_currentIndex < 0)
                _currentIndex = _collectedData.Count - 1;
            UpdateLog();
        }

        public void TernRight()
        {
            if (_collectedData.Count == 0) return;
            _currentIndex++;
            if (_currentIndex >= _collectedData.Count)
                _currentIndex = 0;
            UpdateLog();
        }
        
        public void CollectData(int dataIndex)
        {
            if(dataIndex>0&& dataIndex<=allData.Count-1)
                _collectedData.Add(allData[dataIndex]);
            else Debug.LogError("数组越界");
        }

        private void UpdateLog()
        {
            historicalPicture.sprite = _collectedData[_currentIndex].HistoricalPicture;
            historicalFactHead.text = _collectedData[_currentIndex].HistoricalFactHead;
            historicalFactContent.text = _collectedData[_currentIndex].HistoricalFactContent;
        }
    }
}