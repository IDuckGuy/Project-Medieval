using UnityEngine;

namespace Dialogue
{
    public class DialogueTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other) {
            DialogueSystem.Instance.Triggered = true;
             Destroy(this);
        }
    }

}