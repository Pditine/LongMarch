using UnityEngine;

namespace Pditine.Scripts.Tool
{
    public class Singleton<T> where T : new()
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance is null)
                    _instance = new T();
                return _instance;
            }
        }
    }

    public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T _instance;

        protected virtual void Awake()
        {
            _instance ??= this as T;
        }
        
        public static T Instance => _instance;
    }

    public class DDOLMonoSingleton<T> : MonoBehaviour where T : DDOLMonoSingleton<T>
    {
        private static T _instance;

        protected virtual void Awake()
        {
            _instance ??= this as T;
            DontDestroyOnLoad(gameObject);
        }
        
        public static T Instance => _instance;
    }
    
    public class AutoMonoSingleton<T> : MonoBehaviour where T : AutoMonoSingleton<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance is not null) return _instance;
                var obj = new GameObject
                {
                    name = typeof(T).ToString()
                };
                _instance = obj.AddComponent<T>();
                return _instance;
            }
        }
    }
}
