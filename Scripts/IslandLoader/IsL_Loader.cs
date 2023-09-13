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
            string localMeshdbFile = "Assets/Scripts/IslandLoader/meshdb_buffer.txt";
            string windowPath = EditorUtility.OpenFilePanel("Select MeshDB", "", "json");

        if (!string.IsNullOrEmpty(windowPath))
        {
            Debug.Log("MeshDB Set");
            string content = File.ReadAllText(windowPath);
            File.WriteAllText(localMeshdbFile, content);
        }
        else
            Debug.Log("ERROR MeshDB not set");
        } //SetLocalMeshDB

        [MenuItem("IsL_Loader/Read MeshDB", false, 210)]
        static void ReadString()
        {
            string path = "Assets/Scripts/IslandLoader/meshdb_buffer.txt";
            //Read the text from directly from the test.txt file
            StreamReader reader = new StreamReader(path); 
            Debug.Log(reader.ReadToEnd());
            reader.Close();
        } //ReadLocalMeshDB
        
        
        [MenuItem("IsL_Loader/Set StaticObject Data", false, 300)]
        public static void SetStaticObjects()
        {
            string localStaticObjectFile = "Assets/Scripts/IslandLoader/staticobject_buffer.txt";
            string localSmall_StaticObjectFile = "Assets/Scripts/IslandLoader/smallstaticobject_buffer.txt";
            string staticObjectPath = EditorUtility.OpenFilePanel("Select Static Object File", "", "json");
            string small_StaticObjectPath = EditorUtility.OpenFilePanel("Select Small Static Object File", "", "json");

        if (!string.IsNullOrEmpty(staticObjectPath))
        {
            
            //Set Static Object
            Debug.Log("Static Object Data Set");
            string objcontent = File.ReadAllText(staticObjectPath);
            File.WriteAllText(localStaticObjectFile, objcontent);

            //Set Small Static Object
            Debug.Log("Small Static Object Data Set");
            string sObjcontent = File.ReadAllText(small_StaticObjectPath);
            File.WriteAllText(localSmall_StaticObjectFile, sObjcontent);
        }
        else
            Debug.Log("ERROR MeshDB not set");
        } //SetIslandData
        
        [MenuItem("IsL_Loader/Read StaticObject Data", false, 310)]
        static void ReadIslandData()
        {
            //Get the directory of locals files
            string localStaticObjectFile = "Assets/Scripts/IslandLoader/staticobject_buffer.txt";
            string localSmall_StaticObjectFile = "Assets/Scripts/IslandLoader/smallstaticobject_buffer.txt";

            //Read the data from Static Object Local File
            Debug.Log("Local Static Object Data");
            StreamReader readerStaticObject = new StreamReader(localStaticObjectFile); 
            Debug.Log(readerStaticObject.ReadToEnd());
            readerStaticObject.Close();

            //Read the data from Small Static Object Local File
            Debug.Log("Local Small Static Object Data");
            StreamReader readerSmallStaticObject = new StreamReader(localSmall_StaticObjectFile); 
            Debug.Log(readerSmallStaticObject.ReadToEnd());
            readerSmallStaticObject.Close();
        } //ReadIslandData
        [MenuItem("IsL_Loader/Launch Island Load", false, 400)]
        static void LoadIslandData()
        {
            //Get the directory of locals files
            string pathMeshDB = "Assets/Scripts/IslandLoader/meshdb_buffer.txt";
            string pathStaticObjectFile = "Assets/Scripts/IslandLoader/staticobject_buffer.txt";
            string pathSmall_StaticObjectFile = "Assets/Scripts/IslandLoader/smallstaticobject_buffer.txt";

            IsL_LoaderWindow.JsonParser(pathStaticObjectFile, pathSmall_StaticObjectFile);
            Debug.Log("Reset Island Data Buffers");
            //Reset Content of StaticObject & SmallStaticObject Buffer
            File.WriteAllText(pathStaticObjectFile, "");
            File.WriteAllText(pathSmall_StaticObjectFile, "");
        
        } //Load Island
    } //class
    public class IsL_Loader{

        [System.Serializable]
            public class StaticObjectStruct
            {
                public string name;
                public Vector3 postion;
                public Vector3 rotation;
                public Vector3 scale;
            }
        [System.Serializable]
            public class StaticObjectList 
            {
                public List <StaticObjectStruct> staticObject;
            }
            
    public StaticObjectStruct myStaticObjectStruct = new StaticObjectStruct();

    public void JsonParser(string staticObjectPath, string smallStaticObjectPath)
    {
        string jsonText = File.ReadAllText(staticObjectPath);
        JsonUtility.FromJsonOverwrite(jsonText, myStaticObjectStruct);
        Debug.Log("jsonText : "+jsonText);//works
        Debug.Log("count : "+myStaticObjectStruct.staticObject.Count);// = 0
        foreach (StaticObject p in myStaticObjectStruct.staticObject)
        {
            Debug.Log("name : "+p.name);
        }
    }
}

} //namespace