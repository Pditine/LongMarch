using System;
using UnityEngine;

namespace Hmxs.Toolkit.Module.Audios
{
    public class AudioAsset
    {
        public readonly AudioType Type;
        public readonly string ClipName;
        public readonly bool IsLoop;
        public readonly Action Callback;

        public readonly bool Is3D;
        public readonly Vector3 Position;

        public AudioAsset(AudioType type, string clipName, bool isLoop = false, Action callback = null)
        {
            Type = type;
            ClipName = clipName;
            IsLoop = isLoop;
            Callback = callback;
        }
        
        public AudioAsset(AudioType type, string clipName, bool is3D, Vector3 position, bool isLoop = false, Action callback = null)
        {
            Type = type;
            ClipName = clipName;
            Is3D = is3D;
            Position = position;
            IsLoop = isLoop;
            Callback = callback;
        }
    }
}