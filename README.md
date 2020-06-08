# Uni Json Interface

JsonUtility.ToJson を拡張メソッドで呼び出せるようにするインターフェイス  

## 使用例

```cs
using Kogane;
using System;
using UnityEngine;

[Serializable]
public class Character : IJson
{
    [SerializeField] private int    m_id   = 25;
    [SerializeField] private string m_name = "ピカチュウ";
}

public class Example : MonoBehaviour
{
    private void Start()
    {
        var character = new Character();

        // {"m_id":25,"m_name":"ピカチュウ"}
        Debug.Log( character.ToJson() );

        // {
        //     "m_id": 25,
        //     "m_name": "ピカチュウ"
        // }
        Debug.Log( character.ToReadableJson() );
    }
}
```
