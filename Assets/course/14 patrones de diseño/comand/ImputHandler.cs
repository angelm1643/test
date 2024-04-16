using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace course.PatronesDiseno.Command
{
    public class ImputHandler : MonoBehaviour
    {
        public Transform ObjectToMove;
        [Space]
        public KeyCode MoveExecute = KeyCode.E;
        public KeyCode MoveUndo = KeyCode.Z;
        public KeyCode MoveLeft = KeyCode.A;
        public KeyCode MoveRight = KeyCode.D;
        public KeyCode MoveUp = KeyCode.W;
        public KeyCode MoveDown = KeyCode.S;

        private List<IComand> _ComandList = new List<IComand>();

        private void Update()
        {
            if (Input.GetKeyDown(MoveExecute)) moveExecute();
            if (Input.GetKeyDown(MoveUndo)) moveUndo();
            
            if (Input.GetKeyDown(MoveLeft)) moveWrite(Vector3.left);
            if (Input.GetKeyDown(MoveRight)) moveWrite(Vector3.right);
            if (Input.GetKeyDown(MoveUp)) moveWrite(Vector3.forward);
            if (Input.GetKeyDown(MoveDown)) moveWrite(Vector3.back);

        }
        private void moveWrite(Vector3 Direccion)
        {
            IComand move = new Move(ObjectToMove, Direccion);
            _ComandList.Add(move);
        }
        private void moveExecute()
        {
            StartCoroutine(MoveForward());
        }
        private void moveUndo()
        {
            StartCoroutine(MoveBackward());
        }
        private IEnumerator MoveForward()
        {
            for (int i = 0; i < _ComandList.Count; i++)
            {
                _ComandList[i].Execute();
                yield return new WaitForSeconds(0.25f);
            }
        }
        private IEnumerator MoveBackward()
        {
            for (int i = _ComandList.Count - 1; i >= 0; i--)
            {
                _ComandList[i].Undo();
                yield return new WaitForSeconds(0.25f);
            }
        }
    }
}
