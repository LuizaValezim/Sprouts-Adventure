using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorNormal;
    [SerializeField] private Texture2D cursorPointing;
    [SerializeField] private Texture2D cursorGrabbing;
    
    void Start(){
        Cursor.SetCursor(cursorNormal, new Vector2(10,10), CursorMode.Auto);
        
    }

    public void Reset(){
        Cursor.SetCursor(cursorNormal, new Vector2(10,10), CursorMode.Auto);
    }

    public void SetCursorPointing(){
         Cursor.SetCursor(cursorPointing, new Vector2(10,10), CursorMode.Auto);
    }

    public void SetCursorGrabbing(){
         Cursor.SetCursor(cursorGrabbing, new Vector2(10,10), CursorMode.Auto);

    }


}
