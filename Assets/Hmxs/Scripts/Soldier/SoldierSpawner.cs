using System.Collections.Generic;
using Hmxs.Toolkit.Flow.Timer;
using UnityEngine;

namespace Hmxs.Scripts.Soldier
{
    public class SoldierSpawner : MonoBehaviour
    {
        public List<GameObject> soldierPrefabList;
        public float spawnInterval;

        private Timer _spawnTimer;

        private void Start()
        {
            _spawnTimer = Timer.Register(
                duration: spawnInterval,
                onComplete: () => Instantiate(soldierPrefabList[Random.Range(0, soldierPrefabList.Count)], transform),
                isLooped: true);
        }

        private void OnDisable() => Timer.Remove(_spawnTimer);
    }
}