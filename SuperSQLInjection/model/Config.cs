﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SuperSQLInjection.model
{
    [Serializable]
    public class Config
    {
        public Config() {
        
        }
        public String domain = "";
        public int port = 80;
        public int maxTime = 10;//延时注入判断阀值
        public InjectType injectType=new InjectType();
        public DBType dbType = new DBType();
        public int timeOut = 10;//秒
        public int threadSize = 1;
        public int reTry = 2;
        public String encoding = "UTF-8";
        public String request = "";
        public String key = "";
        public String db_encoding = "";
        public Boolean useCode = false;
        public int columnsCount = 0;
        public int showColumn = 0;
        public Boolean reverseKey = false;//反取关键字
        public KeyType keyType = KeyType.Key;//判断类型，可以盲注以关键字或时间判断
        public Boolean isMuStr = true;//开启多字节字符
        public Boolean is_foward_302 = false;
        public Boolean isOpenInfoLog=true;//开启底部日志
        public Boolean isOpenHTTPLog = true;//开启HTTP日志
        public Boolean isAutoCheckUpdate = true;//自动检查更新
        public Boolean isSavaConfigWhenClose = true;//自动保存配置
        public Boolean useSSL = false;//ssl
        public Boolean isOpenURLEncoding = true;//开启URL编码
        public Boolean redirectDoGet = false;//重定向使用的请求方法
        public int maxClolumns = 50;
        public int urlencodeCount = 1;//url编码次数

        //file
        public String readFileEncoding = "GBK";

        //cmd
        public Boolean showCmdResult = true;

        //bypass

        public Boolean reaplaceBeforURLEncode = true;//是否在URL编码前处理bypass字符
        public Boolean inculdeStr = false;
        public int keyReplace = 0;
        public String randIPToHeader = "";
        public int sendHTTPSleepTime = 0;
        public String replaceStrs="";//字符替换
        public Boolean base64 = false;//base64
        public int base64Count = 0;
        //scan
        public int level = 0;
        public int linkCount = 1;
        public int maxSpiderCount=10;
        public int maxScanCount = 10;
    }
}
