using UnityEngine;

public class ActSingleton<T> : MonoBehaviour where T: ActSingleton<T>
{
    private static volatile T instance = null;

    public static T Instance
    {
        get
        {
            if (instance is null)
                instance = FindObjectOfType(typeof(T)) as T;

            return instance;
        }
    }
}
