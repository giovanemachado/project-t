﻿using System.Collections;
using UnityEngine;

namespace RouteTeamStudios.Utility
{
    public abstract class Singleton<T> : StaticInstance<T> where T : MonoBehaviour
    {
        protected override void Awake()
        {
            if (Instance != null) Destroy(gameObject);

            Debug.Log("sg?");
            base.Awake();
        }
    }
}