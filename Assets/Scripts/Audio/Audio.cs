using RouteTeamStudios.Utilities;
using UnityEngine;

namespace RouteTeamStudios.Audio
{
    public class Audio : PersistentSingleton<Audio>
    {
        AudioSource audioMain;
        public AudioClip Music;

        void Start()
        {
            audioMain = gameObject.GetComponent<AudioSource>();
            audioMain.clip = Music;
            audioMain.Play();
        }
    }
}
