using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDPopup : MonoBehaviour
{
    //目標位置 
    private Vector3 mTarget;
    //螢幕座標  
    private Vector3 mScreen;
    //傷害數值  
    public int Value;
    //文本寬度  
    public float ContentWidth;
    //文本高度  
    public float ContentHeight;
    //GUI座標 
    private Vector2 mPoint;
    //銷毀時間  
    public float FreeTime = 1.5F;

    public Font font;
    public Color color;
    public int fontSize;
    public float speed;
    void Start()
    {
        //獲取目標位置  
        mTarget = transform.position;
        //獲取螢幕位置  
        mScreen = Camera.main.WorldToScreenPoint(mTarget);
        //螢幕位置轉GUI位置  
        mPoint = new Vector2(mScreen.x, Screen.height - mScreen.y);
        //自動銷毀的協同  
        StartCoroutine("Free");
    }

    void Update()
    {
        //文本在垂直方向產生偏移  
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //重新計算座標  
        mTarget = transform.position;
        //獲取螢幕座標  
        mScreen = Camera.main.WorldToScreenPoint(mTarget);
        //將螢幕座標轉為GUI座標  
        mPoint = new Vector2(mScreen.x, Screen.height - mScreen.y);
    }

    void OnGUI()
    {
        //保證目標在攝影機前方  
        if (mScreen.z > 0)
        {
            //內部使用GUI繪製  
            GUIStyle style = new GUIStyle();
            style.fontSize = fontSize;
            style.font = font;
            style.normal.textColor = color;
            GUI.Label(new Rect(mPoint.x, mPoint.y, ContentWidth, ContentHeight), "-" + Value.ToString(), style);
        }
    }

    IEnumerator Free()
    {
        yield return new WaitForSeconds(FreeTime);
        Destroy(this.gameObject);
    }
}
