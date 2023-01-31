using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DottedLine : MonoBehaviour
{
 
    /// <summary>
    /// 创建虚线所需要的节点
    /// </summary>
    public List<Transform> PointList = new List<Transform>();
 
    private Material _material;

    List<GameObject> autoquads = new List<GameObject>();
 
    private MaterialPropertyBlock _propertyBlock;
 
    // Start is called before the first frame update
    void Start()
    {
        if (_propertyBlock == null)
            _propertyBlock = new MaterialPropertyBlock();
 
 
        _material = new Material(Shader.Find("Custom/UI/DotLine"));
       
    }
 
    // Update is called once per frame
    void Update()
    {
     
    }
 
    public void CreatDottedLine()
    {
 
        if (PointList.Count <= 0) return;
 
 
        foreach (GameObject o in autoquads)
        {
            if (o != null) Destroy(o);
        }
 
        autoquads.Clear();
 
        for (int i = 1; i < PointList.Count; i++)
        {
            CreatQuadScale(PointList[0].position, PointList[i].position,PointList[i].name);
        }
    }
    
    private int n = 0;
    private void CreatQuadScale(Vector3 leftPos, Vector3 rightPos, string name)
    {
 
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Quad);
 
        autoquads.Add(go);
 
        go.name = "autoQuad_"+name;
 
        n++;
 
        Vector3 dir = (rightPos - leftPos).normalized;
 
        float distance = Vector3.Distance(leftPos, rightPos);
 
        Vector3 centerPoint = Vector3.Lerp(leftPos, rightPos, 0.5f);
 
        go.transform.position = centerPoint;
 
        go.transform.localScale = new Vector3(distance, 1f, 1f);
 
        go.transform.right = dir;
 
        MeshRenderer mr = go.GetComponent<MeshRenderer>();
 
        mr.material = _material;
 
        //Debug.Log("距离为 " +distance);
        //一个单位长度10个虚线点
        //这个后期可以自己定
        float cnt = distance * 10;
 
        Debug.Log("间隔为 " + cnt);
 
        _propertyBlock.SetFloat("_Cnt", cnt);
 
        mr.SetPropertyBlock(_propertyBlock);
 
        //设置线段的方向，转向，让面片固定方向的同时，仅且旋转X轴，使其最大化面向摄像机，视觉效果保证每个小线段不至于太倾斜成平行四边形
 
        Vector3 camDir = (Camera.main.transform.position - go.transform.position).normalized;
 
        Vector3 cross = Vector3.Cross(go.transform.right, camDir).normalized;//得到垂直于相机方向的向量
 
        float angle = Vector3.Angle(cross, go.transform.up);//得到Y轴跟该向量的角度，为啥是Y轴，因为模型自身XY轴构建成一个平面，Y轴重合cross，自然面向摄像机
 
 
        Vector3 dirCross = Vector3.Cross(go.transform.up, cross);//用来判断方向
 
 
        float vDir = Vector3.Dot(dirCross.normalized, go.transform.right);
 
 
        if (vDir < 0)
        {
            angle *= -1;
 
        }
 
        go.transform.rotation *= Quaternion.Euler(new Vector3(angle, 0f, 0f));
 
    }

    public void DelteDotLine()
    {
        autoquads.Clear();
    }
    

#if UNITY_EDITOR
 
    private void OnGUI()
    {
        // if (GUI.Button(new Rect(0f, 0f, 100f, 100f), "test"))
        // {
        //     CreatDottedLine();
        // }
 
    }
#endif
 
}