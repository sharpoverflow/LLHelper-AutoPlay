﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;

public static class Utils
{

    /// <summary>
    /// GZIP解压
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public static byte[] Decompress(byte[] data)
    {
        try
        {
            MemoryStream ms = new MemoryStream(data);
            GZipStream compressedzipStream = new GZipStream(ms , CompressionMode.Decompress);
            MemoryStream outBuffer = new MemoryStream();
            byte[] block = new byte[1024];
            while (true)
            {
                int bytesRead = compressedzipStream.Read(block , 0 , block.Length);
                if (bytesRead <= 0)
                    break;
                else
                    outBuffer.Write(block , 0 , bytesRead);
            }
            compressedzipStream.Close();
            return outBuffer.ToArray();
        }
        catch (Exception ex)
        {
            Console.WriteLine("解压失败,数据 " + data.Length + " 字节");
            for (int i = 0 ; i < 20 ; i++)
            {
                Console.Write(data[i].ToString("X") + " ");
            }
            Console.WriteLine();
        }
        return null;
    }

    /// <summary>
    /// 格式化json字符串
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string FormatJsonString(string str)
    {
        try
        {
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented ,
                    Indentation = 4 ,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter , obj);
                return textWriter.ToString();
            }
            return str;
        }
        catch { }
        return str;
    }

    /// <summary>
    /// \u6789 类型字符串转unicode原字符串
    /// </summary>
    /// <param name="source"></param>
    /// <returns></returns>
    public static string Unicode2String(string source)
    {
        return new Regex(@"\\u([0-9A-F]{4})" , RegexOptions.IgnoreCase | RegexOptions.Compiled).
            Replace(source , x =>
             string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1") , 16))
            );
    }

    /// <summary>
    /// 反序列化Json
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="json"></param>
    /// <returns></returns>
    public static T Deserialize<T>(string json)
    {
        try
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return default(T);
    }

    public static string Serialize(object obj)
    {
        return JsonConvert.SerializeObject(obj , Formatting.Indented);
    }

    public static string GetWebString(string url)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream receiveStream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(receiveStream , Encoding.UTF8);
        string SourceCode = readStream.ReadToEnd();
        response.Close();
        readStream.Close();
        return SourceCode;
    }

    public static string ReplaceToSpace(this string s , params string[] remove)
    {
        for (int i = 0 ; i < remove.Length ; i++)
        {
            s = s.Replace(remove[i] , " ");
        }
        return s;
    }
}
