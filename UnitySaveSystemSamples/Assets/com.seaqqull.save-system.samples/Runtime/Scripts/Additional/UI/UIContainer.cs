using UnityEngine;


namespace SaveSystem.Additional.UI
{
    public class UIContainer : MonoBehaviour
    {
        public static UIContainer Instance { get; private set; }

        [field: SerializeField] public Transform SnackbarTransform { get; private set; }


        private void Awake()
        {
            Instance = this;
        }
    }
}