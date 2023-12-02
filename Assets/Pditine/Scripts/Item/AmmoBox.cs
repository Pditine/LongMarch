using Hmxs.Scripts.Protagonist;
using Pditine.Scripts.WarScene;
using UnityEngine;

namespace Pditine.Scripts.Item
{
    public class AmmoBox : ItemBase
    {
        protected override void PressEAction()
        {
            PlayerGetAmmo.Instance.GetAmmo();
        }

        protected override void PlayerEnterAction()
        {
            if (!PlayerGetAmmo.Instance.HasAmmo)
            {
                ProtagonistController.Instance.ShowInteractInfo();
            }
        }

        protected override void PlayerExitAction()
        {
            ProtagonistController.Instance.HideInteractInfo();
        }

        protected override void PlayerStayAction()
        {

        }
        
    }
}