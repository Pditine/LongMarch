using HighlightPlus2D;
using Hmxs.Scripts.Protagonist;
using Pditine.Scripts.WarScene;
using UnityEngine;

namespace Pditine.Scripts.Item
{
    public class AmmoBox : ItemBase
    {
        public HighlightEffect2D highlightEffect;

        protected override void PressEAction()
        {
            PlayerGetAmmo.Instance.GetAmmo();
            highlightEffect.highlighted = false;
        }

        protected override void PlayerEnterAction()
        {
            if (!PlayerGetAmmo.Instance.HasAmmo)
            {
                //ProtagonistController.Instance.ShowInteractInfo();
                highlightEffect.highlighted = true;
            }
        }

        protected override void PlayerExitAction()
        {
            //ProtagonistController.Instance.HideInteractInfo();
            highlightEffect.highlighted = false;
        }

        protected override void PlayerStayAction()
        {

        }
        
    }
}