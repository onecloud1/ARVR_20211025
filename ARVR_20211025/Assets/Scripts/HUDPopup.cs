using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDPopup : MonoBehaviour
{
    //�ؼЦ�m 
    private Vector3 mTarget;
    //�ù��y��  
    private Vector3 mScreen;
    //�ˮ`�ƭ�  
    public int Value;
    //�奻�e��  
    public float ContentWidth;
    //�奻����  
    public float ContentHeight;
    //GUI�y�� 
    private Vector2 mPoint;
    //�P���ɶ�  
    public float FreeTime = 1.5F;

    public Font font;
    public Color color;
    public int fontSize;
    public float speed;
    void Start()
    {
        //����ؼЦ�m  
        mTarget = transform.position;
        //����ù���m  
        mScreen = Camera.main.WorldToScreenPoint(mTarget);
        //�ù���m��GUI��m  
        mPoint = new Vector2(mScreen.x, Screen.height - mScreen.y);
        //�۰ʾP������P  
        StartCoroutine("Free");
    }

    void Update()
    {
        //�奻�b������V���Ͱ���  
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //���s�p��y��  
        mTarget = transform.position;
        //����ù��y��  
        mScreen = Camera.main.WorldToScreenPoint(mTarget);
        //�N�ù��y���ରGUI�y��  
        mPoint = new Vector2(mScreen.x, Screen.height - mScreen.y);
    }

    void OnGUI()
    {
        //�O�ҥؼЦb��v���e��  
        if (mScreen.z > 0)
        {
            //�����ϥ�GUIø�s  
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
