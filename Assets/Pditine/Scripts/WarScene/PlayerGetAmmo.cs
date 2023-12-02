using Pditine.Scripts.Tool;
using UnityEngine;

namespace Pditine.Scripts.WarScene
{
    public class PlayerGetAmmo : MonoSingleton<PlayerGetAmmo>
    {
        private bool _hasAmmo;
        private GameObject _ammoIcon;
        
        private void GetAmmo()
        {
            _hasAmmo = true;
            _ammoIcon.SetActive(true);
        }

        private bool CheckAndGiveAmmo()
        {
            var hasAmmo = _hasAmmo;
            _hasAmmo = false;
            _ammoIcon.SetActive(false);
            return _hasAmmo;
        }
    }
}