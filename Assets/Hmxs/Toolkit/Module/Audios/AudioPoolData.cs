using System;
using UnityEngine;
using AudioType = Hmxs.Toolkit.Module.Audios.AudioType;

namespace Hmxs.Toolkit.Module.Audios
{
    [Serializable]
    public class AudioPoolData
    {
        [SerializeField]private AudioType type;
        [SerializeField]private AudioSource audioSource;
        [SerializeField]private bool isUsing;// 可用状态
        [SerializeField]private bool isInPause;// 暂停中

        public AudioType Type { get=> type; set => type = value; }

        public AudioSource AudioSource { get=> audioSource; set => audioSource = value; }
        public bool IsUsing { get=> isUsing; set => isUsing = value; }
        public bool IsInPause { get=> isInPause; set => isInPause = value; }

        public AudioPoolData(AudioType pType, AudioSource pAudioSource, bool pIsUsing, bool pIsInPause)
        {
            Type = pType;
            AudioSource = pAudioSource;
            IsUsing = pIsUsing;
            IsInPause = pIsInPause;
        }
    }
}