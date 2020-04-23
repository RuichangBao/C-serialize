using System;


[Serializable]
public class TestRequest : Request
{
    public int testNum;
    public TestRequest(int testNum, int msgType,string b,bool c):base(msgType,b,c)
    {
        this.testNum = testNum;
    }

    public override string ToString()
    {
        return "TestRequest[TestNum:"+testNum+" msgType:" + msgType + "b:" + b + "    c:" + c + "]";
    }
}