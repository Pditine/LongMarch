using System.Collections.Generic;
using Pditine.Scripts.Item;
using Unity.VisualScripting;
using UnityEngine;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level6SceneManager : MonoBehaviour
    {
        [SerializeField] private List<SoldierOnTheirStomachs> soldiers = new();
        
        private void Start()
        {
            Invoke(nameof(WarIsOver),20);
            foreach (var soldier in soldiers)
            {
                soldier.ChangeBulletCount(200);
            }
        }

        private void WarIsOver()
        {
            ChangeSceneManager.Instance.ChangeScene(9);
        }
    }
}