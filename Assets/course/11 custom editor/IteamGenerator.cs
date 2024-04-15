using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using Course.CustomEditor;

namespace course.customeditor
{
    public class IteamGenerator : EditorWindow
    {
        //Item Data
        private new string title;
        private float price;
        private Sprite sprite;
        private ItemSO _data;

        private GUIStyle _stylebuttons;
        private string _pathAndName = "Assets/course/11 custom editor/Data objets/NewItem.asset";
        [MenuItem("MyTools/My Item Generator")] // agregar al menu de unity
        #region ItemGenerator window  // asi se crea una ventana
        static void Init()
        {
            IteamGenerator window = (IteamGenerator)GetWindow(typeof(IteamGenerator));  // el script tiene un window que equivale a getwindow
            Texture2D IconTitle = EditorGUIUtility.Load("d_Prefab Icon") as Texture2D;  // textura 2d iconode titulo, el editor de gui de unity, cargar, "prefab icon" (ya incluido) como textura 2d
            GUIContent TitleContent = new GUIContent("Item Generator", IconTitle);  // crear el titulo en letras para la ventana
            window.titleContent = TitleContent;  // aplicar ese titulo de arriba
            window.minSize = new Vector2(350, 250);  // tama?o de la ventana largo y alto 2 vectores
            window.Show(); // mostrar
            #endregion
        }

        private void OnGUI()
        {
            _stylebuttons = new GUIStyle(GUI.skin.button) { alignment = TextAnchor.MiddleCenter, fontSize = 15, fixedHeight = 40 };
            GUILayout.Label("data" , EditorStyles.boldLabel);
            EditorGUILayout.Space();

            title = EditorGUILayout.TextField ("title", title);
            GUILayout.Label("price");
            price = EditorGUILayout.Slider(price, 0, 999);

            sprite = (Sprite)EditorGUILayout.ObjectField("sprite", sprite, typeof(Sprite), true);
            
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            if (GUILayout.Button("create", _stylebuttons))
            {
                CreateItem();
                string _ItemPathAndName = AssetDatabase.GenerateUniqueAssetPath(_pathAndName);
                AssetDatabase.CreateAsset(_data, _ItemPathAndName);
                AssetDatabase.RenameAsset(_ItemPathAndName, title);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();

                EditorUtility.FocusProjectWindow();
                Selection.activeObject = _data; 
            }   
            
            if (GUILayout.Button("clear", _stylebuttons))
            {
                clearItem();
            }

            EditorGUILayout.EndHorizontal();
            //DrawSize();

             void CreateItem()
            {
                _data = CreateInstance<ItemSO>();
                _data.title = title;
                _data.price = price;
                _data.sprite = sprite;
            }
             void clearItem()
            {
                title = null;
                price = 0;
                sprite = null;
            }
        }
        private void DrawHorizontalLine()
        {
            Rect rect = EditorGUILayout.GetControlRect(false, 1);
            rect.height = 1;
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }
        private void DrawSize()
        {
            EditorGUILayout.LabelField("x: " + base.position.width.ToString());
            EditorGUILayout.LabelField("y: " + base.position.height.ToString());
        }
    }
}
