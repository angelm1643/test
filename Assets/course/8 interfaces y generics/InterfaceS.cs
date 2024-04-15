using UnityEngine;

namespace course
{
    public interface IInteractable
    {
        void Interact();
    }

    public class InterfaceS : MonoBehaviour
    {
        public GameObject[] myInteractables;
        
        public Door interactabledoor;
        public Chest interactablechest;
        public Lever interactablelever;

        private void Start()
        {
            for (int i = 0; i < myInteractables.Length; i++)
            {
                IInteractable myInteractable = myInteractables[i].GetComponent<IInteractable>();
                myInteractable?.Interact();
            }
            // esto hace que por ejemplo el player se acerque a un objeto interactuable y presione un boton y active el script de interactuar de ese objeto, ya si ese objeto tiene dicha funcion ese objeto se va a encargar de realizarla
        }
    }
}
