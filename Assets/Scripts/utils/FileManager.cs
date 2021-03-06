/**
 *
 *  You can modify and use this source freely
 *  only for the development of application related Live2D.
 *
 *  (c) Live2D Inc. All rights reserved.
 */
using UnityEngine;
using System.IO;
using System;
using live2d;
using NAudio;
using NAudio.Wave;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class FileManager
{
    public static int position = 0;
    public static int samplerate = 44100;
    public static float frequency = 440;
    public static Dictionary<String, String> Configs = new Dictionary<String, String>();

    public static void Init()
    {
        StreamReader SR = new StreamReader("Config.ini", Encoding.Default);
        String line;
        while ((line = SR.ReadLine()) != null)
        {
            String[] cline = line.Split('=');
            if (!Configs.ContainsKey(cline[0]))
                Configs.Add(cline[0], cline[1]);
        }
        SR.Close();
    }

    public static TextAsset LoadTextAsset(string path)
    {
        return (TextAsset)Resources.Load(path, typeof(TextAsset));
    }


    public static Texture2D LoadTexture(string path)
    {
        if (Configs["DefaultModel"] == "true")
        {
            return (Texture2D)Resources.Load(path, typeof(Texture2D));
        }
        else
        {
            WWW www = new WWW("file://" + path + ".png");
            return www.texture;
        }
    }


    public static AudioClip LoadAssetsSound(string filename)
    {
        if (LAppDefine.DEBUG_LOG) Debug.Log("Load voice : " + filename);


        try
        {
            if (Configs["DefaultModel"] == "true")
            {
                return (AudioClip)(Resources.Load(filename)) as AudioClip;
            }
            else
            {
                if (!File.Exists(filename + ".wav"))
                {
                    var stream = File.Open(filename + ".mp3", FileMode.Open);
                    var reader = new Mp3FileReader(stream);
                    WaveFileWriter.CreateWaveFile(filename + ".wav", reader);
                }
                return WavUtility.ToAudioClip(filename + ".wav");
            }
        }
        catch (IOException e)
        {
            Debug.Log(e.StackTrace);
            return null;
        }

    }


    public static byte[] LoadBin(string path)
    {

        if (Configs["DefaultModel"] == "true")
        {
            TextAsset ta = (TextAsset)Resources.Load(path, typeof(TextAsset));
            byte[] buf = ta.bytes;
            return buf;
        }
        else
        {
            byte[] buf;
            try
            {
                buf = File.ReadAllBytes(path);
            }
            catch (Exception e)
            {
                Debug.Log(e.Data);
                buf = File.ReadAllBytes(path + ".json");
            }
            return buf;
        }
    }


    public static String LoadString(string path)
    {
        return System.Text.Encoding.GetEncoding("UTF-8").GetString(LoadBin(path));
    }


    public static string getFilename(string url)
    {
        return Regex.Replace(url, ".*/", "");
    }


    public static string getDirName(string url)
    {
        return Regex.Replace(url, "(.*/)(.+)", "$1");
    }
}