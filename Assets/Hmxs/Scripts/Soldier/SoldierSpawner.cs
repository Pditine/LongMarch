using System;
using Hmxs.Toolkit.Flow.Timer;
using UnityEngine;

namespace Hmxs.Scripts.Soldier
{
    public class SoldierSpawner : MonoBehaviour
    {
        public GameObject soldierPrefab;
        public float spawnInterval;

        private Timer _spawnTimer;

        private void Start()
        {
            _spawnTimer = Timer.Register(
                duration: spawnInterval,
                onComplete: () => Instantiate(soldierPrefab, transform),
                isLooped: true);
        }

        private void OnDisable() => Timer.Remove(_spawnTimer);
    }
}