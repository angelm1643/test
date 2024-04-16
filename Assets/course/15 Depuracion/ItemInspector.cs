using UnityEngine;
using UnityEditor;

namespace Course.Depuracion
{
    [UnityEditor.CustomEditor(typeof(Item))]
    public class ItemInspector : Editor
    {
        private Item currentTarget;

        private GUIStyle _styleLabel;

        public void OnSceneGUI()
        {
            _styleLabel = new GUIStyle(GUI.skin.label) 
            { 
                fontSize = 30, 
                fontStyle = FontStyle.Bold 
            };

            currentTarget = target as Item;

            if (!currentTarget.showDebug) return;

            var tr = currentTarget.transform;
            var pos = tr.position;

            // Display a green handle to change collider radius
            Handles.color = new Color(0, 1, 0, 1); // Green
            EditorGUI.BeginChangeCheck();
            float tempRadius = Handles.RadiusHandle(Quaternion.identity, currentTarget.transform.position, currentTarget.SphereCollider.radius);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(target, "Changed Collider Size");
                currentTarget.DebugUpdateRadius(tempRadius);
            }

            // Show Title and Texture
            Handles.Label(pos, currentTarget.texture);
            GUI.color = new Color(0, 0.5f, 1, 1); // Blue
            Handles.Label(pos + Vector3.up, currentTarget.title, _styleLabel);
        }
    }
}
