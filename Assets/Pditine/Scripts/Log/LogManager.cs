using System;
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
        [SerializeField] private float maxHeight;
        [SerializeField] private float maxWidth;
        private readonly List<LogData> _collectedData = new();
        private int _currentIndex;

        private void OnEnable()
        {
            if(_collectedData.Count!=0)
                UpdateLog();
        }

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
            if(dataIndex>=0 && dataIndex<=allData.Count-1)
                _collectedData.Add(allData[dataIndex]);
            else Debug.LogError("数组越界");
        }

        private void UpdateLog()
        {
            historicalPicture.rectTransform.localScale = Vector3.one;
            historicalPicture.sprite = _collectedData[_currentIndex].HistoricalPicture;
            historicalPicture.SetNativeSize();
            var texture = _collectedData[_currentIndex].HistoricalPicture.texture; 
            var height = texture.height;
            var width = texture.width;
            if(height>maxHeight || width>maxWidth)
                if (height > width)
                {
                    historicalPicture.rectTransform.localScale *= maxHeight / height;
                }
                else
                {
                    historicalPicture.rectTransform.localScale *= maxWidth / width;
                }
            historicalFactHead.text = _collectedData[_currentIndex].HistoricalFactHead;
            historicalFactContent.text = _collectedData[_currentIndex].HistoricalFactContent;
        }
    }
}