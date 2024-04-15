using UnityEngine;
using UnityEditor;

namespace Course.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(Item))]
    public class ItemEditor : Editor  // clase padre editor, es usada para opciones de editor y tiene funciones nuevas
    {
        private Item currentTarget;

        public override void OnInspectorGUI()  // esto es cuando se dibuja el script en el editor
        {
            base.OnInspectorGUI();  // modificamos la forma en la que se dibuja

            currentTarget = (Item)target;  // obtener el tawrget de lo que queremos dibujar

            GUILayout.Space(10);

            if (IsTargetReady())
            {
                if (!EditorApplication.isPlaying)
                    GUILayout.Box($"Data: {currentTarget.data.title} (${currentTarget.data.price})");

                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

                string buttonText = EditorApplication.isPlaying ? "Consume (Only in Editor Mode)" : "Consume";

                if (GUILayout.Button(buttonText, GUILayout.Height(30)))  // creamos un boton
                {
                    currentTarget.Consume();
                }

                EditorGUI.EndDisabledGroup();
            }
            else
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Error);
            }
        }

        private bool IsTargetReady()
        {
            return 
                currentTarget.data &&
                currentTarget.itemImg &&
                currentTarget.itemTitleTxt &&
                currentTarget.itemPriceTxt;
        }

        private string GetErrorMessage()
        {
            if (!currentTarget.data) return "Data Empty!";
            if (!currentTarget.itemImg) return "Image reference Empty";
            if (!currentTarget.itemTitleTxt) return "Title reference Empty!";
            if (!currentTarget.itemPriceTxt) return "Price reference Empty!";

            return "Unknown";
        }

    }
}
