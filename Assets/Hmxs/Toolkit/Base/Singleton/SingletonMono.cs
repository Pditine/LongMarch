using System;
using UnityEngine;

namespace Hmxs.Toolkit.Base.Singleton
{
    /// <summary>
    /// 泛型单例基类-继承Mono
    /// 采用Lazy进行实例化保证线程安全
    /// </summary>
    public abstract class SingletonMono<T> : MonoBehaviour where T : SingletonMono<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                _instance ??= new Lazy<GameObject>(new GameObject(typeof(T).Name)).Value.AddComponent<T>();
                _instance.OnInstanceCreate(_instance);
                return _instance;
            }
        }

        /// <summary>
        /// 单例被第一次调用时调用该方法
        /// </summary>
        protected virtual void OnInstanceCreate(T instance)
        {
            DontDestroyOnLoad(gameObject);
        }

        protected virtual void Awake()
        {
            if (_instance == null)
                _instance = (T)this;
            else 
                Destroy(gameObject);
        }
    }
}