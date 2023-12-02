using System.Collections;
using UnityEngine;

namespace Pditine.Scripts.Item
{
    public class AttackRing : ItemBase
    {
        private SpriteRenderer SpriteRenderer => GetComponent<SpriteRenderer>();
        private void Start()
        {
            
        }

        private IEnumerator DoAttack()
        {
            while (transform.localScale.x>0.5f)
            {
                transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
                yield return new WaitForSeconds(0.02f);
            }
            while (transform.localScale.x<0.95f)
            {
                transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
                yield return new WaitForSeconds(0.02f);
            }
            while (transform.localScale.x>0.5f)
            {
                transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
                yield return new WaitForSeconds(0.02f);
            }
            while (transform.localScale.x<0.95f)
            {
                transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
                yield return new WaitForSeconds(0.02f);
            }
<<<<<<< HEAD
            while (SpriteRenderer.color.a>0.05f)
            {
                SpriteRenderer.color -= new Color(0, 0, 0,0.03f);
                yield return new WaitForSeconds(0.02f);
            }
            while (SpriteRenderer.color.a<0.95f)
            {
                SpriteRenderer.color += new Color(0, 0, 0,0.03f);
                yield return new WaitForSeconds(0.02f);
            }
            while (SpriteRenderer.color.a>0.05f)
            {
                SpriteRenderer.color -= new Color(0, 0, 0,0.03f);
                yield return new WaitForSeconds(0.02f);
            }
            while (SpriteRenderer.color.a<0.95f)
            {
                SpriteRenderer.color += new Color(0, 0, 0,0.03f);
                yield return new WaitForSeconds(0.02f);
            }

            _canDead = true;

            yield return 2;
            Destroy(gameObject);
=======
            
            
            
>>>>>>> parent of 879203b (do something , whatever)
        }


        protected override void PressEAction()
        {
            
        }

        protected override void PlayerEnterAction()
        {
            
        }

        protected override void PlayerExitAction()
        {
            
        }

        protected override void PlayerStayAction()
        {
            //todo:玩家死亡;
        }
    }
}