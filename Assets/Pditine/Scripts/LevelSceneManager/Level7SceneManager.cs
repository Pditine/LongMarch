using System.Collections;
using System.Collections.Generic;
using Hmxs.Scripts.Protagonist;
using Pditine.Scripts.Tool;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Pditine.Scripts.LevelSceneManager
{
    public class Level7SceneManager : MonoBehaviour
    {
        [SerializeField] private List<Sprite> pictures = new();
        [SerializeField] private Text text;
        [SerializeField] private Transform textTargetPoint;
        [SerializeField] private Image picture;
        [SerializeField] private Image blackPanel;
        private int _pictureIndex;
        private bool _canMoveText;
        private Coroutine _doChangePicture;

        public void GameEnd()
        {
            ProtagonistController.Instance.enabled = false;
            FadeUtility.FadeInAndStay(blackPanel,80);
            _doChangePicture = StartCoroutine(DoChangePicture());
            _canMoveText = true;
            picture.sprite = pictures[_pictureIndex];
            //picture.SetNativeSize();
        }
        
        private void FixedUpdate()
        {
            if(_canMoveText)
                MoveText();
        }

        private void MoveText()
        {
            text.transform.position += new Vector3(0, 1.5f, 0);
            if (text.transform.position.y>textTargetPoint.position.y)
            {
                _canMoveText = false;
                StopCoroutine(_doChangePicture);
                FadeUtility.FadeOut(picture,100);
                Invoke(nameof(GameIsOver),8);
            }
        }

        public void GameIsOver()
        {

            text.gameObject.SetActive(false);
            ChangeSceneManager.Instance.ChangeScene(0);
        }

        private IEnumerator DoChangePicture()
        {
            while(true)
            {
                yield return new WaitForSeconds(4f);
                ChangePicture();
            }
        }
        
        private void ChangePicture()
        {
            FadeUtility.FadeOut(picture,100, () =>
            {
                picture.sprite = pictures[_pictureIndex];
                //picture.SetNativeSize();
                _pictureIndex++;
                if (_pictureIndex >= pictures.Count) _pictureIndex = 0;
                FadeUtility.FadeInAndStay(picture,80);
            });
        }
    }
}