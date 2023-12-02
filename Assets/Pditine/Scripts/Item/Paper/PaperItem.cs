using System;
using Pditine.Scripts.Log;
using Pditine.Scripts.UI.Log;
using Unity.Mathematics;
using UnityEngine;

namespace Pditine.Scripts.Item.Paper
{
    public class PaperItem : ItemBase
    {
        [SerializeField] private int dataIndex;
        private GameObject _floatingEffect;
        private Transform _canvas;

        private void Start()
        {
            _floatingEffect = Resources.Load<GameObject>("Prefabs/PaperFloatingEffect");
            _canvas = GameObject.Find("Canvas").transform;
        }

        protected override void PressEAction()
        {
            
        }

        protected override void PlayerEnterAction()
        {
            BeCollected();
        }

        protected override void PlayerExitAction()
        {

        }

        protected override void PlayerStayAction()
        {

        }

        private void BeCollected()
        {
            LogManager.Instance.CollectData(dataIndex);
            Instantiate(_floatingEffect, Camera.main.WorldToScreenPoint(transform.position) , quaternion.identity,_canvas);
            Destroy(gameObject);
        }
        
    }
}