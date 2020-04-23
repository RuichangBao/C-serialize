using System;


[Serializable]
public class Request
{
    public int msgType;

    public string b;

    public bool c;
    public Request()
    {

    }
    public Request(int msgType, string b,bool c)
    {
        this.msgType = msgType;
        this.b = b;
        this.c = c;
    }

    public override string ToString()
    {
        return "Request[msgType:" + msgType + "b:" + b + "    c:" + c + "]";
    }
}