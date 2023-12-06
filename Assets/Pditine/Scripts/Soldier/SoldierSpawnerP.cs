using System.Collections.Generic;
using Hmxs.Scripts.Soldier;
using Hmxs.Toolkit.Flow.Timer;
using UnityEngine;

namespace Pditine.Scripts.Soldier
{
    public class SoldierSpawnerP : MonoBehaviour
    {
        public List<GameObject> soldierPrefabList;
        public float spawnInterval;
        [SerializeField] private List<Transform> targetPoints;
        private Timer _spawnTimer;

        private void Start()
        {
            Debug.Log("START");
            _spawnTimer = Timer.Register(
                duration: spawnInterval,
                onComplete: () =>
                {
                    Debug.Log("1");
                    var soldier = Instantiate(soldierPrefabList[Random.Range(0, soldierPrefabList.Count)], transform);
                    var soldierController = soldier.GetComponentInChildren<SoldierController>();
                    soldierController.movePoint.Clear();
                    foreach (var targetPoint in targetPoints) soldierController.movePoint.Add(targetPoint);
                },
                isLooped: true, owner: this);
        }

       // private void OnDisable() => Timer.Remove(_spawnTimer);
    }
}