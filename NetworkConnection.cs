using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System;
using System.Threading.Tasks;
using System.Text;

public class NetworkConnection
{
    // Singleton
    private static NetworkConnection connection;

    private NetworkConnection()
    { }

    public static NetworkConnection getInstance()
    {
        if (connection == null)
        {
            connection = new NetworkConnection();
            Debug.Log("NetworkConnection created");
        }
            
        return connection;
    }
    // *Singleton

    int x = 0;
    bool connectedToServer = false;
    Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    NetworkStream stream;

    async public Task<bool> ConnectToTheServer()
    {
        try
        {
            await serverSocket.ConnectAsync("192.168.31.70", 7777);
            Debug.Log(this + ": Connected to " + serverSocket.RemoteEndPoint);
            connectedToServer = true;
            stream = new NetworkStream(serverSocket);
        }
        catch (Exception e)
        { 
            Debug.Log(this + ": Can not connect to server: " + e);
            return false;
        }
        return true; 
    }

    async public void SendMessage(string message)
    {
        if (connectedToServer)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(data, 0, data.Length);
        } else
        {
            Debug.Log(this + ": You are not connected to the server!");
        }
    }



    public void Write(string str)
    {
        Debug.Log(str);
    }

    public void SetX(int num) 
    {
        x = num;
    }

    public int GetX() 
    {
        return x;
    }

}
