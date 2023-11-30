using UnityEngine;
using UnityEngine.SceneManagement;

namespace Fungus
{
    [CommandInfo("Scene",
        "Load Scene By Name",
        "Load")]
    [AddComponentMenu("")]
    public class LoadSceneByName : Command
    {
        [SerializeField] protected string sceneName;

        public override void OnEnter()
        {
            SceneManager.LoadScene(sceneName);

            Continue();
        }
    }
}