using UnityEngine;

namespace course.PatronesDiseno.Command
{
    public class Move : IComand
    {
        private Transform _ObjectToMove;
        private Vector3 _direccion;
        private float _Distancia;

        public Move(Transform objectToMove, Vector3 direccion, float distancia = 1)
        {
            _ObjectToMove = objectToMove;
            _direccion = direccion;
            _Distancia = distancia;
        }

        public void Execute()
        {
            _ObjectToMove.position += _direccion * _Distancia;
        }

        public void Undo()
        {
            _ObjectToMove.position -= _direccion * _Distancia;
        }
    }
}
