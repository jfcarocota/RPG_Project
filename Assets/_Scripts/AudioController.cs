using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{
    namespace AudioController
    {
        [RequireComponent(typeof(AudioSource))]

        [System.Serializable]
        public class AudioController
        {
            [SerializeField]
            List<AudioClip> audios;

            [SerializeField]
            AudioSource aud;

            public AudioSource Aud
            {
                get
                {
                    return aud;
                }

                set
                {
                    aud = value;
                }
            }

            public void PlayClipOnce(int index)
            {
                aud.PlayOneShot(audios[index]);
            }

            public void PlayClip(int index)
            {
                aud.clip = audios[index];
                aud.Play();
            }

            public void StopClip()
            {
                aud.Stop();
                aud.clip = null;
            }

            public bool Playing
            {
                get { return aud.isPlaying; }
            }
        }
    }
}
