using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Similiar to Singleton, but do not destroy any instance, just override the current one.
/// Useful for resetting the state.
/// </summary>
public abstract class StaticInstance<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake() => Instance = this as T;

    protected virtual void OnApplicationQuit()
    {
        Instance = null;
        Destroy(gameObject);
    }
}

/// <summary>
/// Transforms the static instance into a singleton.
/// It will destroy any new instance, leaving just the original.
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class  Singleton<T> : StaticInstance<T> where T : MonoBehaviour
{
    protected override void Awake()
    {
        if (Instance != null) Destroy(gameObject);

        base.Awake();
    }
}

/// <summary>
/// Persistent version of the singleton. 
/// Useful for statefull and persistent data, or audio sources that plays between scenes and etc.
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class PersistentSingleton<T> : Singleton<T> where T : MonoBehaviour
{
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(gameObject);
    }
}