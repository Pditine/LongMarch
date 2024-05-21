using System;
using Hmxs.Toolkit.Flow.Timer;
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
            _canvas = GameObject.Find("BasicCanvas").transform;
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
            //Instantiate(_floatingEffect, Camera.main.WorldToScreenPoint(transform.position) , quaternion.identity,_canvas);
            Camera mainCamera = Camera.main;
            Vector3 screenPoint = LogManager.Instance.transform.position;
            Vector3 worldPoint = mainCamera!.ScreenToWorldPoint(new Vector3(screenPoint.x, screenPoint.y, 0));
            var pos = transform.position;
            Timer.Register(
                1f,
                () => Destroy(gameObject),
                onUpdate: f =>
                {
                    transform.position = Vector3.Lerp(pos, worldPoint, f);
                },
                owner: this);
        }
        
    }
}