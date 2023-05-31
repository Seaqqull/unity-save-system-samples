using SaveSystem.Additional.UI;
using UnityEngine;


namespace SaveSystem.Additional.Actions.Specific
{
    [CreateAssetMenu(fileName = "ShowMessage", menuName = "Save-System Samples/Actions/Simple/ShowMessage", order = 0)]
    public class SnowMessageActionSO : ActionSO
    {
        [SerializeField] private Snackbar _snackbar;
        [SerializeField] private string _additionalInfo;
        [SerializeField] private string _message;

        
        public override void Do()
        {
            var snackbar = Instantiate(_snackbar, UIContainer.Instance.SnackbarTransform);
            snackbar.Text = string.Format(_message, _additionalInfo);
        }

        public override void Do(MonoBehaviour mono)
        {
            Do();
        }
    }
}