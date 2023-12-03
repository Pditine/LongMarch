using System.Collections.Generic;
using Pditine.Scripts.Item;
using UnityEngine;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level6SceneManager : MonoBehaviour
    {
        [SerializeField] private List<SoldierOnTheirStomachs> soldiers = new();

        private void Start()
        {
            foreach (var soldier in soldiers)
            {
                soldier.ChangeBulletCount(200);
            }
        }
    }
}