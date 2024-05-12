using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
public class AutoSave: MonoBehaviour {
#if UNITY_EDITOR
    [System.Obsolete]
    static AutoSave() {
        EditorApplication.playmodeStateChanged = () => {
            if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying) {
                Debug.Log("Saving before entering Play Mode: " + EditorApplication.currentScene);

                EditorApplication.SaveScene();
                AssetDatabase.SaveAssets();
            }
        };
    }
#endif
}