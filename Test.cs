using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Test : MonoBehaviour
{

    void Start()
    {
        TestRequest request = new TestRequest(100,1, "测试", true);
        byte[] bytes = ObjectToBytes(request);

        Debug.LogError(bytes.Length);

        TestRequest testRequest = BytesToObject(bytes)  as TestRequest;
        if (testRequest == null)
        {
            Debug.LogError("反序列化对象为空");
            return;
        }
        Debug.LogError(testRequest.ToString());
    }

    /// <summary>
    /// 将一个object对象序列化，返回一个byte[]
    /// </summary>
    public static byte[] ObjectToBytes(object obj)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            return ms.GetBuffer();
        }
    }

    /// <summary>
    /// 将一个序列化后的byte[] 数组还原
    /// </summary>
    public static object BytesToObject(byte[] Bytes)
    {
        using (MemoryStream ms = new MemoryStream(Bytes))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(ms);
        }
    }
}