using UnityEngine;
using UnityEngine.Pool;

namespace Hmxs.Toolkit.Base.Pools
{
    public abstract class ScriptableObjectPool<T> : ScriptableObject, IPool<T> where T : class
    {
        [SerializeField] private int defaultSize = 100;
        [SerializeField] private int maxSize = 500;
        [SerializeField] private bool collectionCheck = true;

        public int ActiveCount => Pool.CountActive;
        public int InActiveCount => Pool.CountInactive;
        public int AllCount => Pool.CountAll;
        
        public T Get() => Pool.Get();
        public void Release(T element) => Pool.Release(element);
        public void Dispose() => Pool.Clear();

        private ObjectPool<T> _pool;
        private ObjectPool<T> Pool => _pool ?? Initialize();

        private ObjectPool<T> Initialize() =>
            new(OnCreateElement, OnGetElement, OnReleaseElement, OnDestroyElement, collectionCheck, defaultSize, maxSize);

        protected abstract T OnCreateElement();
        protected abstract void OnGetElement(T element);
        protected abstract void OnReleaseElement(T element);
        protected abstract void OnDestroyElement(T element);
    }
}