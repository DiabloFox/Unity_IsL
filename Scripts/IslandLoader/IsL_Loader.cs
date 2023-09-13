using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace IsL_Loader.Editor.Windows
{
    public class IsL_LoaderWindow : EditorWindow
    {
        [MenuItem("IsL_Loader/Set MeshDB", false, 200)]
        public static void SetMeshDBFile()
        {
            string meshdbfile = "Assets/Scripts/IslandLoader/meshdb_buffer.txt";
            string windowPath = EditorUtility.OpenFilePanel("Select MeshDB", "", "json");

        if (!string.IsNullOrEmpty(windowPath))
        {
            Debug.Log("MeshDB Set");
            string content = File.ReadAllText(windowPath);
            File.WriteAllText(meshdbfile, content);
        }
        else
            Debug.Log("ERROR MeshDB not set");
        } //SetMeshDB
        [MenuItem("IsL_Loader/Read MeshDB", false, 210)]
        static void ReadString()
        {
            string path = "Assets/Scripts/IslandLoader/meshdb_buffer.txt";
            //Read the text from directly from the test.txt file
            StreamReader reader = new StreamReader(path); 
            Debug.Log(reader.ReadToEnd());
            reader.Close();
        }
    } //class
} //namespace