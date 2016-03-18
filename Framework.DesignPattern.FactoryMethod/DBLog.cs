﻿/**********************************************************************************
 * 
 * 工厂方法模式：定义一个用于创建对象的接口，但是让子类决定将哪一个类实例化。工厂方法模式让一个类的实例化延迟到其子类。
 * 
 * **********************************************************************************/

using System;

namespace Framework.DesignPattern.FactoryMethod
{
    public class DBLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine("DB" + message);
        }
    }
}