using System;
using System.Collections.Generic;
using Cinemachine;
using Hmxs.Toolkit.Module.Audios;
using UnityEngine;

namespace Hmxs.Scripts
{
    public class SnowMountainManager : MonoBehaviour
    {
        public List<Transform> startPoints;
        public List<PolygonCollider2D> confiners;

        public CinemachineConfiner2D confiner;
        public Transform protagonist;
        public Transform camera;

        private void Start()
        {
            AudioCenter.Instance.AudioPlaySync(new AudioAsset(Toolkit.Module.Audios.AudioType.BGM,"暴雪天气",isLoop: true));
        }

        public void DistrictTransit(int districtNumber)
        {
            protagonist.position = startPoints[districtNumber].position;
            camera.position = startPoints[districtNumber].position;
            confiner.m_BoundingShape2D = confiners[districtNumber];
        }
    }
}