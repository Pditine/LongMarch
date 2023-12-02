using System.Collections.Generic;
using Cinemachine;
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

        public void DistrictTransit(int districtNumber)
        {
            protagonist.position = startPoints[districtNumber].position;
            camera.position = startPoints[districtNumber].position;
            confiner.m_BoundingShape2D = confiners[districtNumber];
        }
    }
}