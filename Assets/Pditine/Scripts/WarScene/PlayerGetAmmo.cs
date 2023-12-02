using Pditine.Scripts.Tool;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pditine.Scripts.WarScene
{
    public class PlayerGetAmmo : MonoSingleton<PlayerGetAmmo>
    {
        private bool _hasAmmo;
        public bool HasAmmo => _hasAmmo;
        [SerializeField]private GameObject ammoIcon;
        
        public void GetAmmo()
        {
            _hasAmmo = true;
            ammoIcon.SetActive(true);
        }

        public bool CheckAndGiveAmmo()
        {
            var hasAmmo = _hasAmmo;
            _hasAmmo = false;
            ammoIcon.SetActive(false);
            return hasAmmo;
        }
    }
}